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
        /*Conexion objConexion = new Conexion();
        DataSet miDs = new DataSet();
        */
        DataRowView drv;
        DataTable miTabla = new DataTable();
        

        public LogIn()
        {
            InitializeComponent();
            miTabla = bd_veterinaria_huellitasDataSet.Tables["usuarios"];
            /*
            miDs.Clear();
            miDs = objConexion.obtenerDatos();
            
            miTabla.PrimaryKey = new DataColumn[] { miTabla.Columns["idUsuario"] };
            */
        }

        private void btnSalirLogIn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIngresarLogIn_Click(object sender, EventArgs e)
        {
            
            bool permitirIngreso = false;
            while (usuariosBindingSource.Position < usuariosBindingSource.Count-1)
            {
                
                drv = (DataRowView)usuariosBindingSource.Current;
                string usuario = drv["usuario"].ToString();
                string clave = drv["clave"].ToString();

                if (txtUsuarioLogIn.Text.Trim() == usuario.Trim() && txtClaveLogIn.Text.Trim()==clave.Trim()) // && txtClaveLogIn.Text ==miTabla.Rows[i].ItemArray[3].ToString())
                {
                    permitirIngreso = true;

                }
                
                usuariosBindingSource.MoveNext();
               
            }
            
            if (permitirIngreso) { 
                MessageBox.Show("Bienvenido, " + txtUsuarioLogIn.Text);
                Principal objPrincipal = new Principal();
                objPrincipal.Show();
                
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            this.usuariosTableAdapter.Fill(this.bd_veterinaria_huellitasDataSet.usuarios);
        }
    }
}
