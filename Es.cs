using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALUMNOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Conexion objConexion = new Conexion();
        DataSet objDs = new DataSet();
        DataTable objDt = new DataTable();

        public int posicion = 0;
        public string accion = "nuevo";

        private void actualizarDs() {
            objDs.Clear();//Limpiar el DataSet
            objDs = objConexion.obtenerDatos();
            objDt = objDs.Tables["alumnos"];
            objDt.PrimaryKey = new DataColumn[] { objDt.Columns["idAlumno"] };

        }
        private void mostrarDatos() {
        if(objDt.Rows.Count > 0){
                lblIdAlumno.Text = objDt.Rows[posicion]["idAlumno"].ToString();
                txtCodigoAlumno.Text = objDt.Rows[posicion]["codigo"].ToString();
                txtNombreAlumno.Text = objDt.Rows[posicion]["nombre"].ToString();
                txtDireccionAlumno.Text = objDt.Rows[posicion]["direccion"].ToString();
                txtTelefonoAlumno.Text = objDt.Rows[posicion]["telefono"].ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            actualizarDs();
        }
    }
}
