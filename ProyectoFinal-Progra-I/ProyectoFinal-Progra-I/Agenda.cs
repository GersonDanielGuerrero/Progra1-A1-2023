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
    public partial class Agenda : Form
    {
        public Agenda(int id, string tipoAgenda)
        {
            InitializeComponent();
        }

        private void Agenda_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bd_veterinaria_huellitasDataSet.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.bd_veterinaria_huellitasDataSet.usuarios);
            // TODO: esta línea de código carga datos en la tabla 'bd_veterinaria_huellitasDataSet.pacientes' Puede moverla o quitarla según sea necesario.
            this.pacientesTableAdapter.Fill(this.bd_veterinaria_huellitasDataSet.pacientes);

        }
    }
}
