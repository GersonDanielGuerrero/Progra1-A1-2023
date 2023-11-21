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
    public partial class Fallecimiento : Form
    {
        public Fallecimiento(int idPaciente)
        {
            InitializeComponent();
            
        }

        private void Fallecimiento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bd_veterinaria_huellitasDataSet.pacientes' Puede moverla o quitarla según sea necesario.
            this.pacientesTableAdapter.Fill(this.bd_veterinaria_huellitasDataSet.pacientes);
            // TODO: esta línea de código carga datos en la tabla 'bd_veterinaria_huellitasDataSet.fallecimientos' Puede moverla o quitarla según sea necesario.
            this.fallecimientosTableAdapter.Fill(this.bd_veterinaria_huellitasDataSet.fallecimientos);

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            
        }
    }
}
