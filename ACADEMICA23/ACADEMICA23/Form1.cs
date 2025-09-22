﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACADEMICA23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Conexion objConexion = new Conexion();
        DataSet objDs = new DataSet();
        DataTable objDt = new DataTable();

        public int posicion = 0;
        public string accion = "nuevo";

        private void actualizarDs()
        {
            objDs.Clear();//Limpiar el DataSet
            objDs = objConexion.obtenerDatos();
            objDt = objDs.Tables["alumnos"];
            objDt.PrimaryKey = new DataColumn[] { objDt.Columns["idAlumno"] };

        }
        private void mostrarDatos()
        {
            if (objDt.Rows.Count > 0)
            {
                lblIdAlumno.Text = objDt.Rows[posicion]["idAlumno"].ToString();
                txtCodigoAlumno.Text = objDt.Rows[posicion]["codigo"].ToString();
                txtNombreAlumno.Text = objDt.Rows[posicion]["nombre"].ToString();
                txtDireccionAlumno.Text = objDt.Rows[posicion]["direccion"].ToString();
                txtTelefonoAlumno.Text = objDt.Rows[posicion]["telefono"].ToString();
                lblnRegistrosAlumno.Text = (posicion + 1) + " de " + objDt.Rows.Count;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSiguienteAlumno_Click(object sender, EventArgs e)
        {
            if (posicion < objDt.Rows.Count - 1)
            {
                posicion++;//posicion = posicion + 1
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el ultimo registro", "Navegacion de Alumnos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnAnteriorAlumno_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;//posicion = posicion - 1
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el ultimo registro", "Navegacion de Alumnos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void btnUltimoAlumno_Click(object sender, EventArgs e)
        {
            posicion = objDt.Rows.Count - 1;
            mostrarDatos();
        }

        private void btnPrimerAlumno_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatos();
        }
        private void estadoControles(Boolean estado)
        {
            gbrDatosAlumno.Enabled = estado;
            gbrNavegacionAlumno.Enabled = !estado;
            btnEliminarAlumno.Enabled = !estado;
        }
        private void LimpiarControles()
        {
            lblIdAlumno.Text = "";
            txtCodigoAlumno.Text = "";
            txtNombreAlumno.Text = "";
            txtDireccionAlumno.Text = "";
            txtTelefonoAlumno.Text = "";

        }
        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            if (btnAgregarAlumno.Text == "Nuevo")
            {
                btnAgregarAlumno.Text = "Guardar";
                btnModificarAlumno.Text = "Canclar";
                estadoControles(true);
                accion = "nuevo";
                LimpiarControles();
            }
            else
            {//Guardar
                String[] alumnos = {
                lblIdAlumno.Text, txtCodigoAlumno.Text, txtNombreAlumno.Text, txtDireccionAlumno.Text, txtTelefonoAlumno.Text,
                };
                String respuesta = objConexion.administrarDatosAlumnos(alumnos, accion);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al guardar alumnos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    estadoControles(false);
                    btnAgregarAlumno.Text = "Nuevo";
                    btnModificarAlumno.Text = "Modificar";
                    actualizarDs();


                }
                estadoControles(false);
                btnAgregarAlumno.Text = "Nuevo";
                btnModificarAlumno.Text = "Modificar";
            }
        }


        private void btnModificarAlumno_Click(object sender, EventArgs e)
        {
            if (btnModificarAlumno.Text == "Modificar")
            {
                btnAgregarAlumno.Text = "Guardar";
                btnModificarAlumno.Text = "Canclar";
                estadoControles(true);
                accion = "modificar";
            }
            else
            {//Cancelar
                mostrarDatos();
                estadoControles(false);
                btnAgregarAlumno.Text = "Nuevo";
                btnModificarAlumno.Text = "Modificar";
            }
        }

        private void btnEliminarAlumno_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de eliminar a" + txtNombreAlumno.Text,
                "Eliminando alumnos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) { }
            String respuesta = objConexion.administrarDatosAlumnos(
                new string[] { lblIdAlumno.Text, "", "", "",""}, "eliminar"
              );
            if (respuesta != "1")
            {
                MessageBox.Show(respuesta, "Error al eliminar alumnos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else {
                posicion = 0;
                actualizarDs();
            }
        }
    }
}
    
    
    

