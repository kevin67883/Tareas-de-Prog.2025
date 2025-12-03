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
    public partial class Form1 : Form
    {
        Dictionary<string, double> factores;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Bloquear para que solo elijan valores
            cboDe.DropDownStyle = ComboBoxStyle.DropDownList;
            cboA.DropDownStyle = ComboBoxStyle.DropDownList;

            string[] unidades = {
                "Pie Cuadrado",
                "Vara Cuadrada",
                "Yarda Cuadrada",
                "Metro Cuadrado",
                "Tarea",
                "Manzana",
                "Hectárea"
            };

            cboDe.Items.AddRange(unidades);
            cboA.Items.AddRange(unidades);

            // Diccionario global
            factores = new Dictionary<string, double>()
            {
                { "Pie Cuadrado", 0.09290304 },
                { "Vara Cuadrada", 0.698896 },
                { "Yarda Cuadrada", 0.83612736 },
                { "Metro Cuadrado", 1 },
                { "Tarea", 628.8 },
                { "Manzana", 6988.96 },
                { "Hectárea", 10000 }
            };
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            // Validar campo vacío
            if (string.IsNullOrWhiteSpace(txtValor.Text))
            {
                MessageBox.Show("Ingresa un valor numérico.");
                return;
            }

            // Validar número correcto
            if (!double.TryParse(txtValor.Text, out double valor))
            {
                MessageBox.Show("El valor ingresado no es válido.");
                return;
            }

            // Validar selección de unidades
            if (cboDe.SelectedIndex == -1 || cboA.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona ambas unidades de conversión.");
                return;
            }

            string origen = cboDe.SelectedItem.ToString();
            string destino = cboA.SelectedItem.ToString();

            // Convertir a metros cuadrados
            double valorEnM2 = valor * factores[origen];

            // Convertir a unidad destino
            double resultado = valorEnM2 / factores[destino];

            lblResultado.Text = resultado.ToString("N4");

        }
    }
    }
    
    
