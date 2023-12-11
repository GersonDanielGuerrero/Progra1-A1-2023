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
    public partial class Principal : Form
    {
        Pacientes objPacientes = new Pacientes();
        Clientes objClientes = new Clientes();
        Productos objProductos = new Productos();
        Usuarios objUsuarios = new Usuarios();
        Servicios objServicios = new Servicios();
        Tratamientos objTratamientos = new Tratamientos();

        public Principal()
        {
            InitializeComponent();
        
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objClientes.MdiParent = this;
            objClientes.Show();

            objServicios.Hide();
            objPacientes.Hide();
            objUsuarios.Hide();
            objProductos.Hide();
            objTratamientos.Hide();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objProductos.MdiParent = this;
            objProductos.Show();

            objServicios.Hide();
            objPacientes.Hide();
            objClientes.Hide();
            objUsuarios.Hide();
            objTratamientos.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objUsuarios.MdiParent = this;
            objUsuarios.Show();

            objPacientes.Hide();
            objClientes.Hide();
            objProductos.Hide();
            objServicios.Hide();
            objTratamientos.Hide();
        }

        private void ServiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objServicios.MdiParent = this;
            objServicios.Show();

            objPacientes.Hide();
            objClientes.Hide();
            objProductos.Hide();
            objUsuarios.Hide();
            objTratamientos.Hide();

        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void datosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objPacientes.MdiParent = this;
            objPacientes.Show();

            objServicios.Hide();
            objClientes.Hide();
            objUsuarios.Hide();
            objProductos.Hide();
            objTratamientos.Hide();
        }

        private void tratamientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objTratamientos.MdiParent = this;
            objTratamientos.Show();

            objServicios.Hide();
            objPacientes.Hide();
            objUsuarios.Hide();
            objProductos.Hide();
            objClientes.Hide();
        }
    }
}
