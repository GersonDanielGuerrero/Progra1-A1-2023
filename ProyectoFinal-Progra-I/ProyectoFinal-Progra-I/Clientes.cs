using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProyectoFinal_Progra_I
{
    public partial class Clientes : Form
    {
        Clinica cl = new Clinica();
        Conexion objConexion = new Conexion();
        DataSet miDs = new DataSet();
        DataTable miTabla = new DataTable();
        public int posicion = 0;
        String accion = "nuevo";
        byte[] bytesFotoCliente = null;
        int idClienteSeleccionado = 1;


        public Clientes()
        {
            InitializeComponent();

        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bd_veterinaria_huellitasDataSet.pacientes' Puede moverla o quitarla según sea necesario.
            this.pacientesTableAdapter.Fill(this.bd_veterinaria_huellitasDataSet.pacientes);
            // TODO: esta línea de código carga datos en la tabla 'bd_veterinaria_huellitasDataSet.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.bd_veterinaria_huellitasDataSet.clientes);

            estadoControles(false);
            actualizarDatosCliente();

        }
        private void estadoControles(bool estado)
        {
            cl.estadoControles(estado, grbDatosCliente);
            cl.estadoControles(!estado, grbNavegacionCliente);
            cboOpcionBuscarCliente.Enabled = !estado;
            txtBuscarCliente.Enabled = !estado;
        }
        private void actualizarDatosCliente()
        {
            DataRowView clienteSelecionado = (DataRowView)clientesBindingSource.Current;
             idClienteSeleccionado = (int)clienteSelecionado["idCliente"];
            pacientesBindingSource.Filter = $"idCliente = {idClienteSeleccionado}";
            txtNombreCliente.Text.Trim();
            lblPosicionCliente.Text = $"{clientesBindingSource.Position + 1} de {clientesBindingSource.Count}";

            //Si no hay una imagen guardada en la db, asigna una por defecto
            if (pbFotoCliente.Image == null)
            {
                pbFotoCliente.Image = Principal.imageList1.Images["Cliente.jpeg"];
            }
        }

        private void btnPrimeroCliente_Click(object sender, EventArgs e)
        {
            clientesBindingSource.MoveFirst();
            actualizarDatosCliente();
        }

        private void btnAnteriorCliente_Click(object sender, EventArgs e)
        {
            clientesBindingSource.MovePrevious();
            actualizarDatosCliente();
        }

        private void btnSiguienteCliente_Click(object sender, EventArgs e)
        {
            clientesBindingSource.MoveNext();
            actualizarDatosCliente();
        }

        private void btnUltimoCliente_Click(object sender, EventArgs e)
        {
            clientesBindingSource.MoveLast();
            actualizarDatosCliente();
        }


        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            if (btnModificarCliente.Text == "Modificar datos")
            {
                btnNuevoCliente.Text = "Guardar";
                btnModificarCliente.Text = "Cancelar";
                 estadoControles(true);

            }
            else
            {
                clientesBindingSource.CancelEdit();

                estadoControles(false);
                btnNuevoCliente.Text = "Nuevo cliente";
                btnModificarCliente.Text = "Modificar datos";
            }
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            if (btnNuevoCliente.Text == "Nuevo cliente")
            {
                btnNuevoCliente.Text = "Guardar";
                btnModificarCliente.Text = "Cancelar";
                estadoControles(true);
                
                    clientesBindingSource.AddNew();
            }
            else
            {
                if (!cl.ValidarDatos(grbDatosCliente,erpClientes))
                 
                {
                    clientesBindingSource.EndEdit();
                    this.clientesTableAdapter.Update(bd_veterinaria_huellitasDataSet);

                    estadoControles(false);
                    btnNuevoCliente.Text = "Nuevo cliente";
                    btnModificarCliente.Text = "Modificar datos";

                }
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            clientesBindingSource.RemoveCurrent();
            this.clientesTableAdapter.Update(bd_veterinaria_huellitasDataSet);
            lblPosicionCliente.Text = $"{clientesBindingSource.Position + 1} de {clientesBindingSource.Count}";
        }

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            filtrarClientes(txtBuscarCliente.Text,cboOpcionBuscarCliente.SelectedIndex);
        }
        private void filtrarClientes(String valor, int opcion)
        {
            try
            {
                clientesBindingSource.Filter = opcion == 0 ? "nombre like '%" + valor + "%'" : opcion == 1 ? "direccion like '%" + valor + "%'"
                : opcion == 2 ? "correo like '%" + valor + "%'" : opcion == 3 ? "telefono like '%" + valor + "%'" :
                opcion == 4 ? "fechaNacimiento like '%" + valor + "%'" : "fechaRegistro like '%" + valor.ToString() + "%'";
                
                erpClientes.SetError(txtBuscarCliente, "");
            }
            catch (Exception e)
            {
                erpClientes.SetError(txtBuscarCliente, "Por favor ingrese dato a buscar");
            }
        }

        private void btnAgregarFotoCliente_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                //Abre el explorador de archivos
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                   // Asigna la imagen seleccionada al PictureBox
                    pbFotoCliente.Image = new Bitmap(ofd.FileName);
                }
            }
        }

        /*
private void Clientes_Load(object sender, EventArgs e)
{
actualizarDsClientes();
cboOpcionBuscarCliente.SelectedIndex = 0;

}
private void actualizarDsClientes()
{
miDs.Clear();
miDs = objConexion.obtenerDatos();
miTabla = miDs.Tables["Clientes"];
miTabla.PrimaryKey = new DataColumn[] { miTabla.Columns["idCliente"] };
mostrarClientes();
mostrarDatosCliente();
}
private void mostrarClientes()
{

grdDatosClientes.DataSource = miTabla.DefaultView;
}

//C A M B I A    S E G U N   E L    F O R M U L A R I O
private void filtrarClientes(String valor, int opcion)
{
try
{
BindingSource bs = new BindingSource();
bs.DataSource = grdDatosClientes.DataSource;
bs.Filter = opcion == 0 ? "nombre like '%" + valor + "%'" : opcion == 1 ? "direccion like '%" + valor + "%'" 
: opcion == 2 ? "correo like '%" + valor + "%'" : opcion == 3 ? "telefono like '%" + valor + "%'" :
opcion == 4 ? "fechaNacimiento like '%" + valor + "%'" :"fechaRegistro like '%" + valor.ToString() + "%'" ;
grdDatosClientes.DataSource = bs;
erpClientes.SetError(txtBuscarCliente, "");
}
catch (Exception e)
{
erpClientes.SetError(txtBuscarCliente, "Por favor ingrese dato a buscar");
}
}


//C A M B I A    S E G U N   E L    F O R M U L A R I O
private void mostrarDatosCliente()
{
if (miTabla.Rows.Count > 0)
{

txtNombreCliente.Text = miTabla.Rows[posicion].ItemArray[1].ToString().Trim();
txtDireccionCliente.Text = miTabla.Rows[posicion].ItemArray[2].ToString().Trim();
txtCorreoCliente.Text = miTabla.Rows[posicion].ItemArray[3].ToString().Trim();
txtTelefonoCliente.Text = miTabla.Rows[posicion].ItemArray[4].ToString().Trim();
dtpNacimietoCliente.Value = (DateTime)miTabla.Rows[posicion].ItemArray[5];
dtpRegistroCliente.Value = (DateTime)miTabla.Rows[posicion].ItemArray[6];
try
{ 
bytesFotoCliente = (byte[])miTabla.Rows[posicion].ItemArray[7];
using (MemoryStream ms = new MemoryStream(bytesFotoCliente))
pbFotoCliente.Image = Image.FromStream(ms);
}
catch { }



lblPosicionCliente.Text = (posicion + 1) + " de " + miTabla.Rows.Count;

}
else
{
limpiarCajas();
}
}

private void btnSiguienteCliente_Click(object sender, EventArgs e)
{
if (posicion < miTabla.Rows.Count - 1)
{
posicion++;
mostrarDatosCliente();
}
}

private void btnUltimoCliente_Click(object sender, EventArgs e)
{
posicion = miTabla.Rows.Count - 1;
mostrarDatosCliente();
}

private void btnAnteriorCliente_Click(object sender, EventArgs e)
{
if (posicion > 0)
{
posicion--;
mostrarDatosCliente();
}

}

private void btnPrimeroCliente_Click(object sender, EventArgs e)
{
posicion = 0;
mostrarDatosCliente();
}

private void btnNuevoCliente_Click(object sender, EventArgs e)
{
if (btnNuevoCliente.Text == "Nuevo cliente")
{
btnNuevoCliente.Text = "Guardar";
btnModificarCliente.Text = "Cancelar";
estadoControles(false);
limpiarCajas();
accion = "nuevo";
}
else
{
TextBox[] camposObligatorios = { txtNombreCliente, txtDireccionCliente };
bool camposCompletos = true;

foreach (TextBox textBox in camposObligatorios)
{
if (string.IsNullOrWhiteSpace(textBox.Text))
{
erpClientes.SetError(textBox, "Este campo no puede estar vacío");
camposCompletos = false;
}
else
{
erpClientes.SetError(textBox, "");
}
}
if (camposCompletos)
{
guardarDatosCliente();
}
else
{
MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
}
}
}

private void btnModificarCliente_Click(object sender, EventArgs e)
{
if (btnModificarCliente.Text == "Modificar datos")
{
btnNuevoCliente.Text = "Guardar";
btnModificarCliente.Text = "Cancelar";
estadoControles(false);
accion = "modificar";
}
else
{
TextBox[] camposObligatorios = { txtNombreCliente, txtDireccionCliente };

foreach (TextBox textBox in camposObligatorios)
erpClientes.SetError(textBox, "");

estadoControles(true);
mostrarDatosCliente();
btnNuevoCliente.Text = "Nuevo cliente";
btnModificarCliente.Text = "Modificar datos";
}
}


//C A M B I A    S E G U N   E L    F O R M U L A R I O
private void estadoControles(Boolean estado)
{

txtNombreCliente.ReadOnly = estado;
txtTelefonoCliente.ReadOnly = estado;
txtDireccionCliente.ReadOnly = estado;
txtCorreoCliente.ReadOnly = estado;
dtpNacimietoCliente.Enabled = !estado;
btnAgregarFotoCliente.Enabled = !estado;

grbNavegacionCliente.Enabled = estado;
btnEliminarCliente.Enabled = estado;
txtBuscarCliente.ReadOnly = !estado;

}
private void limpiarCajas()
{
txtNombreCliente.Text = "";
txtDireccionCliente.Text = "";
txtCorreoCliente.Text = "";
txtTelefonoCliente.Text = "";
dtpNacimietoCliente.Value = DateTime.Today;
dtpRegistroCliente.Value = DateTime.Today;
}


private void txtBuscarCliente_KeyUp(object sender, KeyEventArgs e)
{
filtrarClientes(txtBuscarCliente.Text, cboOpcionBuscarCliente.SelectedIndex);
if (e.KeyValue == 13)
{//tecla enter
seleccionarCliente();
}
}
private void seleccionarCliente()
{
try { 
posicion = miTabla.Rows.IndexOf(miTabla.Rows.Find(grdDatosClientes.CurrentRow.Cells["idCliente"].Value.ToString()));
mostrarDatosCliente();
}
catch { }
}

private void grdDatosClientes_CellClick(object sender, DataGridViewCellEventArgs e)
{
seleccionarCliente();
}

private void btnEliminarCliente_Click(object sender, EventArgs e)
{
accion = "eliminar";
if (MessageBox.Show("Esta seguro de eliminar a " + txtNombreCliente.Text.Trim()+"?", "Eliminado Clientes",
MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
{


//C A M B I A    S E G U N   E L    F O R M U L A R I O

String msg = objConexion.mantenimientoClientes(accion, Convert.ToInt32(miTabla.Rows[posicion].ItemArray[0]),txtNombreCliente.Text,
txtDireccionCliente.Text,txtCorreoCliente.Text,txtTelefonoCliente.Text,dtpNacimietoCliente.Value.Date,dtpRegistroCliente.Value.Date,bytesFotoCliente);
if (msg != "1")
{
MessageBox.Show("Error en la eliminacion de Clientes: " + msg, "Registro de Clientes.", MessageBoxButtons.OK, MessageBoxIcon.Error);
}
else
{
posicion = 0;
actualizarDsClientes();
}
}
accion = "nuevo";
}

private void guardarDatosCliente()
{

String msg = objConexion.mantenimientoClientes(accion, Convert.ToInt32(miTabla.Rows[posicion].ItemArray[0].ToString()), txtNombreCliente.Text,
txtDireccionCliente.Text, txtCorreoCliente.Text, txtTelefonoCliente.Text, dtpNacimietoCliente.Value.Date, dtpRegistroCliente.Value.Date,bytesFotoCliente);
if (msg != "1")
{
MessageBox.Show("Error en el registro de Clientes: " + msg, "Registro de Clientes.", MessageBoxButtons.OK, MessageBoxIcon.Error);
}
else
{
actualizarDsClientes();
estadoControles(true);
btnNuevoCliente.Text = "Nuevo cliente";
btnModificarCliente.Text = "Modificar datos";
}

}

private void btnAgregarFotoCliente_Click(object sender, EventArgs e)
{
OpenFileDialog ofd = new OpenFileDialog();
ofd.Filter = "Archivo de imagen |*.jpg;*.png;*.jpeg";
if (ofd.ShowDialog().Equals(DialogResult.OK))
{
string ruta = ofd.FileName;
bytesFotoCliente = File.ReadAllBytes(ruta);
using(MemoryStream ms = new MemoryStream(bytesFotoCliente))
pbFotoCliente.Image = Image.FromStream(ms);

}
}

*/
    }
}
