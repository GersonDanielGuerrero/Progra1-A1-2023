using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaProgramacion
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            materias objMaterias = new materias();
            objMaterias.MdiParent = this;
            objMaterias.Show();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alumnos objAlumnos = new alumnos();
            objAlumnos.MdiParent = this;
            objAlumnos.Show();
        }
    }
}
