using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//Esta es la libreria que me permite usar comandos para trabajar con base de datos
using System.Data.SqlClient;//Esta libreria me permite trabajar con SQL Server

namespace ACADEMICA
{

    internal class CONEXION
    {
        //Definir los miembros de la clase, atributos y metodos.
        SqlConnection objConexion = new SqlConnection();//Conectarse a la BD.
        SqlCommand objComando = new SqlCommand();//Ejecutar SQL en la BD: Lectura, Actualizacion, Elliminacion, Insercion.
        SqlDataAdapter objAdaptador = new SqlDataAdapter();//un puente entre la BD y lla aplicacion.
        DataSet objDs = new DataSet();//Es una representacion de la arquitectura de la BD en memoria.

        public CONEXION()
        { //Constructor. inicializador de los atributos
            String cadenaConexion = @"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\db_academica.mdf;Integrated Security=True";
            objConexion.ConnectionString = cadenaConexion;
            objConexion.Open(); //Abrir la conexion a la BD
        }
        public DataSet obtenerDatos()
        {
            objDs.Clear(); //Limpiar el DataSet
            objComando.Connection = objConexion; //Establecer la Conexion para ejecutar los comandos.

            objAdaptador.SelectCommand = objComando; //Establecer el comando de seleccion

            objComando.CommandText = "SELECT * FROM alumnos";
            objAdaptador.Fill(objDs, "alumnos");//Tomando los datos de la BD y llenando el DataSet

            objComando.CommandText = "SELECT * FROM materias";
            objAdaptador.Fill(objDs, "materias");//Tomando los datos de la BD y llenando el DataSet

            return objDs;
        }
        public string administrarDatosAlumnos(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO alumnos(Codigo ,Nombre, Direccion, Telefono) VALUES ('" + datos[1] + "', '" + datos[2] + "', '" + datos[3] + "', '" + datos[4] + "')";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE alumnos SET Codigo ='" + datos[1] + "', Nombre='" + datos[2] + "', Direccion='" + datos[3] + "', Telefono='" + datos[4] + "' WHERE idAlumno='" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE FROM alumnos WHERE idAlumno='" + datos[0] + "'";
            }
            return ejecutarSQL(sql);
        }
        
        public String ejecutarSQL(String sql)
        {
            try
            {
                objComando.Connection = objConexion;
                objComando.CommandText = sql;
                return objComando.ExecuteNonQuery().ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        internal string administrarDatosMaterias(string[] materias, string accion)
        {
            throw new NotImplementedException();
        }
    }
}