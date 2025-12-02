namespace LaboCl
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
            this.btnConvertir = new System.Windows.Forms.Button();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.txtCantidadConversor = new System.Windows.Forms.TextBox();
            this.lblCantidadConversor = new System.Windows.Forms.Label();
            this.cboAConversor = new System.Windows.Forms.ComboBox();
            this.lblAConversor = new System.Windows.Forms.Label();
            this.cboDeConversor = new System.Windows.Forms.ComboBox();
            this.lblDeConversor = new System.Windows.Forms.Label();
            this.cboTipoConversor = new System.Windows.Forms.ComboBox();
            this.lblTipoConversor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(430, 282);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(128, 64);
            this.btnConvertir.TabIndex = 26;
            this.btnConvertir.Text = "CONVERTIR";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Location = new System.Drawing.Point(307, 295);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(49, 13);
            this.lblRespuesta.TabIndex = 25;
            this.lblRespuesta.Text = "SUMAR:";
            this.lblRespuesta.Click += new System.EventHandler(this.lblRespuesta_Click);
            // 
            // txtCantidadConversor
            // 
            this.txtCantidadConversor.Location = new System.Drawing.Point(432, 229);
            this.txtCantidadConversor.Name = "txtCantidadConversor";
            this.txtCantidadConversor.Size = new System.Drawing.Size(126, 20);
            this.txtCantidadConversor.TabIndex = 24;
            this.txtCantidadConversor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCantidadConversor.TextChanged += new System.EventHandler(this.txtCantidadConversor_TextChanged);
            // 
            // lblCantidadConversor
            // 
            this.lblCantidadConversor.AutoSize = true;
            this.lblCantidadConversor.Location = new System.Drawing.Point(307, 229);
            this.lblCantidadConversor.Name = "lblCantidadConversor";
            this.lblCantidadConversor.Size = new System.Drawing.Size(65, 13);
            this.lblCantidadConversor.TabIndex = 23;
            this.lblCantidadConversor.Text = "CANTIDAD:";
            this.lblCantidadConversor.Click += new System.EventHandler(this.lblCantidadConversor_Click);
            // 
            // cboAConversor
            // 
            this.cboAConversor.FormattingEnabled = true;
            this.cboAConversor.Location = new System.Drawing.Point(437, 171);
            this.cboAConversor.Name = "cboAConversor";
            this.cboAConversor.Size = new System.Drawing.Size(121, 21);
            this.cboAConversor.TabIndex = 22;
            this.cboAConversor.SelectedIndexChanged += new System.EventHandler(this.cboAConversor_SelectedIndexChanged);
            // 
            // lblAConversor
            // 
            this.lblAConversor.AutoSize = true;
            this.lblAConversor.Location = new System.Drawing.Point(330, 174);
            this.lblAConversor.Name = "lblAConversor";
            this.lblAConversor.Size = new System.Drawing.Size(17, 13);
            this.lblAConversor.TabIndex = 21;
            this.lblAConversor.Text = "A:";
            this.lblAConversor.Click += new System.EventHandler(this.lblAConversor_Click);
            // 
            // cboDeConversor
            // 
            this.cboDeConversor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeConversor.FormattingEnabled = true;
            this.cboDeConversor.Location = new System.Drawing.Point(437, 117);
            this.cboDeConversor.Name = "cboDeConversor";
            this.cboDeConversor.Size = new System.Drawing.Size(121, 21);
            this.cboDeConversor.TabIndex = 20;
            this.cboDeConversor.SelectedIndexChanged += new System.EventHandler(this.cboDeConversor_SelectedIndexChanged);
            // 
            // lblDeConversor
            // 
            this.lblDeConversor.AutoSize = true;
            this.lblDeConversor.Location = new System.Drawing.Point(330, 125);
            this.lblDeConversor.Name = "lblDeConversor";
            this.lblDeConversor.Size = new System.Drawing.Size(25, 13);
            this.lblDeConversor.TabIndex = 19;
            this.lblDeConversor.Text = "DE:";
            this.lblDeConversor.Click += new System.EventHandler(this.lblDeConversor_Click);
            // 
            // cboTipoConversor
            // 
            this.cboTipoConversor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoConversor.FormattingEnabled = true;
            this.cboTipoConversor.Items.AddRange(new object[] {
            "Moneda",
            "Longitud",
            "Masa",
            "Volumen",
            "Almacenamiento",
            "Tiempo",
            "Area"});
            this.cboTipoConversor.Location = new System.Drawing.Point(447, 56);
            this.cboTipoConversor.Name = "cboTipoConversor";
            this.cboTipoConversor.Size = new System.Drawing.Size(121, 21);
            this.cboTipoConversor.TabIndex = 18;
            this.cboTipoConversor.SelectedIndexChanged += new System.EventHandler(this.cboTipoConversor_SelectedIndexChanged);
            // 
            // lblTipoConversor
            // 
            this.lblTipoConversor.AutoSize = true;
            this.lblTipoConversor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoConversor.Location = new System.Drawing.Point(306, 57);
            this.lblTipoConversor.Name = "lblTipoConversor";
            this.lblTipoConversor.Size = new System.Drawing.Size(54, 20);
            this.lblTipoConversor.TabIndex = 17;
            this.lblTipoConversor.Text = "TIPO:";
            this.lblTipoConversor.Click += new System.EventHandler(this.lblTipoConversor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 450);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.txtCantidadConversor);
            this.Controls.Add(this.lblCantidadConversor);
            this.Controls.Add(this.cboAConversor);
            this.Controls.Add(this.lblAConversor);
            this.Controls.Add(this.cboDeConversor);
            this.Controls.Add(this.lblDeConversor);
            this.Controls.Add(this.cboTipoConversor);
            this.Controls.Add(this.lblTipoConversor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.TextBox txtCantidadConversor;
        private System.Windows.Forms.Label lblCantidadConversor;
        private System.Windows.Forms.ComboBox cboAConversor;
        private System.Windows.Forms.Label lblAConversor;
        private System.Windows.Forms.ComboBox cboDeConversor;
        private System.Windows.Forms.Label lblDeConversor;
        private System.Windows.Forms.ComboBox cboTipoConversor;
        private System.Windows.Forms.Label lblTipoConversor;
    }
}

