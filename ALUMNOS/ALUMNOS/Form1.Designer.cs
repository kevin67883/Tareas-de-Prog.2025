namespace ALUMNOS
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
            this.gbrDatosAlumnos = new System.Windows.Forms.GroupBox();
            this.lblIdAlumno = new System.Windows.Forms.Label();
            this.lblCodigoAlumno = new System.Windows.Forms.Label();
            this.lblNombreAlumno = new System.Windows.Forms.Label();
            this.lblDireccionAlumno = new System.Windows.Forms.Label();
            this.lblTelefonoAlumno = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdAlumno = new System.Windows.Forms.TextBox();
            this.txtCodigoAlumno = new System.Windows.Forms.TextBox();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.txtDireccionAlumno = new System.Windows.Forms.TextBox();
            this.txtTelefonoAlumno = new System.Windows.Forms.TextBox();
            this.gbrNavegacionAlumno = new System.Windows.Forms.GroupBox();
            this.gbrEdicionAlumno = new System.Windows.Forms.GroupBox();
            this.btnAgregarAlumno = new System.Windows.Forms.Button();
            this.btnModificarAlumno = new System.Windows.Forms.Button();
            this.btnEliminarAlumno = new System.Windows.Forms.Button();
            this.btnUltimoAlumno = new System.Windows.Forms.Button();
            this.btnSiguienteAlumno = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.btnPrimeroAlumno = new System.Windows.Forms.Button();
            this.gbrDatosAlumnos.SuspendLayout();
            this.gbrNavegacionAlumno.SuspendLayout();
            this.gbrEdicionAlumno.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbrDatosAlumnos
            // 
            this.gbrDatosAlumnos.Controls.Add(this.txtTelefonoAlumno);
            this.gbrDatosAlumnos.Controls.Add(this.txtDireccionAlumno);
            this.gbrDatosAlumnos.Controls.Add(this.txtNombreAlumno);
            this.gbrDatosAlumnos.Controls.Add(this.txtCodigoAlumno);
            this.gbrDatosAlumnos.Controls.Add(this.txtIdAlumno);
            this.gbrDatosAlumnos.Controls.Add(this.lblTelefonoAlumno);
            this.gbrDatosAlumnos.Controls.Add(this.lblDireccionAlumno);
            this.gbrDatosAlumnos.Controls.Add(this.lblNombreAlumno);
            this.gbrDatosAlumnos.Controls.Add(this.label6);
            this.gbrDatosAlumnos.Controls.Add(this.lblCodigoAlumno);
            this.gbrDatosAlumnos.Controls.Add(this.lblIdAlumno);
            this.gbrDatosAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbrDatosAlumnos.Location = new System.Drawing.Point(1, 3);
            this.gbrDatosAlumnos.Name = "gbrDatosAlumnos";
            this.gbrDatosAlumnos.Size = new System.Drawing.Size(390, 279);
            this.gbrDatosAlumnos.TabIndex = 0;
            this.gbrDatosAlumnos.TabStop = false;
            this.gbrDatosAlumnos.Text = "DATOS:";
            // 
            // lblIdAlumno
            // 
            this.lblIdAlumno.AutoSize = true;
            this.lblIdAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdAlumno.Location = new System.Drawing.Point(37, 35);
            this.lblIdAlumno.Name = "lblIdAlumno";
            this.lblIdAlumno.Size = new System.Drawing.Size(26, 18);
            this.lblIdAlumno.TabIndex = 0;
            this.lblIdAlumno.Text = "ID:";
            // 
            // lblCodigoAlumno
            // 
            this.lblCodigoAlumno.AutoSize = true;
            this.lblCodigoAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoAlumno.Location = new System.Drawing.Point(37, 96);
            this.lblCodigoAlumno.Name = "lblCodigoAlumno";
            this.lblCodigoAlumno.Size = new System.Drawing.Size(73, 18);
            this.lblCodigoAlumno.TabIndex = 1;
            this.lblCodigoAlumno.Text = "CODIGO:";
            // 
            // lblNombreAlumno
            // 
            this.lblNombreAlumno.AutoSize = true;
            this.lblNombreAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAlumno.Location = new System.Drawing.Point(37, 127);
            this.lblNombreAlumno.Name = "lblNombreAlumno";
            this.lblNombreAlumno.Size = new System.Drawing.Size(83, 20);
            this.lblNombreAlumno.TabIndex = 1;
            this.lblNombreAlumno.Text = "NOMBRE:";
            // 
            // lblDireccionAlumno
            // 
            this.lblDireccionAlumno.AutoSize = true;
            this.lblDireccionAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionAlumno.Location = new System.Drawing.Point(37, 162);
            this.lblDireccionAlumno.Name = "lblDireccionAlumno";
            this.lblDireccionAlumno.Size = new System.Drawing.Size(95, 18);
            this.lblDireccionAlumno.TabIndex = 1;
            this.lblDireccionAlumno.Text = "DIRECCION:";
            // 
            // lblTelefonoAlumno
            // 
            this.lblTelefonoAlumno.AutoSize = true;
            this.lblTelefonoAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoAlumno.Location = new System.Drawing.Point(37, 219);
            this.lblTelefonoAlumno.Name = "lblTelefonoAlumno";
            this.lblTelefonoAlumno.Size = new System.Drawing.Size(70, 18);
            this.lblTelefonoAlumno.TabIndex = 1;
            this.lblTelefonoAlumno.Text = "Telefono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "label1";
            // 
            // txtIdAlumno
            // 
            this.txtIdAlumno.Location = new System.Drawing.Point(173, 35);
            this.txtIdAlumno.Name = "txtIdAlumno";
            this.txtIdAlumno.Size = new System.Drawing.Size(100, 24);
            this.txtIdAlumno.TabIndex = 2;
            // 
            // txtCodigoAlumno
            // 
            this.txtCodigoAlumno.Location = new System.Drawing.Point(135, 96);
            this.txtCodigoAlumno.Name = "txtCodigoAlumno";
            this.txtCodigoAlumno.Size = new System.Drawing.Size(100, 24);
            this.txtCodigoAlumno.TabIndex = 2;
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Location = new System.Drawing.Point(135, 127);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(100, 24);
            this.txtNombreAlumno.TabIndex = 2;
            // 
            // txtDireccionAlumno
            // 
            this.txtDireccionAlumno.Location = new System.Drawing.Point(135, 159);
            this.txtDireccionAlumno.Name = "txtDireccionAlumno";
            this.txtDireccionAlumno.Size = new System.Drawing.Size(100, 24);
            this.txtDireccionAlumno.TabIndex = 2;
            // 
            // txtTelefonoAlumno
            // 
            this.txtTelefonoAlumno.Location = new System.Drawing.Point(135, 212);
            this.txtTelefonoAlumno.Name = "txtTelefonoAlumno";
            this.txtTelefonoAlumno.Size = new System.Drawing.Size(100, 24);
            this.txtTelefonoAlumno.TabIndex = 2;
            // 
            // gbrNavegacionAlumno
            // 
            this.gbrNavegacionAlumno.Controls.Add(this.btnPrimeroAlumno);
            this.gbrNavegacionAlumno.Controls.Add(this.btn);
            this.gbrNavegacionAlumno.Controls.Add(this.btnSiguienteAlumno);
            this.gbrNavegacionAlumno.Controls.Add(this.btnUltimoAlumno);
            this.gbrNavegacionAlumno.Location = new System.Drawing.Point(1, 310);
            this.gbrNavegacionAlumno.Name = "gbrNavegacionAlumno";
            this.gbrNavegacionAlumno.Size = new System.Drawing.Size(390, 100);
            this.gbrNavegacionAlumno.TabIndex = 1;
            this.gbrNavegacionAlumno.TabStop = false;
            this.gbrNavegacionAlumno.Text = "Nevegacion:";
            // 
            // gbrEdicionAlumno
            // 
            this.gbrEdicionAlumno.Controls.Add(this.btnEliminarAlumno);
            this.gbrEdicionAlumno.Controls.Add(this.btnModificarAlumno);
            this.gbrEdicionAlumno.Controls.Add(this.btnAgregarAlumno);
            this.gbrEdicionAlumno.Location = new System.Drawing.Point(457, 310);
            this.gbrEdicionAlumno.Name = "gbrEdicionAlumno";
            this.gbrEdicionAlumno.Size = new System.Drawing.Size(341, 100);
            this.gbrEdicionAlumno.TabIndex = 1;
            this.gbrEdicionAlumno.TabStop = false;
            this.gbrEdicionAlumno.Text = "Edicion";
            // 
            // btnAgregarAlumno
            // 
            this.btnAgregarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAlumno.Location = new System.Drawing.Point(4, 48);
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Size = new System.Drawing.Size(75, 32);
            this.btnAgregarAlumno.TabIndex = 0;
            this.btnAgregarAlumno.Text = "NUEVO";
            this.btnAgregarAlumno.UseVisualStyleBackColor = true;
            // 
            // btnModificarAlumno
            // 
            this.btnModificarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarAlumno.Location = new System.Drawing.Point(85, 49);
            this.btnModificarAlumno.Name = "btnModificarAlumno";
            this.btnModificarAlumno.Size = new System.Drawing.Size(109, 31);
            this.btnModificarAlumno.TabIndex = 0;
            this.btnModificarAlumno.Text = "MODIFICAR";
            this.btnModificarAlumno.UseVisualStyleBackColor = true;
            // 
            // btnEliminarAlumno
            // 
            this.btnEliminarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAlumno.Location = new System.Drawing.Point(200, 48);
            this.btnEliminarAlumno.Name = "btnEliminarAlumno";
            this.btnEliminarAlumno.Size = new System.Drawing.Size(119, 32);
            this.btnEliminarAlumno.TabIndex = 0;
            this.btnEliminarAlumno.Text = "ELIMINAR";
            this.btnEliminarAlumno.UseVisualStyleBackColor = true;
            // 
            // btnUltimoAlumno
            // 
            this.btnUltimoAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoAlumno.Location = new System.Drawing.Point(306, 49);
            this.btnUltimoAlumno.Name = "btnUltimoAlumno";
            this.btnUltimoAlumno.Size = new System.Drawing.Size(75, 23);
            this.btnUltimoAlumno.TabIndex = 0;
            this.btnUltimoAlumno.Text = ">";
            this.btnUltimoAlumno.UseVisualStyleBackColor = true;
            // 
            // btnSiguienteAlumno
            // 
            this.btnSiguienteAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteAlumno.Location = new System.Drawing.Point(211, 49);
            this.btnSiguienteAlumno.Name = "btnSiguienteAlumno";
            this.btnSiguienteAlumno.Size = new System.Drawing.Size(75, 23);
            this.btnSiguienteAlumno.TabIndex = 0;
            this.btnSiguienteAlumno.Text = ">|";
            this.btnSiguienteAlumno.UseVisualStyleBackColor = true;
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.Location = new System.Drawing.Point(130, 49);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 0;
            this.btn.Text = "<";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // btnPrimeroAlumno
            // 
            this.btnPrimeroAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroAlumno.Location = new System.Drawing.Point(35, 49);
            this.btnPrimeroAlumno.Name = "btnPrimeroAlumno";
            this.btnPrimeroAlumno.Size = new System.Drawing.Size(75, 23);
            this.btnPrimeroAlumno.TabIndex = 0;
            this.btnPrimeroAlumno.Text = "|<";
            this.btnPrimeroAlumno.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbrEdicionAlumno);
            this.Controls.Add(this.gbrNavegacionAlumno);
            this.Controls.Add(this.gbrDatosAlumnos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbrDatosAlumnos.ResumeLayout(false);
            this.gbrDatosAlumnos.PerformLayout();
            this.gbrNavegacionAlumno.ResumeLayout(false);
            this.gbrEdicionAlumno.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbrDatosAlumnos;
        private System.Windows.Forms.Label lblIdAlumno;
        private System.Windows.Forms.TextBox txtTelefonoAlumno;
        private System.Windows.Forms.TextBox txtDireccionAlumno;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.TextBox txtCodigoAlumno;
        private System.Windows.Forms.TextBox txtIdAlumno;
        private System.Windows.Forms.Label lblTelefonoAlumno;
        private System.Windows.Forms.Label lblDireccionAlumno;
        private System.Windows.Forms.Label lblNombreAlumno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCodigoAlumno;
        private System.Windows.Forms.GroupBox gbrNavegacionAlumno;
        private System.Windows.Forms.Button btnPrimeroAlumno;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnSiguienteAlumno;
        private System.Windows.Forms.Button btnUltimoAlumno;
        private System.Windows.Forms.GroupBox gbrEdicionAlumno;
        private System.Windows.Forms.Button btnEliminarAlumno;
        private System.Windows.Forms.Button btnModificarAlumno;
        private System.Windows.Forms.Button btnAgregarAlumno;
    }
}

