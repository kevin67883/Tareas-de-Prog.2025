using ACADEMICA23;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Docentes{

    public partial class Form1 : Form {
    
        ConexionDocente objConexion = new ConexionDocente();
        DataSet objDs = new DataSet();
        DataTable objDt = new DataTable();

        public int posicion = 0;
        public string accion = "nuevo";

        public Form1()
        {
            InitializeComponent();
        }

        private void actualizarDs()
        {
            objDs.Clear();
            objDs = objConexion.obtenerDatos();
            objDt = objDs.Tables["docentes"];
            objDt.PrimaryKey = new DataColumn[] { objDt.Columns["idDocente"] };

            grdDocente.DataSource = objDt.DefaultView;
            mostrarDatos();
        }

        private void mostrarDatos()
        {
            if (objDt.Rows.Count > 0)
            {
                lblIdDocente.Text = objDt.Rows[posicion]["idDocente"].ToString();
                txtCodigoDocente.Text = objDt.Rows[posicion]["codigo"].ToString();
                txtNombreDocente.Text = objDt.Rows[posicion]["nombre"].ToString();
                txtDireccionDocente.Text = objDt.Rows[posicion]["direccion"].ToString();
                txtTelefonoDocente.Text = objDt.Rows[posicion]["telefono"].ToString();
                lblnRegistrosDocente.Text = (posicion + 1) + " de " + objDt.Rows.Count;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            actualizarDs();
        }

        // Botones de navegación
        private void btnSiguienteDocente_Click(object sender, EventArgs e)
        {
            if (posicion < objDt.Rows.Count - 1)
            {
                posicion++;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estás en el último registro", "Navegación de Docentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnteriorDocente_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estás en el primer registro", "Navegación de Docentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUltimoDocente_Click(object sender, EventArgs e)
        {
            posicion = objDt.Rows.Count - 1;
            mostrarDatos();
        }

        private void btnPrimerDocente_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatos();
        }

        // Habilitar / deshabilitar controles
        private void estadoControles(Boolean estado)
        {
            gbrDatosDocente.Enabled = estado;
            gbrNavegacionDocente.Enabled = !estado;
            btnEliminarDocente.Enabled = !estado;
        }

        private void LimpiarControles()
        {
            lblIdDocente.Text = "";
            txtCodigoDocente.Text = "";
            txtNombreDocente.Text = "";
            txtDireccionDocente.Text = "";
            txtTelefonoDocente.Text = "";
        }

        // Botón Agregar/Guardar
        private void btnAgregarDocente_Click(object sender, EventArgs e)
        {
            if (btnAgregarDocente.Text == "Nuevo")
            {
                btnAgregarDocente.Text = "Guardar";
                btnModificarDocente.Text = "Cancelar";
                estadoControles(true);
                accion = "nuevo";
                LimpiarControles();
            }
            else
            {
                string[] docente = {
                    lblIdDocente.Text,
                    txtCodigoDocente.Text,
                    txtNombreDocente.Text,
                    txtDireccionDocente.Text,
                    txtTelefonoDocente.Text,
                };

                string respuesta = objConexion.administrarDatosDocentes(docente, accion);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al guardar docente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    estadoControles(false);
                    btnAgregarDocente.Text = "Nuevo";
                    btnModificarDocente.Text = "Modificar";
                    actualizarDs();
                }
            }
        }

        // Botón Modificar/Cancelar
        private void btnModificarDocente_Click(object sender, EventArgs e)
        {
            if (btnModificarDocente.Text == "Modificar")
            {
                btnAgregarDocente.Text = "Guardar";
                btnModificarDocente.Text = "Cancelar";
                estadoControles(true);
                accion = "modificar";
            }
            else
            {
                mostrarDatos();
                estadoControles(false);
                btnAgregarDocente.Text = "Nuevo";
                btnModificarDocente.Text = "Modificar";
            }
        }

        // Botón Eliminar
        private void btnEliminarDocente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro de eliminar al docente " + txtNombreDocente.Text + "?",
                "Eliminando Docente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string respuesta = objConexion.administrarDatosDocentes(
                    new string[] { lblIdDocente.Text, "", "", "", "", "" }, "eliminar"
                );

                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al eliminar docente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    posicion = 0;
                    actualizarDs();
                }
            }
        }

        // Búsqueda en tiempo real
        private void txtBuscarDocente_KeyUp(object sender, KeyEventArgs e)
        {
            filtrarDatos(txtBuscarDocente.Text);
        }

        private void filtrarDatos(string valor)
        {
            DataView objDv = objDt.DefaultView;
            objDv.RowFilter = "codigo LIKE '%" + valor + "%' OR nombre LIKE '%" + valor + "%'";
            grdDocente.DataSource = objDv;
        }

        // Selección en el grid
        private void seleccionarDocente()
        {
            posicion = objDt.Rows.IndexOf(objDt.Rows.Find(grdDocente.CurrentRow.Cells["idDocente"].Value));
            mostrarDatos();
        }

        private void grdDocentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarDocente();
        }
    }
}