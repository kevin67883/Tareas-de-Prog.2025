using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParciC1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtMonto.Text, out double monto))
            {
                MessageBox.Show("Ingrese un monto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double impuesto = CalcularImpuesto(monto);
            txtResultado.Text = $"${impuesto:F2}";
        }

        private double CalcularImpuesto(double monto)
        {
            double baseFija = 1000.01;   // Según la rúbrica
            double precio = 3;
            double adicional = 3;

            if (monto <= baseFija)
            {
                return precio;
            }
            else
            {
                double excedente = monto - baseFija;
                double impuesto = (excedente / 1000) * adicional + precio;
                return impuesto;
            }
        }
    }
}
