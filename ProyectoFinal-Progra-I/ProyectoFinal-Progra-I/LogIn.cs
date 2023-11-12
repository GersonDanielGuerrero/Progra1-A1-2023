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
    public partial class LogIn : Form
    {
        Conexion objConexion = new Conexion();
        DataSet miDs = new DataSet();
        DataTable miTabla = new DataTable();

        public LogIn()
        {
            InitializeComponent();
            miDs.Clear();
            miDs = objConexion.obtenerDatos();
            miTabla = miDs.Tables["Usuarios"];
            miTabla.PrimaryKey = new DataColumn[] { miTabla.Columns["idUsuario"] };
        }

        private void btnSalirLogIn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIngresarLogIn_Click(object sender, EventArgs e)
        {
            bool permitirIngreso = false;
            for (int i = 0; i < miTabla.Rows.Count; i++)
            {
                if (txtUsuarioLogIn.Text == miTabla.Rows[i].ItemArray[2].ToString() && txtClaveLogIn.Text == miTabla.Rows[i].ItemArray[3].ToString())
                {
                    permitirIngreso = true;
                }
            }
            if (permitirIngreso) { 
                MessageBox.Show("Bienvenido, " + txtUsuarioLogIn.Text);
                Form1 objPrincipal = new Form1();
                objPrincipal.Show();
                
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
}
