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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e){
            
            string[] serie = txtSerie.Text.Split(',');//5,10,15 => ["5", "10", "15"] =>  string[] m = new string[] 
           
            int suma = 0;
            for (int i = 0; i < serie.Length; i++) {
                suma = suma + int.Parse(serie[i]);
            }
            lblSuma.Text = "suma: " + suma;
            //lblSuma.Text = "suma: " + serie.Suma();
        }
    }
    }

