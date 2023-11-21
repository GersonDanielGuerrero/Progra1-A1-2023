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
    public partial class Servicios : Form
    {
        public Servicios()
        {
            InitializeComponent();
        }

        private void Servicios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bd_veterinaria_huellitasDataSet.tipoServicios' Puede moverla o quitarla según sea necesario.
            this.tipoServiciosTableAdapter.Fill(this.bd_veterinaria_huellitasDataSet.tipoServicios);
            

        }

        private void btnPrimeroPaciente_Click(object sender, EventArgs e)
        {
            tipoServiciosBindingSource.MoveFirst();
        }

        private void btnAnteriorServicio_Click(object sender, EventArgs e)
        {
            tipoServiciosBindingSource.MovePrevious();
        }

        private void btnSiguienteServicio_Click(object sender, EventArgs e)
        {
            tipoServiciosBindingSource.MoveNext();
        }

        private void btnUltimoServicio_Click(object sender, EventArgs e)
        {
            tipoServiciosBindingSource.MoveLast();
        }

        private void btnNuevoServicio_Click(object sender, EventArgs e)
        {
            if (btnNuevoServicio.Text == "Nuevo servicio")
            {
                btnNuevoServicio.Text = "Guardar";
                btnModificarServicio.Text = "Cancelar";
                //estadoControles(true);

                tipoServiciosBindingSource.AddNew();
            }
            else
            {
                tipoServiciosBindingSource.EndEdit();
                this.tipoServiciosTableAdapter.Update(bd_veterinaria_huellitasDataSet);
                //estadoControles(false);
                btnNuevoServicio.Text = "Nuevo servicio";
                btnModificarServicio.Text = "Modificar datos";

            }
        }

        private void btnModificarServicio_Click(object sender, EventArgs e)
        {
            if (btnModificarServicio.Text == "Modificar datos")
            {
                btnNuevoServicio.Text = "Guardar";
                btnModificarServicio.Text = "Cancelar";
                // estadoControles(true);

            }
            else
            {
                tipoServiciosBindingSource.CancelEdit();

                //estadoControles(false);
                btnNuevoServicio.Text = "Nuevo servicio";
                btnModificarServicio.Text = "Modificar datos";
            }
        }
    }
}
