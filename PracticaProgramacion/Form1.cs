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
    public partial class Form1 : Form
    {
        Conversores objConversor = new Conversores();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void lblAConversor_Click(object sender, EventArgs e)
        {

        }

        private void btnConvertirConversor_Click(object sender, EventArgs e)
        {
            int de = 0, a = 0;
            double cantidad = 0, respuesta = 0;
            de = cboDeConversor.SelectedIndex;
            a = cboAConversor.SelectedIndex;
            cantidad = double.Parse(txtCantidadConversores.Text);

            respuesta = objConversor.Convertir(cboTipoConversor.SelectedIndex, de, a, cantidad);
            if(respuesta<1)
                lblRespuesta.Text = "Respuesta: "+respuesta;
            else
                lblRespuesta.Text = "Respuesta:" + Math.Round(respuesta,2);
       
        }


        private void cboTipoConversor_TextChanged(object sender, EventArgs e)
        {
            cboDeConversor.Items.Clear();
            cboDeConversor.Items.AddRange(objConversor.etiquetas[cboTipoConversor.SelectedIndex]);

            cboAConversor.Items.Clear();
            cboAConversor.Items.AddRange(objConversor.etiquetas[cboTipoConversor.SelectedIndex]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
