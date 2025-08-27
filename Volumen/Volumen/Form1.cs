using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volumen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1Convertir_Click(object sender, EventArgs e)
        {
            Double ConvertirVol = 1, ConvertidoVol = 1, ResultadoVol = 0, CantidadVol = 0;
            Double L = 1.0, mL = 1000, galImp = 4.546, qtoImp = 1.136,
                ptaImp = 1.76, tzaImp = 3.52, flozImp = 35.195,
                cdaImp = 56.312, cditaImp = 168.9, ftcubico = 28.317;

            if (!Double.TryParse(txt1CantidadVol.Text, out CantidadVol))
            {
                MessageBox.Show(" Ingrese solo medidas de volumen. ");
                return;
            }

            switch (cbo1ConvertirVol.SelectedIndex)

            {
                case 0: ConvertirVol = L; break;

                case 1: ConvertirVol = mL; break;

                case 2: ConvertirVol = galImp; break;

                case 3: ConvertirVol = qtoImp; break;

                case 4: ConvertirVol = ptaImp; break;

                case 5: ConvertirVol = tzaImp; break;

                case 6: ConvertirVol = flozImp; break;

                case 7: ConvertirVol = cdaImp; break;

                case 8: ConvertirVol = cditaImp; break;

                case 9: ConvertirVol = ftcubico; break;

                default: ConvertirVol = 1; break;
            }

            switch (cbo2ConvertidoVol.SelectedIndex)

            {
                case 0: ConvertidoVol = L; break;

                case 1: ConvertidoVol = mL; break;

                case 2: ConvertidoVol = galImp; break;

                case 3: ConvertidoVol = qtoImp; break;

                case 4: ConvertidoVol = ptaImp; break;

                case 5: ConvertidoVol = tzaImp; break;

                case 6: ConvertidoVol = flozImp; break;

                case 7: ConvertidoVol = cdaImp; break;

                case 8: ConvertidoVol = cditaImp; break;

                case 9: ConvertidoVol = ftcubico; break;

                default: ConvertidoVol = 1; break;
            }

            ResultadoVol = CantidadVol * (ConvertidoVol / ConvertirVol);

            txt2ResultadoVol.Text = ResultadoVol.ToString("F4");
        }

        private void btn2ConvertirVol_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn2ConvertirVol_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
