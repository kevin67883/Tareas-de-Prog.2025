using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//Esta es la libreria que me permite usar comandos para trabajar con Bases de Datos
using System.Data.SqlClient;//Esta libreria me permite trabajar con SQL Server

namespace ACADEMICA23
{
    internal class Conexion
    {
        //Definir los miembros de la clase, atributos y metodos.
        SqlConnection objConexion = new SqlConnection();//Conectarme a la BD.
        SqlCommand objComando = new SqlCommand();//Ejecutar  SQL en la BD. Lectura, Actualizacion, Eliminacion, Insercion.
        SqlDataAdapter objAdaptador = new SqlDataAdapter();//un puente entre la BD y la aplicacion.
        DataSet objDs = new DataSet();//Es una representacion de la arquitectura de la BD en memoria.
        private string accion;

        public Conexion()
        {  //Constructor inicializador de los atributos.
            String cadenaConexion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\dbAcademico.mdf;Integrated Security=True";
            objConexion.ConnectionString = cadenaConexion;
            objConexion.Open(); //Abrir la conexion a la BD.
        }

        public DataSet obtenerDatos()
        {
            objDs.Clear();//Limpiar el DataSet
            objComando.Connection = objConexion;//Establecer la conexion para ejecutar los comandos.

            objAdaptador.SelectCommand = objComando;//Establecer el comando a ejecutar.

            objComando.CommandText = "SELECT * FROM alumnos";
            objAdaptador.Fill(objDs, "alumnnos");//Tomando los datos de la BD y llenando el DataSet.

            return objDs;

        }
        public string administrarDatosAlumnos(String[] datos, String accion)
        {
            string sql = "";
            if (datos[0] == "nuevo") {
                sql = "INSERT INTO alumnos(codigo, nombre, direccion, telefono) VALUES (@codifo, @nombre,@direccion, @telefono)";
            }else if (accion == "modificar"){
                sql = "UPDATE alumnos SET codigo=@codifo, nombre= @nombres, direccion=@direccion, telefono=@telefono) WHERE idAlumno=@idAlumno";
            }else if (accion == "eliminar"){
                sql = "DELETE FROM alumnos WHERE idAlumno=@idAlumno";
            }
            return ejecutarSQL(sql, datos);
        }

        private string ejecutarSQL(string sql, string[] datos) {
            try  {
                objComando.Connection = objConexion;
                objComando.CommandText = sql;

                objComando.Parameters.Clear();
                objComando.Parameters.AddWithValue("@idAlumno", (datos[0]));
                objComando.Parameters.AddWithValue("@codigo", datos[1]);
                objComando.Parameters.AddWithValue("@nombre", datos[2]);
                objComando.Parameters.AddWithValue("@direccion", datos[3]);
                objComando.Parameters.AddWithValue("@telefono", datos[4]);

                return objComando.ExecuteNonQuery().ToString();
            }catch (Exception ex) {
                return ex.Message;
            }
        }
    }
}

