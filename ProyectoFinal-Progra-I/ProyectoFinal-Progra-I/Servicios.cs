﻿using System;
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
    public partial class Servicios : Form
    {
        public Servicios()
        {
            InitializeComponent();
        }

        private void Servicios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bd_veterinaria_huellitasDataSet.marcas' Puede moverla o quitarla según sea necesario.
            this.marcasTableAdapter.Fill(this.bd_veterinaria_huellitasDataSet.marcas);
            // TODO: esta línea de código carga datos en la tabla 'bd_veterinaria_huellitasDataSet.productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.bd_veterinaria_huellitasDataSet.productos);

        }
    }
}
