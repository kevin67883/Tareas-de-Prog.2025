using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }
        private void Form1_Load(object sender, EventArgs e) { }

        private void btnCalcular2_Click(object sender, EventArgs e)
        {
            double num1, num2, respuesta = 0;
            num1 = Double.Parse(txtNum1.Text);  
            num2 = Double.Parse(txtNum2.Text);  


            if (optSuma.Checked)
            {
                respuesta = num1 + num2;
            }
            if (optResta.Checked)
            {
                respuesta = num1 - num2;
            }
            if (optMultiplicacion.Checked)
            {
                respuesta = num1 * num2;
            }
            if (optDivicion.Checked)
            {
                respuesta = num1 / num2;
            }
            if (optExponente.Checked)
            {
                respuesta = Math.Pow(num1, num2);
            }
            if (optFactorial.Checked)
            {
                respuesta = (int)num1;
                for (int i = (int)num1 - 1; i > 1; i--)
                { //5!=5*4*3*2=120
                    respuesta *= i;
                }
            }
            lblRespuesta.Text = "Respuesta: " + respuesta;

            if (optPrimo.Checked)
            {
                int i = 1, acum = 0;
                while (i <= num1 && acum < 3)
                {
                    if (num1 % i == 0)
                    {
                        acum++; //acum = acum + 1;
                    }
                    i++;
                }
                if (acum <= 2)
                {
                    lblRespuesta.Text = "Respuesta: " + num1 + " es primo";
                }
                else
                {
                    lblRespuesta.Text = "Respuesta: " + num1 + " NO es primo";
                }
            }
            //Porcentaje.
            //Factorial. 5! = 5x4x3x2x1=120
            //Modulo.

            lblRespuesta.Text = "Respuesta: " + respuesta;
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            double num1, num2, respuesta = 0;
            num1 = Double.Parse(txtNum1.Text);  
            num2 = Double.Parse(txtNum2.Text);  


            switch (cboOpciones.SelectedIndex)
            {
                case 0:
                    respuesta = num1 + num2;
                    break;
                case 1:
                    respuesta = num1 - num2;
                    break;
                case 2:
                    respuesta = num1 * num2;
                    break;
                case 3:
                    respuesta = num1 / num2;
                    break;
            }
            lblRespuesta.Text = "Respuesta: " + respuesta;
        
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
