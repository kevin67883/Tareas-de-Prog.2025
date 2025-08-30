using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor_Mas_Volm_Tiem_Mon__etc
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
        string[][] etiquetas = new string[][] {
            new string[] { "Dolar", "Pesos Mexicanos", "Quetzal", "Lempiras", "Colon sv", "Cordobas", "Colon CR" },//Monedas
            new string[] { "Metros", "Cm", "Pulgadas", "Pies", "Varas", "Yardas", "Km", "Millas" },//Longitud
            new string[] { "Libra", "Onza", "Gramo", "Kg", "Quintal", "Tonelada Corta" },//Masa
            new string[] { "Galon Us", "Litros", "Pinta Us", "ML" },//Volumen
            new string[] { "GB", "Bit", "Byte", "KB", "MG", "TB" },//Almacenamiento
            new string[] { "Dia", "Segundos", "Minutos", "Horas", "Semana", "Meses", "Año" },//Tiempo
            new  string[] {"Ki2", "Mt2", "Milla cuadrada", "Yarda cuadrada", "Pie cuadrado", "Pulgada cuadrada", "Hectarea", "Acre"},//Area
        };

        double[][] valores = new double[][]{
            new double[]{1, 18.78, 7.66, 26.15, 8.75, 36.78, 504.12 },//Monedas
            new double[]{1, 100, 39.37, 1.193, 3.28084, 1.09361,0.001, 0.000621371 },//Longitud
            new double[]{1, 16, 453.592, 0.453592, 0.01, 0.001, 0.0005 },//Masa
            new double[]{1, 3.78541, 8, 3785.41},//Volumen
            new double[]{1, 8e+9, 1e+9, 1e+6, 1000, 0.01 },//Almacenamiento
            new double[]{1, 86400, 1440, 24, 0.142857, 0.0328767, 0.00273791},//Tiempo
            new double[]{1, 1e+6, 0.386102, 1.19599e+6, 1.07639e+7, 1.55e+9, 100},//Area
        };
        private int tipo;

        private double convertir(int opcion, int d, int a, double cantidad)
        {
            if (cantidad < 0)
            {

            }
            return cantidad * valores[tipo][a] / valores[tipo][d];
            return cantidad * (valores[opcion][a] / valores[tipo][d]);
        }
        private void btnConvertir_Click(object sender, EventArgs e) {
            double cantidad = double.Parse(txtCantidadConversor.Text);

            int tipo = cboTipoConversor.SelectedIndex;
            int de = cboDeConversor.SelectedIndex;
            int a = cboAConversor.SelectedIndex;

            double respuesta = cantidad * (valores[tipo][a] / valores[tipo][de]);

            lblRespuesta.Text = respuesta.ToString("N2");

        }

        private void cboTipoConversor_SelectedIndexChanged(object sender, EventArgs e){
            cboDeConversor.Items.Clear();
            cboAConversor.Items.Clear();

            cboDeConversor.Items.AddRange(etiquetas[cboTipoConversor.SelectedIndex]);
            cboAConversor.Items.AddRange(etiquetas[cboTipoConversor.SelectedIndex]);
        }
    }
    }

