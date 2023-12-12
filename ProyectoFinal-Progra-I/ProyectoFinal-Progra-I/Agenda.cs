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
            // TODO: esta línea de código carga datos en la tabla 'bd_veterinaria_huellitasDataSet.DatosTratamientos' Puede moverla o quitarla según sea necesario.
            this.datosTratamientosTableAdapter.Fill(this.bd_veterinaria_huellitasDataSet.DatosTratamientos);
            // TODO: esta línea de código carga datos en la tabla 'bd_veterinaria_huellitasDataSet.DatosExamen' Puede moverla o quitarla según sea necesario.
            this.datosExamenTableAdapter.Fill(this.bd_veterinaria_huellitasDataSet.DatosExamen);
            // TODO: esta línea de código carga datos en la tabla 'bd_veterinaria_huellitasDataSet.tratamientos' Puede moverla o quitarla según sea necesario.
            this.tratamientosTableAdapter.Fill(this.bd_veterinaria_huellitasDataSet.tratamientos);
            // TODO: esta línea de código carga datos en la tabla 'bd_veterinaria_huellitasDataSet.examenes' Puede moverla o quitarla según sea necesario.
            this.examenesTableAdapter.Fill(this.bd_veterinaria_huellitasDataSet.examenes);
            // TODO: esta línea de código carga datos en la tabla 'bd_veterinaria_huellitasDataSet.consultas' Puede moverla o quitarla según sea necesario.
            this.consultasTableAdapter.Fill(this.bd_veterinaria_huellitasDataSet.consultas);
            // TODO: esta línea de código carga datos en la tabla 'bd_veterinaria_huellitasDataSet.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.bd_veterinaria_huellitasDataSet.usuarios);
            // TODO: esta línea de código carga datos en la tabla 'bd_veterinaria_huellitasDataSet.pacientes' Puede moverla o quitarla según sea necesario.
            this.pacientesTableAdapter.Fill(this.bd_veterinaria_huellitasDataSet.pacientes);

        }
    }
}
