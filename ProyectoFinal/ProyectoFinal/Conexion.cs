using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace ProyectoFinal
{
    class Conexion
    {
        SqlConnection miConexion = new SqlConnection(); 
        SqlCommand miComando = new SqlCommand(); 
        SqlDataAdapter miAdaptador = new SqlDataAdapter(); 
        DataSet miDs = new DataSet();

        public Conexion()
        {
            String cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_veterinaria_huellitas.mdf;Integrated Security=True";
            miConexion.ConnectionString = cadenaConexion;
            miConexion.Open();
            obtenerDatos();
        }
        public DataSet obtenerDatos()
        {
            miDs.Clear();
            miComando.Connection = miConexion;

            miComando.CommandText = "select * from clientes";
            miAdaptador.SelectCommand = miComando;
            miAdaptador.Fill(miDs, "clientes");

            miComando.CommandText = "select * from pacientes";
            miAdaptador.SelectCommand = miComando;
            miAdaptador.Fill(miDs, "pacientes");

            miComando.CommandText = "select * from productos";
            miAdaptador.SelectCommand = miComando;
            miAdaptador.Fill(miDs, "productos");

            return miDs;
        }
        public String mantenimientoClientes(String[] clientes)
        {
            String sql = "";
            if (clientes[0] == "nuevo")
            {
                sql = "INSERT INTO clientes (nombre,fechaNacimiento,telefono,direccion,correo) VALUES('" + clientes[1] + "', '" + clientes[2] + "', '" +
                    clientes[3] + "', '" + clientes[4] + "', '" + clientes[5] +  "')";
            }
            else if (clientes[0] == "modificar")
            {
                sql = "UPDATE clientes SET nombre='" + clientes[1] + "', fechaNacimiento='" + clientes[2] + "', telefono='" + clientes[3] + "', direccion='" + clientes[4]
                   + "', correo='" + clientes[5] +  "' WHERE idCliente='" + clientes[6] + "'";
            }
            else if (clientes[0] == "eliminar")
            {
                sql = "DELETE FROM clientes WHERE idCliente='" + clientes[6] + "'";
            }
            return ejecutarSql(sql);
        }
        public String mantenimientoPacientes(String[] pacientes)
        {
            String sql = "";
            if (pacientes[0] == "nuevo")
            {
                sql = "INSERT INTO pacientes (nombre,fechaNacimiento,estatura,peso,color,especie,raza,descripcionAdicional) VALUES('" + pacientes[1] + "', '" + pacientes[2] + "', '" +
                    pacientes[3] + "', '" + pacientes[4] + "', '" + pacientes[5] + "', '" + pacientes[6] + "', '" + pacientes[7] + "', '" + pacientes[8] + "')";
            }
            else if (pacientes[0] == "modificar")
            {
                sql = "UPDATE pacientes SET nombre='" + pacientes[1] + "', fechaNacimiento='" + pacientes[2] + "', estatura='" + pacientes[3] + "', peso='" + pacientes[4]
                   + "', color='" + pacientes[5] + "', especie='" + pacientes[6] + "', raza='" + pacientes[7] + "', descripcionAdicional='" + pacientes[8] + "' WHERE idPaciente='" + pacientes[9] + "'";
            }
            else if (pacientes[0] == "eliminar")
            {
                sql = "DELETE FROM pacientes WHERE idPaciente='" + pacientes[9] + "'";
            }
            return ejecutarSql(sql);
        }
        public String mantenimientoProductos(String[] productos)
        {
            String sql = "";
            if (productos[0] == "nuevo")
            {
                sql = "INSERT INTO productos (nombre,marca,principiosActivos,descripcion,precio) VALUES('" + productos[1] + "', '" + productos[2] + "', '" +
                    productos[3] + "', '" + productos[4] + "', '" + productos[5] + "')";
            }
            else if (productos[0] == "modificar")
            {
                sql = "UPDATE productos SET nombre='" + productos[1] + "', marca='" + productos[2] + "', principiosActivos='" + productos[3] + "', descripcion='" + productos[4]
                   + "', precio='" + productos[5] + "' WHERE idProducto='" + productos[6] + "'";
            }
            else if (productos[0] == "eliminar")
            {
                sql = "DELETE FROM clientes WHERE idProducto='" + productos[6] + "'";
            }
            return ejecutarSql(sql);
        }
        private string ejecutarSql(String sql)
        {
            try
            {
                miComando.CommandText = sql;
                miComando.Connection = miConexion;
                return miComando.ExecuteNonQuery().ToString();
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
