using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboCl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
          Monedas
          Longitud
          Masa
          Volumen
          Almacenamiento
          Tiempo
          Area
        */

        string[][] etiquetas = new string[][]
        {
            new string[] { "Dolar", "Pesos Mexicanos", "Quetzal", "Lempiras", "Colon sv", "Cordobas", "Colon CR" }, // Monedas
            new string[] { "Metros", "Cm", "Pulgadas", "Pies", "Varas", "Yardas", "Km", "Millas" },                 // Longitud
            new string[] { "Libra", "Onza", "Gramo", "Kg", "Quintal", "Tonelada Corta" },                         // Masa
            new string[] { "Galon Us", "Litros", "Pinta Us", "ML" },                                               // Volumen
            new string[] { "GB", "Bit", "Byte", "KB", "MB", "TB" },                                                 // Almacenamiento
            new string[] { "Dia", "Segundos", "Minutos", "Horas", "Semana", "Meses", "Año" },                       // Tiempo
            new string[] { "Km2", "M2", "Milla cuadrada", "Yarda cuadrada", "Pie cuadrado", "Pulgada cuadrada", "Hectarea", "Acre"} // Área
        };

        double[][] valores = new double[][]
        {
            // Monedas (ejemplo, puedes actualizarlo)
            new double[]{1, 18.78, 7.66, 26.15, 8.75, 36.78, 504.12 },

            // Longitud (factor a metros)
            new double[]{1, 0.01, 0.0254, 0.3048, 0.8382, 0.9144, 1000, 1609.34 },

            // Masa (factor a gramos)
            new double[]{453.592, 28.3495, 1, 1000, 45359.2, 907185 },

            // Volumen (factor a litros)
            new double[]{3.78541, 1, 0.473176, 0.001 },

            // Almacenamiento (factor en bytes)
            new double[]{1e9, 0.125, 1, 1024, 1048576, 1099511627776 },

            // Tiempo (factor en segundos)
            new double[]{86400, 1, 60, 3600, 604800, 2629800, 31557600 },

            // Área (factor en metros cuadrados)
            new double[]{1e6, 1, 2.59e6, 0.836127, 0.092903, 0.00064516, 10000, 4046.86 }
        };
        // -----------------------------
        // MÉTODO CONVERTIR CORRECTO
        // -----------------------------
       
        private double Convertir(int tipo, int de, int a, double cantidad)
        {
            return cantidad * (valores[tipo][a] / valores[tipo][de]);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtCantidadConversor.Text, out double cantidad))
            {
                MessageBox.Show("Ingrese una cantidad válida.");
                return;
            }

            int tipo = cboTipoConversor.SelectedIndex;
            int de = cboDeConversor.SelectedIndex;
            int a = cboAConversor.SelectedIndex;

            if (tipo < 0 || de < 0 || a < 0)
            {
                MessageBox.Show("Seleccione todas las opciones.");
                return;
            }

            double resultado = Convertir(tipo, de, a, cantidad);

            lblRespuesta.Text = resultado.ToString("N4");
        }

        private void lblTipoConversor_Click(object sender, EventArgs e)
        {

        }

        private void lblRespuesta_Click(object sender, EventArgs e)
        {

        }

        private void txtCantidadConversor_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCantidadConversor_Click(object sender, EventArgs e)
        {

        }

        private void cboAConversor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblAConversor_Click(object sender, EventArgs e)
        {

        }

        private void cboDeConversor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblDeConversor_Click(object sender, EventArgs e)
        {

        }

        private void cboTipoConversor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDeConversor.Items.Clear();
            cboAConversor.Items.Clear();

            cboDeConversor.Items.AddRange(etiquetas[cboTipoConversor.SelectedIndex]);
            cboAConversor.Items.AddRange(etiquetas[cboTipoConversor.SelectedIndex]);
        }
    }
}
    

