using ParcialSegundoll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Conexion_base_datos objCOnexion = new Conexion_base_datos();
        DataSet objDs = new DataSet();
        DataTable objDt = new DataTable();

        public int posicion = 0;
        public string accion = "nuevo";

        private void actualizarDs()
        {
            objDs.Clear(); //Limpiar el DataSet
            objDs = objCOnexion.obtenerDatos();
            objDt = objDs.Tables["Usuarios"];
            objDt.PrimaryKey = new DataColumn[] { objDt.Columns["idUsuario"] };

            grdUsuario.DataSource = objDt.DefaultView;
            mostrarDatos();
        }
        private void mostrarDatos()
        {
            if (objDt.Rows.Count > 0)
            {
                idusuario1.Text = objDt.Rows[posicion]["idUsuario"].ToString();
                txtUsuario.Text = objDt.Rows[posicion]["usuario "].ToString();
                txtClaveUsuario.Text = objDt.Rows[posicion]["clave"].ToString();
                txtNombreUsuario.Text = objDt.Rows[posicion]["nombre"].ToString();
                txtdireccion.Text = objDt.Rows[posicion]["direccion"].ToString();
                txtTelefonoUsuario.Text = objDt.Rows[posicion]["telefono"].ToString();

                lblUsuarioRegistro.Text = (posicion + 1) + " de " + objDt.Rows.Count;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            actualizarDs();
        }

        private void btnSiguienteUsuario_Click(object sender, EventArgs e)
        {
            if (posicion < objDt.Rows.Count - 1)
            {
                posicion++;// posicion=posicion+1
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el ultimo registro.", "Navegacion de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnteriorUsuario_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;// posicion=posicion-1
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el primer registro.", "Navegacion de Alumnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUltimoUsuario_Click(object sender, EventArgs e)
        {
            posicion = objDt.Rows.Count - 1;
            mostrarDatos();

        }

        private void btnPrimeroUsuario_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatos();
        }
        private void estadoControles(Boolean estado)
        {
            grbDatosUsuario.Enabled = estado;
            grbNavegacionUsuario.Enabled = !estado;
            btnEliminarUsuario.Enabled = !estado;
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {

            if (btnAgregarUsuario.Text == "Nuevo")
            {
                btnAgregarUsuario.Text = "Guardar";
                btnModificarUsuario.Text = "Cancelar";
                estadoControles(true);
                accion = "nuevo";

            }
            else
            {//Guardar
                String[] usuario = {
                    idusuario1.Text, txtUsuario.Text, txtClaveUsuario.Text, txtNombreUsuario.Text,
                    txtdireccion.Text, txtTelefonoUsuario.Text
                };
                String respuesta = objCOnexion.administrarDatosUsuario(usuario, accion);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al guardar alumnos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    estadoControles(false);
                    btnAgregarUsuario.Text = "Nuevo";
                    btnModificarUsuario.Text = "Modificar";
                    actualizarDs();
                }

            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {

            if (btnAgregarUsuario.Text == "Nuevo")
            {
                btnAgregarUsuario.Text = "Guardar";
                btnModificarUsuario.Text = "Cancelar";
                estadoControles(true);
                accion = "nuevo";

            }
            else
            {//Guardar
                String[] usuario = {
                    idusuario1.Text, txtUsuario.Text, txtClaveUsuario.Text, txtNombreUsuario.Text,
                    txtdireccion.Text, txtTelefonoUsuario.Text
                };
                String respuesta = objCOnexion.administrarDatosUsuario(usuario, accion);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al guardar alumnos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    estadoControles(false);
                    btnAgregarUsuario.Text = "Nuevo";
                    btnModificarUsuario.Text = "Modificar";
                    actualizarDs();
                }

            }
        }

        private void txtBuscarUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void grbDatosUsuario_Enter(object sender, EventArgs e)
        {

        }

        private void grdUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
