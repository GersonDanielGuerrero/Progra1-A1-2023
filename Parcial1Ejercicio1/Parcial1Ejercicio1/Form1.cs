using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1Ejercicio1
{
    public partial class Form1 : Form
    {
        Impuestos objImpuestos = new Impuestos();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCalcularImpuesto_Click(object sender, EventArgs e)
        {
            lblRespuestaImpuesto.Text ="El impuesto a pagar es: "+ Math.Round(objImpuestos.CalcularImpuesto(double.Parse(txtMontoImpuesto.Text)), 2);
        }
    }
}
