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
    public partial class Tratamientos : Form
    {
        Clinica cl = new Clinica();
        public Tratamientos()
        {
            InitializeComponent();
            
        }

        private void Tratamientos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bd_veterinaria_huellitasDataSet.detalleTratamientos' Puede moverla o quitarla según sea necesario.
            this.detalleTratamientosTableAdapter.Fill(this.bd_veterinaria_huellitasDataSet.detalleTratamientos);
            // TODO: esta línea de código carga datos en la tabla 'bd_veterinaria_huellitasDataSet.productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.bd_veterinaria_huellitasDataSet.productos);
            // TODO: esta línea de código carga datos en la tabla 'bd_veterinaria_huellitasDataSet.pacientes' Puede moverla o quitarla según sea necesario.
            this.pacientesTableAdapter.Fill(this.bd_veterinaria_huellitasDataSet.pacientes);
            // TODO: esta línea de código carga datos en la tabla 'bd_veterinaria_huellitasDataSet.tratamientos' Puede moverla o quitarla según sea necesario.
            this.tratamientosTableAdapter.Fill(this.bd_veterinaria_huellitasDataSet.tratamientos);
            estadoControles(false);
            lblPosicionTratamiento.Text = $"{tratamientosBindingSource.Position + 1} de {tratamientosBindingSource.Count}";
        }
        
        private void estadoControles(bool estado)
        {
            cl.estadoControles(estado, grbDetallesTratamiento);
            cl.estadoControles(!estado, grbNavegacionTratamiento);
            cboOpcionBuscarTratamiento.Enabled = !estado;
            txtBuscarTratamiento.Enabled = !estado;
        }
        private void btnPrimeroTratamiento_Click(object sender, EventArgs e)
        {
            tratamientosBindingSource.MoveFirst();
            lblPosicionTratamiento.Text = $"{tratamientosBindingSource.Position + 1} de {tratamientosBindingSource.Count}";
        }

        private void btnAnteriorTratamiento_Click(object sender, EventArgs e)
        {
            tratamientosBindingSource.MovePrevious();
            lblPosicionTratamiento.Text = $"{tratamientosBindingSource.Position + 1} de {tratamientosBindingSource.Count}";
        }

        private void btnSiguienteTratamiento_Click(object sender, EventArgs e)
        {
            tratamientosBindingSource.MoveNext();
            lblPosicionTratamiento.Text = $"{tratamientosBindingSource.Position + 1} de {tratamientosBindingSource.Count}";
        }

        private void btnUltimoTratamiento_Click(object sender, EventArgs e)
        {
            tratamientosBindingSource.MoveLast();
            lblPosicionTratamiento.Text = $"{tratamientosBindingSource.Position + 1} de {tratamientosBindingSource.Count}";
        }

        private void btnNuevoTratamiento_Click(object sender, EventArgs e)
        {
            if (btnNuevoTratamiento.Text == "Nuevo tratamiento")
            {
                btnNuevoTratamiento.Text = "Guardar";
                btnModificarTratamiento.Text = "Cancelar";
                estadoControles(true);

                tratamientosBindingSource.AddNew();
                
            }
            else
            {
                
                if (cl.ValidarDatos(grbDetallesTratamiento,erpTratamientos))
                    MessageBox.Show("Ningun campo debe estar vacío");
                else
                {
                    tratamientosBindingSource.EndEdit();
                    this.tratamientosTableAdapter.Update(bd_veterinaria_huellitasDataSet);
                    this.detalleTratamientosTableAdapter.Fill(bd_veterinaria_huellitasDataSet.detalleTratamientos);
                    estadoControles(false);
                    btnNuevoTratamiento.Text = "Nuevo tratamiento";
                    btnModificarTratamiento.Text = "Modificar datos";
                }

            }
            lblPosicionTratamiento.Text = $"{tratamientosBindingSource.Position + 1} de {tratamientosBindingSource.Count}";
        }

        private void btnModificarTratamiento_Click(object sender, EventArgs e)
        {
            if (btnModificarTratamiento.Text == "Modificar datos")
            {
                btnNuevoTratamiento.Text = "Guardar";
                btnModificarTratamiento.Text = "Cancelar";
                estadoControles(true);

            }
            else
            {
                tratamientosBindingSource.CancelEdit();

                estadoControles(false);
                btnNuevoTratamiento.Text = "Nuevo tratamiento";
                btnModificarTratamiento.Text = "Modificar datos";
            }
            lblPosicionTratamiento.Text = $"{tratamientosBindingSource.Position + 1} de {tratamientosBindingSource.Count}";
        }

        private void btnEliminarTratamiento_Click(object sender, EventArgs e)
        {
            tratamientosBindingSource.RemoveCurrent();
            this.tratamientosTableAdapter.Update(bd_veterinaria_huellitasDataSet);
            lblPosicionTratamiento.Text = $"{tratamientosBindingSource.Position + 1} de {pacientesBindingSource.Count}";
        }
    }
}
