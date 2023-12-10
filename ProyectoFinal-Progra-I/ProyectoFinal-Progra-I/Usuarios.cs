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
            estadoControles(false);
            txtConfirmacionDeContraseñaUsuario.Text = txtContraseñaUsuario.Text;
        }
        private void estadoControles(bool estado)
        {
            cl.estadoControles(estado, grbDatosUsuario);
            cl.estadoControles(!estado, grbNavegacionUsuario);
            cboOpcionBuscarUsuario.Enabled = !estado;
            cboOpcionBuscarUsuario.Enabled = !estado;
        }
        private void actualizarDatosUsuarios()
        {
            lblPosicionUsuario.Text = $"{usuariosBindingSource.Position + 1} de {usuariosBindingSource.Count}";
            txtConfirmacionDeContraseñaUsuario.Text = txtContraseñaUsuario.Text;

            //Si no hay una imagen guardada en la db, asigna una por defecto
            if (pbFotoUsuario.Image == null)
            {
                pbFotoUsuario.Image = Principal.imageList1.Images["Usuario.jpeg"];
            }
        }
        private void btnPrimeroUsuario_Click(object sender, EventArgs e)
        {
            usuariosBindingSource.MoveFirst();
            actualizarDatosUsuarios();
        }

        private void btnAnteriorUsuario_Click(object sender, EventArgs e)
        {
            usuariosBindingSource.MovePrevious();
            actualizarDatosUsuarios();
        }

        private void btnSiguienteUsuario_Click(object sender, EventArgs e)
        {
            usuariosBindingSource.MoveNext();
            actualizarDatosUsuarios();
        }

        private void btnUltimoUsuario_Click(object sender, EventArgs e)
        {
            usuariosBindingSource.MoveLast();
            actualizarDatosUsuarios();
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
                if (cl.ValidarDatos(grbDatosUsuario, erpUsuarios))
                    MessageBox.Show("Ningun campo debe estar vacío");
                else if (txtConfirmacionDeContraseñaUsuario.Text != txtContraseñaUsuario.Text)
                    MessageBox.Show("Las contraseñas no coinciden");
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

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            usuariosBindingSource.RemoveCurrent();
            this.usuariosTableAdapter.Update(bd_veterinaria_huellitasDataSet);
            lblPosicionUsuario.Text = $"{usuariosBindingSource.Position + 1} de {usuariosBindingSource.Count}";
        }

        private void btnAgregarFotoUsuario_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbFotoUsuario.Image = new Bitmap(ofd.FileName);
                }
            }
        }
    }
}
