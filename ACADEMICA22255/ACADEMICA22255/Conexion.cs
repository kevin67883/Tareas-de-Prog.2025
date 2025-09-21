using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//ESta es la libreria que me permite usar comandos para trabajar con Bases de Datos
using System.Data.SqlClient;// Esta Libreria me permite trabajar con SQL Server


namespace ACADEMICA22255
{
    internal class Conexio {
        //Definir los miembros de la clase, atributos y metodos.
        SqlConnection objConexion = new SqlConnection();//Conectarme a la BD.
        SqlCommand objComando = new SqlCommand();//Ejecutar SQL en la BD.
        SqlDataAdapter objAdaptador = new SqlDataAdapter();//un puente entre la BD y la aplicacion.
        DataSet objDs = new DataSet();//Es una representacion de la arquitectura de la BD en memoria.

        public Conexio() { //Constructor  inicializador de los atributos
            String cadenaConexion = "";
            objConexion.ConnectionString = cadenaConexion;
            objConexion.Open();//Abrir la conexion a la BD.
        }
        public DataSet obtenerDatos()
        {
            objDs.Clear();//Limpiar el DataSet
            objComando.Connection = objConexion;//Establecer la conexion para ejecutar los comandos.

            objAdaptador.SelectCommand = objComando;//Establecer el comando de seleccion
            objComando.CommandText = "SELECT * FROM  alumonos";
            objAdaptador.Fill(objDs, "alumnos");//Tomando los datos de la BD y llenando el DataSet

            return objDs;
        }
    }
}
