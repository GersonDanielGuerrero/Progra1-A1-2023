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
    public partial class Productos : Form
    {
        Conexion objConexion = new Conexion();
        DataSet miDs = new DataSet();
        DataTable miTabla = new DataTable();
        int posicion = 0;
        string accion = "nuevo";
        public Productos()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Productos_Load(object sender, EventArgs e)
        {

            actualizarDsProductos();
            cboOpcionBuscarProductos.SelectedIndex = 0;
        }
        private void actualizarDsProductos()
        {
            miDs.Clear();
            miDs = objConexion.obtenerDatos();
            miTabla = miDs.Tables["Productos"];
            miTabla.PrimaryKey = new DataColumn[] { miTabla.Columns["idProducto"] };
            mostrarProductos();
            mostrarDatosProducto();
        }
        private void mostrarProductos()
        {
            grdListaProductos.DataSource = miDs.Tables["productos"].DefaultView;
        }
        private void mostrarDatosProducto()
        {

            txtNombreProducto.Text = miDs.Tables["productos"].Rows[posicion].ItemArray[1].ToString();
           txtMarcaProducto.Text = miDs.Tables["productos"].Rows[posicion].ItemArray[2].ToString();
            txtPrincipiosActivosProducto.Text = miDs.Tables["productos"].Rows[posicion].ItemArray[3].ToString();
            txtDescripcionProducto.Text = miDs.Tables["productos"].Rows[posicion].ItemArray[4].ToString();
            txtPrecioProducto.Text = miDs.Tables["productos"].Rows[posicion].ItemArray[5].ToString();
        }

        private void estadoControles(Boolean estado)
        {
            txtNombreProducto.ReadOnly = estado;
           txtMarcaProducto.ReadOnly = estado;
            txtPrincipiosActivosProducto.ReadOnly = estado;
            txtDescripcionProducto.ReadOnly = estado;
            txtPrecioProducto.ReadOnly = estado;


            grbNavegacionProducto.Enabled = estado;
            btnEliminarProducto.Enabled = estado;
            txtBuscarProductos.ReadOnly = !estado;
        }
        private void btnNuevoProducto_Click(object sender, EventArgs e)

        {

            if (btnNuevoProducto.Text == "Nuevo producto")
            {
                btnNuevoProducto.Text = "Guardar";
                btnModificarProducto.Text = "Cancelar";
                estadoControles(false);
                limpiarCajas();
                accion = "nuevo";
            }
            else
            {//Guardar    

                String[] productos = new string[] {
                    accion,txtNombreProducto.Text,txtMarcaProducto.Text,txtPrincipiosActivosProducto.Text,txtDescripcionProducto.Text,
                    txtPrecioProducto.Text, miTabla.Rows[posicion].ItemArray[0].ToString()
                };

                String msg = objConexion.mantenimientoProductos(productos);
                if (msg != "1")
                {
                    MessageBox.Show("Error en el registro de productos: " + msg, "Registro de productos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    actualizarDsProductos();
                    estadoControles(true);
                    btnNuevoProducto.Text = "Nuevo producto";
                    btnModificarProducto.Text = "Modificar datos";
                }
            }
        }
        private void limpiarCajas()
        {
            txtNombreProducto.Text = "";
            txtMarcaProducto.Text = "";
            txtPrincipiosActivosProducto.Text = "";
            txtDescripcionProducto.Text = "";
            txtPrecioProducto.Text = "";
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            if (btnModificarProducto.Text == "Modificar datos")
            {
                btnNuevoProducto.Text = "Guardar";
                btnModificarProducto.Text = "Cancelar";
                estadoControles(false);
                accion = "modificar";
            }
            else
            {

                estadoControles(true);
                mostrarDatosProducto();
                btnNuevoProducto.Text = "Nuevo producto";
                btnModificarProducto.Text = "Modificar datos";
            }
        }
        private void seleccionarProducto()
        {
            posicion = miTabla.Rows.IndexOf(miTabla.Rows.Find(grdListaProductos.CurrentRow.Cells["idProducto"].Value.ToString()));
            mostrarDatosProducto();
        }

        private void grdListaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarProducto();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar a " + txtNombreProducto.Text, "Eliminado Productos",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String[] productos = new string[] {
                    "eliminar",txtNombreProducto.Text,txtMarcaProducto.Text,txtPrincipiosActivosProducto.Text,txtDescripcionProducto.Text,
                    txtPrecioProducto.Text, miTabla.Rows[posicion].ItemArray[0].ToString()
                };
                String msg = objConexion.mantenimientoClientes(productos);
                if (msg != "1")
                {
                    MessageBox.Show("Error en la eliminacion de Productos: " + msg, "Registro de ¨Productos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    actualizarDsProductos();
                }
            }
        }


        private void filtrarProductos(String valor, int opcion)
        {
            try
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = grdListaProductos.DataSource;
                bs.Filter = opcion == 0 ? "nombre like '%" + valor + "%'" : opcion == 1 ? "marca like '%" + valor + "%'" : opcion == 2 ? "principiosActivos like '%" + valor + "%'" : opcion == 3 ? "descripcion like '%" + valor + "%'" : "precio =" + valor;
                grdListaProductos.DataSource = bs;
                erpProductos.SetError(txtBuscarProductos, "");
            }
            catch (Exception e)
            {
                erpProductos.SetError(txtBuscarProductos, "Por favor ingrese un dato a buscar");
            }
        }

        private void txtBuscarProductos_KeyUp(object sender, KeyEventArgs e)
        {

            filtrarProductos(txtBuscarProductos.Text, cboOpcionBuscarProductos.SelectedIndex);
            if (e.KeyValue == 13)
            {//tecla enter
                seleccionarProducto();
            }
        }
    }
}
