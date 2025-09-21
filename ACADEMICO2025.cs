using ACADEMICA22255;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACADEMICA25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Conexiones objConexiones = new Conexiones();  
        DataSet objDs = new DataSet();
        DataTable objDt = new DataTable();

        public int posicion = 0;
        public string accion = "nuevo";

        public DataColumn[] Primarykey { get; private set; }

        private void actualizarDs()
        {
            objDs.Clear();//Limpiar el DataSet
            objDs = objConexiones.obtenerDatos();
            objDt = objDs.Tables["alumnos"];

            mostrarDatos();
        }

        private void mostrarDatos()
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)

        {

        }
    }
}
