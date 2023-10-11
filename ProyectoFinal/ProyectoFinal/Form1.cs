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
    public partial class Form1 : Form
    {
        Clientes clientes = new Clientes();
        Pacientes pacientes = new Pacientes();
        Productos productos = new Productos();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnVerClientes_Click(object sender, EventArgs e)
        {
            clientes.Show();
            pacientes.Hide();
            productos.Hide();
        }

        private void btnVerPacientes_Click(object sender, EventArgs e)
        {
            pacientes.Show();
            clientes.Hide();
            productos.Hide();
        }

        private void btnVerProductos_Click(object sender, EventArgs e)
        {
            productos.Show();
            clientes.Hide();
            pacientes.Hide();
        }
    }
}
