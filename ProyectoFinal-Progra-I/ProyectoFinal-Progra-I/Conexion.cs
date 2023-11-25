using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoFinal_Progra_I
{
    class Conexion
    {

        private static SqlConnection miConexion = new SqlConnection();
        private static String cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\bd_veterinaria_huellitas.mdf;Integrated Security=True";
        public static SqlConnection ObtenerConexion()
        {
            if (miConexion==null)
            {
                miConexion = new SqlConnection(cadenaConexion);
                miConexion.Open();
            }
            else if (miConexion.State==ConnectionState.Closed)
            {
                miConexion.Open();
            }
            return miConexion;
        }

        public static void CerrarConexion()
        {
            if (miConexion!=null && miConexion.State==ConnectionState.Open)
            {
                miConexion.Close();
            }
        }
        SqlCommand miComando = new SqlCommand();
        SqlDataAdapter miAdaptador = new SqlDataAdapter();
        DataSet miDs = new DataSet();

        public Conexion()
        {


            /*
            miConexion.ConnectionString = cadenaConexion;
            miConexion.Open();
            obtenerDatos();
            parametrizacion();
            */
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

            miComando.CommandText = "select * from usuarios";
            miAdaptador.SelectCommand = miComando;
            miAdaptador.Fill(miDs, "usuarios");

            return miDs;
        }
        private void parametrizacion() 
        { 

        }
        public String mantenimientoClientes(string accion, int idCliente, string nombre,string direccion,string correo,string telefono,DateTime fechaNacimiento,DateTime fechaRegistro,byte[] foto)
        {
            miComando.Parameters.Clear();
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO clientes (nombre,direccion,correo,telefono,fechaNacimiento,fechaRegistro,foto) VALUES(@nombre,@direccion,@correo,@telefono,@fechaNacimiento,@fechaRegistro,@foto)";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE clientes SET nombre=@nombre, direccion=@direccion,correo=@correo,telefono=@telefono,fechaNacimiento=@fechaNacimiento,fechaRegistro=@fechaRegistro,foto=@foto WHERE idCliente=@idCliente";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE FROM clientes WHERE idCliente=@idCliente";
            }


            miComando.Parameters.Add("@idCliente", SqlDbType.Int).Value = idCliente;
            miComando.Parameters.Add("@nombre", SqlDbType.Char).Value = nombre;
            miComando.Parameters.Add("@direccion", SqlDbType.Char).Value = direccion;
            miComando.Parameters.Add("@correo", SqlDbType.Char).Value = correo;
            miComando.Parameters.Add("@telefono", SqlDbType.Char).Value = telefono;
            miComando.Parameters.Add("@fechaNacimiento", SqlDbType.Date).Value = fechaNacimiento.Date;
            miComando.Parameters.Add("@fechaRegistro", SqlDbType.Date).Value = fechaRegistro.Date;
            miComando.Parameters.Add("@foto", SqlDbType.VarBinary).Value = foto;

            return ejecutarSql(sql);

        }
        public String mantenimientoPacientes(string accion, int idPaciente, string nombre, string especie, string raza, string color,double estatura,double peso, DateTime fechaNacimiento, DateTime fechaRegistro,string descripcion)
        {
            miComando.Parameters.Clear();
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO pacientes (nombre,especie,raza,color,estatura,peso,fechaNacimiento,fechaRegistro,descripcion) VALUES(@nombre,@especie,@raza,@color,@estatura,@peso,@fechaNacimiento,@fechaRegistro,@descripcion)";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE pacientes SET nombre=@nombre,especie=@especie,raza=@raza,color=@color,estatura=@estatura, peso=@peso,fechaNacimiento=@fechaNacimiento,fechaRegistro=@fechaRegistro,descripcion=@descripcion WHERE idPaciente=@idPaciente";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE FROM pacientes WHERE idPaciente=@idPaciente";
            }


            miComando.Parameters.Add("@idPaciente", SqlDbType.Int).Value = idPaciente;
            miComando.Parameters.Add("@nombre", SqlDbType.Char).Value = nombre;
            miComando.Parameters.Add("@especie", SqlDbType.Char).Value = especie;
            miComando.Parameters.Add("@raza", SqlDbType.Char).Value = raza;
            miComando.Parameters.Add("@color", SqlDbType.Char).Value = color;
            miComando.Parameters.Add("@estatura", SqlDbType.Float).Value = estatura;
            miComando.Parameters.Add("@peso", SqlDbType.Float).Value = peso;
            miComando.Parameters.Add("@fechaNacimiento", SqlDbType.Date).Value = fechaNacimiento.Date;
            miComando.Parameters.Add("@fechaRegistro", SqlDbType.Date).Value = fechaRegistro.Date;
            miComando.Parameters.Add("@descripcion", SqlDbType.Char).Value = descripcion;


            return ejecutarSql(sql);

        }
        public String mantenimientoProductos(string accion, int idProducto,string nombre, string marca, string principiosActivos,double precio,string descripcion)
        {
            miComando.Parameters.Clear();
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO productos (nombre,marca,principiosActivos,precio,descripcion) VALUES(@nombre,@marca,@principiosActivos,@precio,@descripcion)";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE productos SET nombre=@nombre, marca=@marca, principiosActivos=@principiosActivos,precio=@precio,descripcion=@descripcion WHERE idProducto=@idProducto";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE FROM productos WHERE idProducto=@idProducto";
            }


            miComando.Parameters.Add("@idProducto", SqlDbType.Int).Value = idProducto;
            miComando.Parameters.Add("@marca", SqlDbType.Char).Value = marca;
            miComando.Parameters.Add("@nombre", SqlDbType.Char).Value = nombre;
            miComando.Parameters.Add("@principiosActivos", SqlDbType.Char).Value = principiosActivos;
            miComando.Parameters.Add("@precio", SqlDbType.Float).Value = precio;
            miComando.Parameters.Add("@descripcion", SqlDbType.Char).Value = descripcion;



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
