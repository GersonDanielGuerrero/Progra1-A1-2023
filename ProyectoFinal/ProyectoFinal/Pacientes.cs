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
    public partial class Pacientes : Form
    {
        Conexion objConexion = new Conexion();
        DataSet miDs = new DataSet();
        DataTable miTabla = new DataTable();
        int posicion = 0;
        string accion = "nuevo";
        public Pacientes()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Pacientes_Load(object sender, EventArgs e)
        {

            actualizarDsPacientes();
            cboOpcionBuscarPacientes.SelectedIndex = 0;
        }
        private void actualizarDsPacientes()
        {
            miDs.Clear();
            miDs = objConexion.obtenerDatos();
            miTabla = miDs.Tables["pacientes"];
            miTabla.PrimaryKey = new DataColumn[] { miTabla.Columns["idPaciente"] };
            mostrarPacientes();
            mostrarDatosPaciente();
        }
        private void mostrarPacientes()
        {
            grdListaPacientes.DataSource = miDs.Tables["pacientes"].DefaultView;
        }
        private void mostrarDatosPaciente()
        {

            txtNombrePaciente.Text = miDs.Tables["pacientes"].Rows[posicion].ItemArray[1].ToString();
            dtpNacimientoPaciente.Value = Convert.ToDateTime(miDs.Tables["pacientes"].Rows[posicion].ItemArray[2]);
            txtEstaturaPaciente.Text = miDs.Tables["pacientes"].Rows[posicion].ItemArray[3].ToString();
            txtPesoPaciente.Text = miDs.Tables["pacientes"].Rows[posicion].ItemArray[4].ToString();
            txtColorPaciente.Text = miDs.Tables["pacientes"].Rows[posicion].ItemArray[5].ToString();
            txtEspeciePaciente.Text = miDs.Tables["pacientes"].Rows[posicion].ItemArray[6].ToString();
            txtRazaPaciente.Text = miDs.Tables["pacientes"].Rows[posicion].ItemArray[7].ToString();
            txtDescripcionAdicionalPaciente.Text = miDs.Tables["pacientes"].Rows[posicion].ItemArray[8].ToString();

        }

        private void btnSiguientePaciente_Click(object sender, EventArgs e)
        {
            if (posicion < miDs.Tables["pacientes"].Rows.Count - 1)
                posicion++;

            mostrarDatosPaciente();
        }

        private void btnUltimoPaciente_Click(object sender, EventArgs e)
        {
            posicion = miDs.Tables["pacientes"].Rows.Count - 1;
            mostrarDatosPaciente();
        }

        private void btnAnteriorPaciente_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
                posicion--;
            mostrarDatosPaciente();
        }

        private void btnPrimeroPaciente_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatosPaciente();
        }

        private void estadoControles(Boolean estado)
        {
            txtNombrePaciente.ReadOnly = estado;
            dtpNacimientoPaciente.Enabled = !estado;
            txtNombrePaciente.ReadOnly = estado;
            txtEstaturaPaciente.ReadOnly = estado;
            txtPesoPaciente.ReadOnly = estado;
            txtColorPaciente.ReadOnly = estado;
            txtEspeciePaciente.ReadOnly = estado;
            txtRazaPaciente.ReadOnly = estado;
            txtDescripcionAdicionalPaciente.ReadOnly = estado;


            grbNavegacionPaciente.Enabled = estado;
            btnEliminarPaciente.Enabled = estado;
            txtBuscarPacientes.ReadOnly = !estado;
        }
        private void btNuevoPaciente_Click(object sender, EventArgs e)

        {

            if (btNuevoPaciente.Text == "Nuevo paciente")
            {
                btNuevoPaciente.Text = "Guardar";
                btnModificarPaciente.Text = "Cancelar";
                estadoControles(false);
                limpiarCajas();
                accion = "nuevo";
            }
            else
            {//Guardar    

                String[] pacientes = new string[] {
                    accion,txtNombrePaciente.Text,dtpNacimientoPaciente.Value.ToShortDateString(),txtEstaturaPaciente.Text,txtPesoPaciente.Text
                    ,txtColorPaciente.Text,txtEspeciePaciente.Text,txtRazaPaciente.Text,txtDescripcionAdicionalPaciente.Text, miTabla.Rows[posicion].ItemArray[0].ToString()
                };

                String msg = objConexion.mantenimientoPacientes(pacientes);
                if (msg != "1")
                {
                    MessageBox.Show("Error en el registro de pacientes: " + msg, "Registro de pacientes.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    actualizarDsPacientes();
                    estadoControles(true);
                    btNuevoPaciente.Text = "Nuevo paciente";
                    btnModificarPaciente.Text = "Modificar datos";
                }
            }
        }
        private void limpiarCajas()
        {
            txtNombrePaciente.Text = "";
           txtEstaturaPaciente.Text = "";
            txtPesoPaciente.Text = "";
            txtColorPaciente.Text = "";
            txtEspeciePaciente.Text = "";
            txtRazaPaciente.Text = "";
            txtDescripcionAdicionalPaciente.Text = "";
            dtpNacimientoPaciente.Value = DateTime.Today;
        }

        private void btnModificarPaciente_Click(object sender, EventArgs e)
        {
            if (btnModificarPaciente.Text == "Modificar datos")
            {
                btNuevoPaciente.Text = "Guardar";
                btnModificarPaciente.Text = "Cancelar";
                estadoControles(false);
                accion = "modificar";
            }
            else
            {

                estadoControles(true);
                mostrarDatosPaciente();
                btNuevoPaciente.Text = "Nuevo paciente";
                btnModificarPaciente.Text = "Modificar datos";
            }
        }
        private void seleccionarPaciente()
        {
            posicion = miTabla.Rows.IndexOf(miTabla.Rows.Find(grdListaPacientes.CurrentRow.Cells["idPaciente"].Value.ToString()));
            mostrarDatosPaciente();
        }

        private void grdListaPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarPaciente();
        }

        private void btnEliminarPaciente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar a " + txtNombrePaciente.Text, "Eliminado Pacientes",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String[] pacientes = new string[] {
                    "eliminar",txtNombrePaciente.Text,dtpNacimientoPaciente.Value.ToShortDateString(),txtEstaturaPaciente.Text,txtPesoPaciente.Text
                    ,txtColorPaciente.Text,txtEspeciePaciente.Text,txtRazaPaciente.Text,txtDescripcionAdicionalPaciente.Text, miTabla.Rows[posicion].ItemArray[0].ToString()
                };
                String msg = objConexion.mantenimientoClientes(pacientes);
                if (msg != "1")
                {
                    MessageBox.Show("Error en la eliminacion de pacientes: " + msg, "Registro de Pacientes.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    actualizarDsPacientes();
                }
            }
        }


        private void filtrarClientes(String valor, int opcion)
        {
            try
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = grdListaPacientes.DataSource;
                bs.Filter = opcion == 0 ? "nombre like '%" + valor + "%'" : opcion == 1 ? "estatura=" +valor : opcion == 2 ? "peso=" + valor : opcion == 3 ? "color like '%" + valor + "%'" : opcion == 4 ? "especie like '%" + valor + "%'" : opcion == 5 ? "raza like '%" + valor + "%'" : "descripcionAdicional like '%" + valor + "%'";
                grdListaPacientes.DataSource = bs;
                erpPaciente.SetError(txtBuscarPacientes, "");
            }
            catch (Exception e)
            {
                erpPaciente.SetError(txtBuscarPacientes, "Por favor ingrese un dato a buscar");
            }
        }

        private void txtBuscarPacientes_KeyUp(object sender, KeyEventArgs e)
        {

            filtrarClientes(txtBuscarPacientes.Text, cboOpcionBuscarPacientes.SelectedIndex);
            if (e.KeyValue == 13)
            {//tecla enter
                seleccionarPaciente();
            }
        }
    }
}
