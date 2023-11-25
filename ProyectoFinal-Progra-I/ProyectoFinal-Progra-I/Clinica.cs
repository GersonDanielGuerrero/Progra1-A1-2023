using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_Progra_I
{
    class Clinica
    {
        public bool ValidarDatos(GroupBox groupBox)
        {
            bool hayCamposVacios = false;
            foreach (Control k in groupBox.Controls)
            {
                k.BackColor = System.Drawing.Color.White;
                if (!(k is Label || k is PictureBox) && string.IsNullOrWhiteSpace(k.Text))
                {
                   
                    hayCamposVacios = true;
                    k.BackColor = System.Drawing.Color.Red;
                }
                
               
            }
            return hayCamposVacios;
        }
        public void quitarEspaciosEnBlanco(GroupBox groupBox)
        {
            foreach (Control k in groupBox.Controls)
            {
                k.Text.Trim();
            }
        }
        public void estadoControles(bool estado, GroupBox groupBox)
        {
            foreach (Control k in groupBox.Controls)
            {
                if (!(k is Label))
                {
                    k.Enabled = estado;
                }
            }
        }
    }
}
