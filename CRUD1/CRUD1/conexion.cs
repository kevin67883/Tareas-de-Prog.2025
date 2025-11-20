using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace CRUD1
{
    internal class conexion
    {
        SqlConnection objconexion = new SqlConnection();
        SqlCommand objcomando= new SqlCommand();
        SqlDataAdapter objadaptado = new SqlDataAdapter();
        DataSet objDS = new DataSet();

        public conexion()
        {
            String cadenaconexion = "";
            objconexion.ConnectionString = cadenaconexion;
            objconexion.Open();

        }

        public DataSet obtenerdatos()
        {
            objDS = new DataSet();
            objcomando.Connection = objconexion;

            objadaptado.SelectCommand = objcomando;

            objcomando.CommandText = "SELECT * FROM estudiantes";
            objadaptado.Fill(objDS, "estudiantes");

            objcomando.CommandText = "SELECT * FROM materias";
            objadaptado.Fill(objDS, "materias");

            objcomando.CommandText = "SELECT * FROM Docentes";
            objadaptado.Fill(objDS, "docentes");

            return objDS;
        }

            public string administrardatos(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO estudiantes (codigo, nombre, direccion, telefono) VALUES ('" + datos
            }
        }




        }
    }

