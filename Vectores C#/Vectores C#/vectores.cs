using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vectores_C_
{
    public partial class vectores : Form
    {
        public vectores()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            {
                string[] serie = txtSerie.Text.Split(','); //5,10,15 => ["5", "10", "15"] 

                int suma = 0;
                for (int i = 0; i < serie.Length; i++)
                {
                    suma = suma + int.Parse(serie[i]);
                }
                lblSuma.Text = "Suma: " + suma;

                int[] numeros = Array.ConvertAll(serie, int.Parse);

                double promedio = (double)suma / numeros.Length;

                int mayor = numeros.Max();
                int menor = numeros.Min();

                lblPromedio.Text = "Promedio: " + promedio;
                lblMayor.Text = "Mayor: " + mayor;
                lblMenor.Text = "Menor: " + menor;
            }

        }

        private void lblSuma_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
