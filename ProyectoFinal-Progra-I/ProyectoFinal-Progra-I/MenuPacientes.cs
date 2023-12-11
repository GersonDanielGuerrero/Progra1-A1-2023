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
    public partial class MenuPacientes : Form
    {
        Pacientes objPacientes = new Pacientes();
        Tratamientos objTratamientos = new Tratamientos();
        public MenuPacientes()
        {
            InitializeComponent();
        }

        private void listaDePacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objPacientes.MdiParent = this;
            objPacientes.Show();

            objTratamientos.Hide();
            
        }

        private void tratamientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objTratamientos.MdiParent = this;
            objTratamientos.Show();
            objPacientes.Hide();
        }
    }
}
