using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//Esta es la libreria que me permite usar comandos para trabajar con Bases de Datos
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;//Esta Libreria me permite trabajar con SQL Server

namespace ALUMNOS
{
    internal class Conexion {
        //Defnir los miembros de la clase, atributos y metodos.
        SqlConnection objConexion = new SqlConnection();//Conectarme a la BD.
        SqlCommand objComando = new SqlCommand();//Ejecutar SQL en la BD. Lectura, Actualizacion, Eliminacion, Insercion.
        SqlDataAdapter objAdaptador = new SqlDataAdapter();//Un puente entre la BD y la aplicacion.
        DataSet objDs = new DataSet();//Es una representacion de la arquitectura de la BD en memoria.

        public Conexion() {  //Constructor inicializador de los atributos.
            String cadenaConexion = "";
            objConexion.ConnectionString = cadenaConexion;
            objConexion.Open(); //Abrir la conexion a la BD.
        }

            public DataSet obtenerDatos(){
            objDs.Clear();//Limpiar el DataSet.
            objComando.Connection = objConexion;//Establecer la conexion para ejecutar el comando.

            objAdaptador.SelectCommand = objComando;//Establecer el comando de seleccion
            objComando.CommandText = "SELECT * FROM alumnos";
            objAdaptador.Fill(objDs, "alumos");//Tomando los datos de la BD y llenando el DataSet

            return objDs;
        }

    }
}
