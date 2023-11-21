using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_Progra_I
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bd_veterinaria_huellitasDataSet.datosProductos' Puede moverla o quitarla según sea necesario.
            this.datosProductosTableAdapter.Fill(this.bd_veterinaria_huellitasDataSet.datosProductos);
            // TODO: esta línea de código carga datos en la tabla 'bd_veterinaria_huellitasDataSet.productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.bd_veterinaria_huellitasDataSet.productos);
            // TODO: esta línea de código carga datos en la tabla 'bd_veterinaria_huellitasDataSet.tipoProducto' Puede moverla o quitarla según sea necesario.
            this.tipoProductoTableAdapter.Fill(this.bd_veterinaria_huellitasDataSet.tipoProducto);
            // TODO: esta línea de código carga datos en la tabla 'bd_veterinaria_huellitasDataSet.marcas' Puede moverla o quitarla según sea necesario.
            this.marcasTableAdapter.Fill(this.bd_veterinaria_huellitasDataSet.marcas);

        }

        private void btnPrimeroProducto_Click(object sender, EventArgs e)
        {
            productosBindingSource.MoveFirst();
        }

        private void btnAnteriorProducto_Click(object sender, EventArgs e)
        {
            productosBindingSource.MovePrevious();
        }

        private void btnSiguienteProducto_Click(object sender, EventArgs e)
        {
            productosBindingSource.MoveNext();
        }

        private void btnUltimoProducto_Click(object sender, EventArgs e)
        {
            productosBindingSource.MoveLast();
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            if (btnNuevoProducto.Text == "Nuevo producto")
            {
                btnNuevoProducto.Text = "Guardar";
                btnModificarProducto.Text = "Cancelar";
                //estadoControles(true);

                productosBindingSource.AddNew();
            }
            else
            {
                productosBindingSource.EndEdit();
                this.productosTableAdapter.Update(bd_veterinaria_huellitasDataSet);
                this.datosProductosTableAdapter.Fill(bd_veterinaria_huellitasDataSet.datosProductos);
                //estadoControles(false);
                btnNuevoProducto.Text = "Nuevo producto";
                btnModificarProducto.Text = "Modificar datos";

            }
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            if (btnModificarProducto.Text == "Modificar datos")
            {
                btnNuevoProducto.Text = "Guardar";
                btnModificarProducto.Text = "Cancelar";
                // estadoControles(true);

            }
            else
            {
                productosBindingSource.CancelEdit();

                //estadoControles(false);
                btnNuevoProducto.Text = "Nuevo producto";
                btnModificarProducto.Text = "Modificar datos";
            }
        }
    }
}
