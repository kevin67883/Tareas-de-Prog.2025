namespace Docentes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbrDatosDocente = new System.Windows.Forms.GroupBox();
            this.lblTelefonoDocente = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDireccionDocente = new System.Windows.Forms.Label();
            this.lblNombreDocente = new System.Windows.Forms.Label();
            this.lblCodigoDocente = new System.Windows.Forms.Label();
            this.txtDireccionDocente = new System.Windows.Forms.TextBox();
            this.lblIdDocente = new System.Windows.Forms.Label();
            this.txtTelefonoDocente = new System.Windows.Forms.TextBox();
            this.txtNombreDocente = new System.Windows.Forms.TextBox();
            this.txtCodigoDocente = new System.Windows.Forms.TextBox();
            this.txtIdDocente = new System.Windows.Forms.TextBox();
            this.gbrNavegacionDocente = new System.Windows.Forms.GroupBox();
            this.lblnRegistrosDocente = new System.Windows.Forms.Label();
            this.btnUltimoDocente = new System.Windows.Forms.Button();
            this.btnSiguienteDocente = new System.Windows.Forms.Button();
            this.btnAnteriorDocente = new System.Windows.Forms.Button();
            this.btnPrimerDocente = new System.Windows.Forms.Button();
            this.gbrEdicionDocente = new System.Windows.Forms.GroupBox();
            this.btnEliminarDocente = new System.Windows.Forms.Button();
            this.btnModificarDocente = new System.Windows.Forms.Button();
            this.btnAgregarDocente = new System.Windows.Forms.Button();
            this.grbBusquedaDocente = new System.Windows.Forms.GroupBox();
            this.grdDocente = new System.Windows.Forms.DataGridView();
            this.txtBuscarDocente = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbrDatosDocente.SuspendLayout();
            this.gbrNavegacionDocente.SuspendLayout();
            this.gbrEdicionDocente.SuspendLayout();
            this.grbBusquedaDocente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDocente)).BeginInit();
            this.SuspendLayout();
            // 
            // gbrDatosDocente
            // 
            this.gbrDatosDocente.Controls.Add(this.lblTelefonoDocente);
            this.gbrDatosDocente.Controls.Add(this.label6);
            this.gbrDatosDocente.Controls.Add(this.lblDireccionDocente);
            this.gbrDatosDocente.Controls.Add(this.lblNombreDocente);
            this.gbrDatosDocente.Controls.Add(this.lblCodigoDocente);
            this.gbrDatosDocente.Controls.Add(this.txtDireccionDocente);
            this.gbrDatosDocente.Controls.Add(this.lblIdDocente);
            this.gbrDatosDocente.Controls.Add(this.txtTelefonoDocente);
            this.gbrDatosDocente.Controls.Add(this.txtNombreDocente);
            this.gbrDatosDocente.Controls.Add(this.txtCodigoDocente);
            this.gbrDatosDocente.Controls.Add(this.txtIdDocente);
            this.gbrDatosDocente.Enabled = false;
            this.gbrDatosDocente.Location = new System.Drawing.Point(0, 2);
            this.gbrDatosDocente.Name = "gbrDatosDocente";
            this.gbrDatosDocente.Size = new System.Drawing.Size(352, 237);
            this.gbrDatosDocente.TabIndex = 1;
            this.gbrDatosDocente.TabStop = false;
            this.gbrDatosDocente.Text = "Datos";
            // 
            // lblTelefonoDocente
            // 
            this.lblTelefonoDocente.AutoSize = true;
            this.lblTelefonoDocente.Location = new System.Drawing.Point(41, 181);
            this.lblTelefonoDocente.Name = "lblTelefonoDocente";
            this.lblTelefonoDocente.Size = new System.Drawing.Size(64, 13);
            this.lblTelefonoDocente.TabIndex = 1;
            this.lblTelefonoDocente.Text = "TELEFONO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "label1";
            // 
            // lblDireccionDocente
            // 
            this.lblDireccionDocente.AutoSize = true;
            this.lblDireccionDocente.Location = new System.Drawing.Point(41, 147);
            this.lblDireccionDocente.Name = "lblDireccionDocente";
            this.lblDireccionDocente.Size = new System.Drawing.Size(66, 13);
            this.lblDireccionDocente.TabIndex = 1;
            this.lblDireccionDocente.Text = "DIRECCION";
            // 
            // lblNombreDocente
            // 
            this.lblNombreDocente.AutoSize = true;
            this.lblNombreDocente.Location = new System.Drawing.Point(41, 117);
            this.lblNombreDocente.Name = "lblNombreDocente";
            this.lblNombreDocente.Size = new System.Drawing.Size(54, 13);
            this.lblNombreDocente.TabIndex = 1;
            this.lblNombreDocente.Text = "NOMBRE";
            // 
            // lblCodigoDocente
            // 
            this.lblCodigoDocente.AutoSize = true;
            this.lblCodigoDocente.Location = new System.Drawing.Point(41, 89);
            this.lblCodigoDocente.Name = "lblCodigoDocente";
            this.lblCodigoDocente.Size = new System.Drawing.Size(49, 13);
            this.lblCodigoDocente.TabIndex = 1;
            this.lblCodigoDocente.Text = "CODIGO";
            // 
            // txtDireccionDocente
            // 
            this.txtDireccionDocente.Location = new System.Drawing.Point(176, 147);
            this.txtDireccionDocente.Name = "txtDireccionDocente";
            this.txtDireccionDocente.Size = new System.Drawing.Size(100, 20);
            this.txtDireccionDocente.TabIndex = 0;
            // 
            // lblIdDocente
            // 
            this.lblIdDocente.AutoSize = true;
            this.lblIdDocente.Location = new System.Drawing.Point(41, 40);
            this.lblIdDocente.Name = "lblIdDocente";
            this.lblIdDocente.Size = new System.Drawing.Size(18, 13);
            this.lblIdDocente.TabIndex = 1;
            this.lblIdDocente.Text = "ID";
            // 
            // txtTelefonoDocente
            // 
            this.txtTelefonoDocente.Location = new System.Drawing.Point(176, 181);
            this.txtTelefonoDocente.Name = "txtTelefonoDocente";
            this.txtTelefonoDocente.Size = new System.Drawing.Size(100, 20);
            this.txtTelefonoDocente.TabIndex = 0;
            // 
            // txtNombreDocente
            // 
            this.txtNombreDocente.Location = new System.Drawing.Point(176, 117);
            this.txtNombreDocente.Name = "txtNombreDocente";
            this.txtNombreDocente.Size = new System.Drawing.Size(100, 20);
            this.txtNombreDocente.TabIndex = 0;
            // 
            // txtCodigoDocente
            // 
            this.txtCodigoDocente.Location = new System.Drawing.Point(176, 86);
            this.txtCodigoDocente.Name = "txtCodigoDocente";
            this.txtCodigoDocente.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoDocente.TabIndex = 0;
            // 
            // txtIdDocente
            // 
            this.txtIdDocente.Location = new System.Drawing.Point(176, 40);
            this.txtIdDocente.Name = "txtIdDocente";
            this.txtIdDocente.Size = new System.Drawing.Size(100, 20);
            this.txtIdDocente.TabIndex = 0;
            // 
            // gbrNavegacionDocente
            // 
            this.gbrNavegacionDocente.Controls.Add(this.lblnRegistrosDocente);
            this.gbrNavegacionDocente.Controls.Add(this.btnUltimoDocente);
            this.gbrNavegacionDocente.Controls.Add(this.btnSiguienteDocente);
            this.gbrNavegacionDocente.Controls.Add(this.btnAnteriorDocente);
            this.gbrNavegacionDocente.Controls.Add(this.btnPrimerDocente);
            this.gbrNavegacionDocente.Location = new System.Drawing.Point(12, 279);
            this.gbrNavegacionDocente.Name = "gbrNavegacionDocente";
            this.gbrNavegacionDocente.Size = new System.Drawing.Size(433, 100);
            this.gbrNavegacionDocente.TabIndex = 2;
            this.gbrNavegacionDocente.TabStop = false;
            this.gbrNavegacionDocente.Text = "Navegacion";
            // 
            // lblnRegistrosDocente
            // 
            this.lblnRegistrosDocente.AutoSize = true;
            this.lblnRegistrosDocente.Location = new System.Drawing.Point(184, 44);
            this.lblnRegistrosDocente.Name = "lblnRegistrosDocente";
            this.lblnRegistrosDocente.Size = new System.Drawing.Size(36, 13);
            this.lblnRegistrosDocente.TabIndex = 2;
            this.lblnRegistrosDocente.Text = "x de n";
            // 
            // btnUltimoDocente
            // 
            this.btnUltimoDocente.Location = new System.Drawing.Point(358, 44);
            this.btnUltimoDocente.Name = "btnUltimoDocente";
            this.btnUltimoDocente.Size = new System.Drawing.Size(75, 23);
            this.btnUltimoDocente.TabIndex = 0;
            this.btnUltimoDocente.Text = ">|";
            this.btnUltimoDocente.UseVisualStyleBackColor = true;
            // 
            // btnSiguienteDocente
            // 
            this.btnSiguienteDocente.Location = new System.Drawing.Point(277, 44);
            this.btnSiguienteDocente.Name = "btnSiguienteDocente";
            this.btnSiguienteDocente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguienteDocente.TabIndex = 0;
            this.btnSiguienteDocente.Text = ">";
            this.btnSiguienteDocente.UseVisualStyleBackColor = true;
            // 
            // btnAnteriorDocente
            // 
            this.btnAnteriorDocente.Location = new System.Drawing.Point(87, 44);
            this.btnAnteriorDocente.Name = "btnAnteriorDocente";
            this.btnAnteriorDocente.Size = new System.Drawing.Size(75, 23);
            this.btnAnteriorDocente.TabIndex = 0;
            this.btnAnteriorDocente.Text = "<";
            this.btnAnteriorDocente.UseVisualStyleBackColor = true;
            // 
            // btnPrimerDocente
            // 
            this.btnPrimerDocente.Location = new System.Drawing.Point(6, 44);
            this.btnPrimerDocente.Name = "btnPrimerDocente";
            this.btnPrimerDocente.Size = new System.Drawing.Size(75, 23);
            this.btnPrimerDocente.TabIndex = 0;
            this.btnPrimerDocente.Text = "|<";
            this.btnPrimerDocente.UseVisualStyleBackColor = true;
            // 
            // gbrEdicionDocente
            // 
            this.gbrEdicionDocente.Controls.Add(this.btnEliminarDocente);
            this.gbrEdicionDocente.Controls.Add(this.btnModificarDocente);
            this.gbrEdicionDocente.Controls.Add(this.btnAgregarDocente);
            this.gbrEdicionDocente.Location = new System.Drawing.Point(468, 279);
            this.gbrEdicionDocente.Name = "gbrEdicionDocente";
            this.gbrEdicionDocente.Size = new System.Drawing.Size(320, 100);
            this.gbrEdicionDocente.TabIndex = 3;
            this.gbrEdicionDocente.TabStop = false;
            this.gbrEdicionDocente.Text = "Edicion";
            // 
            // btnEliminarDocente
            // 
            this.btnEliminarDocente.Location = new System.Drawing.Point(228, 44);
            this.btnEliminarDocente.Name = "btnEliminarDocente";
            this.btnEliminarDocente.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarDocente.TabIndex = 0;
            this.btnEliminarDocente.Text = "Eliminar";
            this.btnEliminarDocente.UseVisualStyleBackColor = true;
            // 
            // btnModificarDocente
            // 
            this.btnModificarDocente.Location = new System.Drawing.Point(111, 44);
            this.btnModificarDocente.Name = "btnModificarDocente";
            this.btnModificarDocente.Size = new System.Drawing.Size(75, 23);
            this.btnModificarDocente.TabIndex = 0;
            this.btnModificarDocente.Text = "Modificar";
            this.btnModificarDocente.UseVisualStyleBackColor = true;
            // 
            // btnAgregarDocente
            // 
            this.btnAgregarDocente.Location = new System.Drawing.Point(6, 44);
            this.btnAgregarDocente.Name = "btnAgregarDocente";
            this.btnAgregarDocente.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarDocente.TabIndex = 0;
            this.btnAgregarDocente.Text = "Nuevo";
            this.btnAgregarDocente.UseVisualStyleBackColor = true;
            // 
            // grbBusquedaDocente
            // 
            this.grbBusquedaDocente.Controls.Add(this.grdDocente);
            this.grbBusquedaDocente.Controls.Add(this.txtBuscarDocente);
            this.grbBusquedaDocente.Location = new System.Drawing.Point(358, 2);
            this.grbBusquedaDocente.Name = "grbBusquedaDocente";
            this.grbBusquedaDocente.Size = new System.Drawing.Size(440, 237);
            this.grbBusquedaDocente.TabIndex = 4;
            this.grbBusquedaDocente.TabStop = false;
            this.grbBusquedaDocente.Text = "Busqueda Alumnos";
            // 
            // grdDocente
            // 
            this.grdDocente.AllowUserToAddRows = false;
            this.grdDocente.AllowUserToDeleteRows = false;
            this.grdDocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDocente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.codigo,
            this.nombre,
            this.direccion,
            this.telefono});
            this.grdDocente.Location = new System.Drawing.Point(0, 45);
            this.grdDocente.Name = "grdDocente";
            this.grdDocente.ReadOnly = true;
            this.grdDocente.Size = new System.Drawing.Size(440, 192);
            this.grdDocente.TabIndex = 1;
            // 
            // txtBuscarDocente
            // 
            this.txtBuscarDocente.Location = new System.Drawing.Point(0, 19);
            this.txtBuscarDocente.Name = "txtBuscarDocente";
            this.txtBuscarDocente.Size = new System.Drawing.Size(428, 20);
            this.txtBuscarDocente.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "idADocente";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "CODIGO";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 150;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "DIRECCION";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 250;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "TEL";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbBusquedaDocente);
            this.Controls.Add(this.gbrEdicionDocente);
            this.Controls.Add(this.gbrNavegacionDocente);
            this.Controls.Add(this.gbrDatosDocente);
            this.Name = "Form1";
            this.Text = "ADMISTRACION DE DOCENTES";
            this.gbrDatosDocente.ResumeLayout(false);
            this.gbrDatosDocente.PerformLayout();
            this.gbrNavegacionDocente.ResumeLayout(false);
            this.gbrNavegacionDocente.PerformLayout();
            this.gbrEdicionDocente.ResumeLayout(false);
            this.grbBusquedaDocente.ResumeLayout(false);
            this.grbBusquedaDocente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDocente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbrDatosDocente;
        private System.Windows.Forms.Label lblTelefonoDocente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDireccionDocente;
        private System.Windows.Forms.Label lblNombreDocente;
        private System.Windows.Forms.Label lblCodigoDocente;
        private System.Windows.Forms.TextBox txtDireccionDocente;
        private System.Windows.Forms.Label lblIdDocente;
        private System.Windows.Forms.TextBox txtTelefonoDocente;
        private System.Windows.Forms.TextBox txtNombreDocente;
        private System.Windows.Forms.TextBox txtCodigoDocente;
        private System.Windows.Forms.TextBox txtIdDocente;
        private System.Windows.Forms.GroupBox gbrNavegacionDocente;
        private System.Windows.Forms.Label lblnRegistrosDocente;
        private System.Windows.Forms.Button btnUltimoDocente;
        private System.Windows.Forms.Button btnSiguienteDocente;
        private System.Windows.Forms.Button btnAnteriorDocente;
        private System.Windows.Forms.Button btnPrimerDocente;
        private System.Windows.Forms.GroupBox gbrEdicionDocente;
        private System.Windows.Forms.Button btnEliminarDocente;
        private System.Windows.Forms.Button btnModificarDocente;
        private System.Windows.Forms.Button btnAgregarDocente;
        private System.Windows.Forms.GroupBox grbBusquedaDocente;
        private System.Windows.Forms.DataGridView grdDocente;
        private System.Windows.Forms.TextBox txtBuscarDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
    }
}

