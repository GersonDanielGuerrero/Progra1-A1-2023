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
        public int idPaciente;
        public Fallecimiento(int IdPaciente)
        {
            InitializeComponent();
            idPaciente = IdPaciente;
            pacientesBindingSource.Filter = $"idPaciente = {idPaciente}";
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
            
            DataRow nuevoFallecimiento = bd_veterinaria_huellitasDataSet.fallecimientos.NewRow();
            nuevoFallecimiento["idPaciente"] = idPaciente;
            nuevoFallecimiento["fecha"] = dtpFechaFallecimiento.Value;
            nuevoFallecimiento["causa"] = txtCausaFallecimiento.Text;

            bd_veterinaria_huellitasDataSet.fallecimientos.Rows.Add(nuevoFallecimiento);
            fallecimientosTableAdapter.Update(bd_veterinaria_huellitasDataSet.fallecimientos);

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
