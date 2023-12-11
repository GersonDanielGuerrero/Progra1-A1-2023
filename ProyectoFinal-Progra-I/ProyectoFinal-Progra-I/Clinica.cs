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
        public bool ValidarDatos(GroupBox groupBox, ErrorProvider errorProvider)
        {
            bool hayCamposVacios = false;
            foreach (Control k in groupBox.Controls)
            {
                errorProvider.SetError(k, "");
                if (!(k is Label || k is PictureBox) && string.IsNullOrWhiteSpace(k.Text))
                {
                    errorProvider.SetError(k, "Ningun campo debe estar vacío");
                    hayCamposVacios = true;
                    
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
