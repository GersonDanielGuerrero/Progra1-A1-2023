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
                if (!(k is Label) && string.IsNullOrWhiteSpace(k.Text))
                {
                    hayCamposVacios = true;
                }
            }
            return hayCamposVacios;
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
