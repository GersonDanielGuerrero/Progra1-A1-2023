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
        Clinica cl = new Clinica();
        public Servicios()
        {
            InitializeComponent();
        }

        private void Servicios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bd_veterinaria_huellitasDataSet.tipoServicios' Puede moverla o quitarla según sea necesario.
            this.tipoServiciosTableAdapter.Fill(this.bd_veterinaria_huellitasDataSet.tipoServicios);
            estadoControles(false);
            lblPosicionServicio.Text = $"{tipoServiciosBindingSource.Position + 1} de {tipoServiciosBindingSource.Count}";
        }
        private void estadoControles(bool estado)
        {
            cl.estadoControles(estado, grbDatosServicio);
            cl.estadoControles(!estado, grbNavegacionServicio);
            cboOpcionBuscarUsuario.Enabled = !estado;
            txtBuscarUsuario.Enabled = !estado;
        }
        private void btnPrimeroPaciente_Click(object sender, EventArgs e)
        {
            tipoServiciosBindingSource.MoveFirst();
            lblPosicionServicio.Text = $"{tipoServiciosBindingSource.Position + 1} de {tipoServiciosBindingSource.Count}";
        }

        private void btnAnteriorServicio_Click(object sender, EventArgs e)
        {
            tipoServiciosBindingSource.MovePrevious();
            lblPosicionServicio.Text = $"{tipoServiciosBindingSource.Position + 1} de {tipoServiciosBindingSource.Count}";
        }

        private void btnSiguienteServicio_Click(object sender, EventArgs e)
        {
            tipoServiciosBindingSource.MoveNext();
            lblPosicionServicio.Text = $"{tipoServiciosBindingSource.Position + 1} de {tipoServiciosBindingSource.Count}";
        }

        private void btnUltimoServicio_Click(object sender, EventArgs e)
        {
            tipoServiciosBindingSource.MoveLast();
            lblPosicionServicio.Text = $"{tipoServiciosBindingSource.Position + 1} de {tipoServiciosBindingSource.Count}";
        }

        private void btnNuevoServicio_Click(object sender, EventArgs e)
        {
            if (btnNuevoServicio.Text == "Nuevo servicio")
            {
                btnNuevoServicio.Text = "Guardar";
                btnModificarServicio.Text = "Cancelar";
                estadoControles(true);

                tipoServiciosBindingSource.AddNew();
            }
            else
            {
                if (cl.ValidarDatos(grbDatosServicio))
                    MessageBox.Show("Ningun campo debe estar vacío");
                else
                {
                    tipoServiciosBindingSource.EndEdit();
                    this.tipoServiciosTableAdapter.Update(bd_veterinaria_huellitasDataSet);
                    estadoControles(false);
                    btnNuevoServicio.Text = "Nuevo servicio";
                    btnModificarServicio.Text = "Modificar datos";
                }
            }
            lblPosicionServicio.Text = $"{tipoServiciosBindingSource.Position + 1} de {tipoServiciosBindingSource.Count}";
        }

        private void btnModificarServicio_Click(object sender, EventArgs e)
        {
            if (btnModificarServicio.Text == "Modificar datos")
            {
                btnNuevoServicio.Text = "Guardar";
                btnModificarServicio.Text = "Cancelar";
                estadoControles(true);

            }
            else
            {
                tipoServiciosBindingSource.CancelEdit();

                estadoControles(false);
                btnNuevoServicio.Text = "Nuevo servicio";
                btnModificarServicio.Text = "Modificar datos";
            }
            lblPosicionServicio.Text = $"{tipoServiciosBindingSource.Position + 1} de {tipoServiciosBindingSource.Count}";
        }

        private void btnEliminarServicio_Click(object sender, EventArgs e)
        {
            tipoServiciosBindingSource.RemoveCurrent();
            this.tipoServiciosTableAdapter.Update(bd_veterinaria_huellitasDataSet);
            lblPosicionServicio.Text = $"{tipoServiciosBindingSource.Position + 1} de {tipoServiciosBindingSource.Count}";
        }
    }
}
