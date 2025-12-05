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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnForm1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();      // Abre Form1
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();      // Abre Form2
        }
    }
    }

