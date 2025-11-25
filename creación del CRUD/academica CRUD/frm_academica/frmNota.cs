using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmNota : Form
    {
        public frmNota()
        {
            InitializeComponent();
        }
        Conexion objConexion = new Conexion();
        DataSet objNotas = new DataSet();
        private void actualizarDs()
        {
            int idMateria = int.Parse(cboMateria.SelectedValue?.ToString() ?? "1");
        }


        private void frmNota_Load(object sender, EventArgs e)
        { }

        private void actualizarGrid()
        {
            actualizarDs();
            dnotasDataGridView.DataSource = objNotas;
            dnotasDataGridView.DataMember = "notasAlumnos";
        }


        private void cboPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarGrid();

        }

        private void cboMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarGrid();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int nFilas = dnotasDataGridView.Rows.Count;
            for (int i = 0; i < nFilas; i++)
            {
                double lab1 = 0, lab2 = 0, parcial = 0;
                int idDetalle = int.Parse(dnotasDataGridView.Rows[i].Cells["idDetalle"]?.Value?.ToString() ?? "0");

                lab1 = double.Parse(dnotasDataGridView.Rows[i].Cells["lab1"]?.Value?.ToString() ?? "0");
                lab2 = double.Parse(dnotasDataGridView.Rows[i].Cells["lab2"]?.Value?.ToString() ?? "0");
                parcial = double.Parse(dnotasDataGridView.Rows[i].Cells["parcial"]?.Value?.ToString() ?? "0");

                string sql = "UPDATE dnotas SET lab1='" + lab1 + "', lab2='" + lab2 + "', parcial='" + parcial +
                    "' WHERE idDetalle='" + idDetalle + "'";
                String resp = objConexion.ejecutarSQL(sql);
                if (resp != "1")
                {
                    MessageBox.Show(resp, "Error al actualizar notas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                actualizarGrid();
            }
        }

        private void dnotasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
