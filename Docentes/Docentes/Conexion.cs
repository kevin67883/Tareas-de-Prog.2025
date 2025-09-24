using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//Esta es la libreria que me permite usar comandos para trabajar con Bases de Datos
using System.Data.SqlClient;//Esta libreria me permite trabajar con SQL Server

namespace ACADEMICA23
{
    internal class ConexionDocente
    {
        //Definir los miembros de la clase, atributos y metodos.
        SqlConnection objConexion = new SqlConnection();
        SqlCommand objComando = new SqlCommand();
        SqlDataAdapter objAdaptador = new SqlDataAdapter();
        DataSet objDs = new DataSet();

        public ConexionDocente()
        {
             //Constructor inicializador de los atributos.
                string cadenaConexion = "String cadenaConexion = @\"Data Source=(LocalDB)\\\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\\\dbAcademico.mdf;Integrated Security=True\"; ";

            objConexion.ConnectionString = cadenaConexion;

            objConexion.Open(); // Abrir la conexión a la BD
        }
        

        // Método para obtener datos de la tabla docentes
        public DataSet obtenerDatos()
        {
            objDs.Clear();//Limpiar el DataSet
            objComando.Connection = objConexion;//Establecer la conexion para ejecutar los comandos.

            objComando.CommandText = "SELECT * FROM docentes";
            objAdaptador.SelectCommand = objComando;//Establecer el comando a ejecutar.

            objAdaptador.Fill(objDs, "docentes");//Tomando los datos de la BD y llenando el DataSet.

            return objDs;
        }

        // Método para insertar, modificar o eliminar docentes
        public string administrarDatosDocentes(string[] datos, string accion)
        {
            string sql = "";

            if (accion == "nuevo")
            {
                sql = "INSERT INTO docentes(codigo, nombre, direccion, telefono, profesion) " +
                      "VALUES(@codigo, @nombre, @direccion, @telefono)";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE docentes SET codigo=@codigo, nombre=@nombre, direccion=@direccion, " +
                      "telefono=@telefono WHERE idDocente=@idDocente";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE FROM docentes WHERE idDocente=@idDocente";
            }

            return ejecutarSQL(sql, datos);
        }

        // Ejecutar SQL parametrizado
        private string ejecutarSQL(string sql, string[] datos)
        {
            try
            {
                objComando.Connection = objConexion;
                objComando.CommandText = sql;
                objComando.Parameters.Clear();

                // Parámetros
                objComando.Parameters.AddWithValue("@idDocente", datos[0]);
                objComando.Parameters.AddWithValue("@codigo", datos[1]);
                objComando.Parameters.AddWithValue("@nombre", datos[2]);
                objComando.Parameters.AddWithValue("@direccion", datos[3]);
                objComando.Parameters.AddWithValue("@telefono", datos[4]);

                return objComando.ExecuteNonQuery().ToString();
            }
            catch (Exception ex) 
            {
                return ex.Message;
            }
        }
    }
}