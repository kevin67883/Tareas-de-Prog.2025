using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estadistica
{
    public partial class Form1 : Form
    {
        private object txtSerie;

        public Form1()
        {
            InitializeComponent();
        }
        //Matrices
        //Funciones
        //LINQ = Lenguaje de consultas integrado

        double media(string[]serie) {
            int n = serie.Length;
            double suma = 0;

            for ( int i = 0; i < n; i++) {
                suma += double.Parse(serie[i]); 
            }
            return suma / n;
        }
        double tipica(string serie, double m){
            double tipica = 0;
            int n = serie.Length;

            for (int i = 0; i < n; i++) {
                int num = int.Parse(serie [i]);
                tipica += Math.Pow(num - m, 2);

            }
            tipica = Math.Sqrt(tipica / n - 1);
            return tipica;
        }

        private void btnCalcular_Click(object sender, EventArgs e) {
            //int[] serie = txtSerie.Text.Split(" , ").Select(n=>int.Parse(n)).ToArray(); //5,8,1,9 => ["5","8","1", "9"]
            string[] serie = txtSerie.Text.Split(" , ");

            double mediaAritmetica = media(serie);
            double desviacionTipica = tipica(serie, mediaAritmetica);

            lblMedia.Text = "Media: " + mediaAritmetica.ToString();
            lblTipica.Text = "Tipica: " + desviacionTipica.ToString();
            

                
        }

        private double tipica(string[] serie, double mediaAritmetica)
        {
            throw new NotImplementedException();
        }
    }
}
