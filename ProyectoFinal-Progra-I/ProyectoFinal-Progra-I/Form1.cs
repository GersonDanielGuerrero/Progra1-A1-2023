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
        
        
        
       
        

        public Principal()
        {
            InitializeComponent();
        
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarFormularios();
            Clientes objClientes = new Clientes();
            objClientes.MdiParent = this;
            objClientes.Show();
            
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarFormularios();
            Productos objProductos = new Productos();
            objProductos.MdiParent = this;
            objProductos.Show();
           
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            cerrarFormularios();
            Usuarios objUsuarios = new Usuarios();
            objUsuarios.MdiParent = this;
            objUsuarios.Show();

        }

        private void ServiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarFormularios();
            Servicios objServicios = new Servicios();
            objServicios.MdiParent = this;
           objServicios.Show();
          
        }
        private void cerrarFormularios()
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void datosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarFormularios();
        Pacientes objPacientes = new Pacientes();
            objPacientes.MdiParent = this;
            objPacientes.Show();

        }

        private void tratamientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarFormularios();
            Tratamientos objTratamientos = new Tratamientos();
            objTratamientos.MdiParent = this;
            objTratamientos.Show();

        }
    }
}
