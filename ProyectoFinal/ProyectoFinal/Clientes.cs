using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Clientes : Form
    {
        Conexion objConexion = new Conexion();
        DataSet miDs = new DataSet();
        DataTable miTabla = new DataTable();
        int posicion = 0;
        string accion = "nuevo";
        public Clientes()
        {
            InitializeComponent();

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            actualizarDsClientes();
            cboOpcionBuscarClientes.SelectedIndex = 0;
        }
        private void actualizarDsClientes()
        {
            miDs.Clear();
            miDs = objConexion.obtenerDatos();
            miTabla = miDs.Tables["clientes"];
            miTabla.PrimaryKey = new DataColumn[] { miTabla.Columns["idCliente"] };
            mostrarClientes();
            mostrarDatosCliente();
        }
        private void mostrarClientes()
        {
            grdListaClientes.DataSource = miDs.Tables["clientes"].DefaultView;
        }
        private void mostrarDatosCliente()
        {

            txtNombreCliente.Text = miDs.Tables["clientes"].Rows[posicion].ItemArray[1].ToString();
            dtpNacimientoCliente.Value = Convert.ToDateTime(miDs.Tables["clientes"].Rows[posicion].ItemArray[2]);
            txtTelefonoCliente.Text = miDs.Tables["clientes"].Rows[posicion].ItemArray[3].ToString();
            txtDireccionCliente.Text = miDs.Tables["clientes"].Rows[posicion].ItemArray[4].ToString();
            txtCorreoCliente.Text = miDs.Tables["clientes"].Rows[posicion].ItemArray[5].ToString();
           
        }

        private void btnSiguienteCliente_Click(object sender, EventArgs e)
        {
            if (posicion < miDs.Tables["clientes"].Rows.Count - 1)
                posicion++;

            mostrarDatosCliente();
        }

        private void btnUltimoCliente_Click(object sender, EventArgs e)
        {
            posicion = miDs.Tables["clientes"].Rows.Count - 1;
            mostrarDatosCliente();
        }

        private void btnAnteriorCliente_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
                posicion--;
            mostrarDatosCliente();
        }

        private void btnPrimeroCliente_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatosCliente();
        }

        private void estadoControles(Boolean estado)
        {
            txtNombreCliente.ReadOnly = estado;
            dtpNacimientoCliente.Enabled = !estado;
            txtCorreoCliente.ReadOnly = estado;
            txtDireccionCliente.ReadOnly = estado;
            txtTelefonoCliente.ReadOnly = estado;


            grbNavegacionCliente.Enabled = estado;
            btnEliminarCliente.Enabled = estado;
            txtBuscarCliente.ReadOnly = !estado;
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
            {//Guardar    

                String[] clientes = new string[] {
                    accion,txtNombreCliente.Text,dtpNacimientoCliente.Value.ToShortDateString(),txtTelefonoCliente.Text,txtDireccionCliente.Text,
                    txtCorreoCliente.Text, miTabla.Rows[posicion].ItemArray[0].ToString()
                };

                String msg = objConexion.mantenimientoClientes(clientes);
                if (msg != "1")
                {
                    MessageBox.Show("Error en el registro de materias: " + msg, "Registro de Materias.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    actualizarDsClientes();
                    estadoControles(true);
                    btnNuevoCliente.Text = "Nuevo cliente";
                    btnModificarCliente.Text = "Modificar datos";
                }
            }
        }
        private void limpiarCajas()
        {
            txtNombreCliente.Text = "";
            txtDireccionCliente.Text = "";
            txtCorreoCliente.Text = "";
            txtTelefonoCliente.Text = "";
            dtpNacimientoCliente.Value = DateTime.Today;
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

                estadoControles(true);
                mostrarDatosCliente();
                btnNuevoCliente.Text = "Nuevo cliente";
                btnModificarCliente.Text = "Modificar datos";
            }
        }
        private void seleccionarCliente()
        {
            posicion = miTabla.Rows.IndexOf(miTabla.Rows.Find(grdListaClientes.CurrentRow.Cells["idCliente"].Value.ToString()));
            mostrarDatosCliente();
        }

        private void grdListaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarCliente();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar a " + txtNombreCliente.Text, "Eliminado Materias",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String[] clientes = new string[] {
                    "eliminar",txtNombreCliente.Text,dtpNacimientoCliente.Value.ToShortDateString(),txtTelefonoCliente.Text,txtDireccionCliente.Text,
                    txtCorreoCliente.Text, miTabla.Rows[posicion].ItemArray[0].ToString()
                };
                String msg = objConexion.mantenimientoClientes(clientes);
                if (msg != "1")
                {
                    MessageBox.Show("Error en la eliminacion de clientes: " + msg, "Registro de Clientes.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    actualizarDsClientes();
                }
            }
        }

        
        private void filtrarClientes(String valor, int opcion)
        {
            try
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = grdListaClientes.DataSource;
                bs.Filter = opcion == 0 ? "nombre like '%" + valor + "%'" : opcion==1? "telefono like '%" + valor + "%'":opcion==2? "direccion like '%" + valor + "%'": "correo like '%" + valor + "%'";
                grdListaClientes.DataSource = bs;
                erpClientes.SetError(txtBuscarCliente, "");
            }
            catch (Exception e)
            {
                erpClientes.SetError(txtBuscarCliente, "Por favor ingrese un dato a buscar");
            }
        }

        private void txtBuscarCliente_KeyUp(object sender, KeyEventArgs e)
        {

            filtrarClientes(txtBuscarCliente.Text, cboOpcionBuscarClientes.SelectedIndex);
            if (e.KeyValue == 13)
            {//tecla enter
                seleccionarCliente();
            }
        }
    }
}
