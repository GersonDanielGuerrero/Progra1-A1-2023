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
    public partial class Usuarios : Form
    {
        Clinica cl = new Clinica();
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bd_veterinaria_huellitasDataSet.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.bd_veterinaria_huellitasDataSet.usuarios);
            lblPosicionUsuario.Text = $"{usuariosBindingSource.Position + 1} de {usuariosBindingSource.Count}";
        }
        private void estadoControles(bool estado)
        {
            cl.estadoControles(estado, grbDatosUsuario);
            cl.estadoControles(!estado, grbNavegacionUsuario);
            cboOpcionBuscarUsuario.Enabled = !estado;
            cboOpcionBuscarUsuario.Enabled = !estado;
        }
        private void btnPrimeroUsuario_Click(object sender, EventArgs e)
        {
            usuariosBindingSource.MoveFirst();
            lblPosicionUsuario.Text = $"{usuariosBindingSource.Position + 1} de {usuariosBindingSource.Count}";
        }

        private void btnAnteriorUsuario_Click(object sender, EventArgs e)
        {
            usuariosBindingSource.MovePrevious();
            lblPosicionUsuario.Text = $"{usuariosBindingSource.Position + 1} de {usuariosBindingSource.Count}";
        }

        private void btnSiguienteUsuario_Click(object sender, EventArgs e)
        {
            usuariosBindingSource.MoveNext();
        }

        private void btnUltimoUsuario_Click(object sender, EventArgs e)
        {
            usuariosBindingSource.MoveLast();
            lblPosicionUsuario.Text = $"{usuariosBindingSource.Position + 1} de {usuariosBindingSource.Count}";
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            if (btnNuevoUsuario.Text == "Nuevo usuario")
            {
                btnNuevoUsuario.Text = "Guardar";
                btnModificarUsuario.Text = "Cancelar";
                estadoControles(true);

                usuariosBindingSource.AddNew();
            }
            else
            {
                if (cl.ValidarDatos(grbDatosUsuario))
                    MessageBox.Show("Ningun campo debe estar vacío");
                else
                {
                    usuariosBindingSource.EndEdit();
                    this.usuariosTableAdapter.Update(bd_veterinaria_huellitasDataSet);
                    estadoControles(false);
                    btnNuevoUsuario.Text = "Nuevo usuario";
                    btnModificarUsuario.Text = "Modificar datos";
                }
            }
            lblPosicionUsuario.Text = $"{usuariosBindingSource.Position + 1} de {usuariosBindingSource.Count}";
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            if (btnModificarUsuario.Text == "Modificar datos")
            {
                btnNuevoUsuario.Text = "Guardar";
                btnModificarUsuario.Text = "Cancelar";
                 estadoControles(true);

            }
            else
            {
                usuariosBindingSource.CancelEdit();

                estadoControles(false);
                btnNuevoUsuario.Text = "Nuevo usuario";
                btnModificarUsuario.Text = "Modificar datos";
            }
            lblPosicionUsuario.Text = $"{usuariosBindingSource.Position + 1} de {usuariosBindingSource.Count}";
        }
    }
}
