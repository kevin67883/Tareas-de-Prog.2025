namespace Factorial
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
            this.btnCalcular2 = new System.Windows.Forms.Button();
            this.cboOpciones = new System.Windows.Forms.ComboBox();
            this.grbOpociones = new System.Windows.Forms.GroupBox();
            this.optPrimo = new System.Windows.Forms.RadioButton();
            this.optModulo = new System.Windows.Forms.RadioButton();
            this.optFactorial = new System.Windows.Forms.RadioButton();
            this.optProcentaje = new System.Windows.Forms.RadioButton();
            this.optExponente = new System.Windows.Forms.RadioButton();
            this.optDivicion = new System.Windows.Forms.RadioButton();
            this.optMultiplicacion = new System.Windows.Forms.RadioButton();
            this.optResta = new System.Windows.Forms.RadioButton();
            this.optSuma = new System.Windows.Forms.RadioButton();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.lblnum2 = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.lblnum1 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.grbOpociones.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalcular2
            // 
            this.btnCalcular2.Location = new System.Drawing.Point(132, 236);
            this.btnCalcular2.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalcular2.Name = "btnCalcular2";
            this.btnCalcular2.Size = new System.Drawing.Size(82, 45);
            this.btnCalcular2.TabIndex = 17;
            this.btnCalcular2.Text = "calcular";
            this.btnCalcular2.UseVisualStyleBackColor = true;
            this.btnCalcular2.Click += new System.EventHandler(this.btnCalcular2_Click);
            // 
            // cboOpciones
            // 
            this.cboOpciones.FormattingEnabled = true;
            this.cboOpciones.Items.AddRange(new object[] {
            "suma",
            "resta",
            "multiplicacion",
            "divicion",
            "primo",
            "factorial"});
            this.cboOpciones.Location = new System.Drawing.Point(538, 60);
            this.cboOpciones.Margin = new System.Windows.Forms.Padding(2);
            this.cboOpciones.Name = "cboOpciones";
            this.cboOpciones.Size = new System.Drawing.Size(92, 21);
            this.cboOpciones.TabIndex = 16;
            // 
            // grbOpociones
            // 
            this.grbOpociones.Controls.Add(this.optPrimo);
            this.grbOpociones.Controls.Add(this.optModulo);
            this.grbOpociones.Controls.Add(this.optFactorial);
            this.grbOpociones.Controls.Add(this.optProcentaje);
            this.grbOpociones.Controls.Add(this.optExponente);
            this.grbOpociones.Controls.Add(this.optDivicion);
            this.grbOpociones.Controls.Add(this.optMultiplicacion);
            this.grbOpociones.Controls.Add(this.optResta);
            this.grbOpociones.Controls.Add(this.optSuma);
            this.grbOpociones.Location = new System.Drawing.Point(301, 39);
            this.grbOpociones.Margin = new System.Windows.Forms.Padding(2);
            this.grbOpociones.Name = "grbOpociones";
            this.grbOpociones.Padding = new System.Windows.Forms.Padding(2);
            this.grbOpociones.Size = new System.Drawing.Size(150, 235);
            this.grbOpociones.TabIndex = 15;
            this.grbOpociones.TabStop = false;
            this.grbOpociones.Text = "Opciones";
            // 
            // optPrimo
            // 
            this.optPrimo.AutoSize = true;
            this.optPrimo.Location = new System.Drawing.Point(7, 186);
            this.optPrimo.Margin = new System.Windows.Forms.Padding(2);
            this.optPrimo.Name = "optPrimo";
            this.optPrimo.Size = new System.Drawing.Size(50, 17);
            this.optPrimo.TabIndex = 7;
            this.optPrimo.TabStop = true;
            this.optPrimo.Text = "primo";
            this.optPrimo.UseVisualStyleBackColor = true;
            // 
            // optModulo
            // 
            this.optModulo.AutoSize = true;
            this.optModulo.Location = new System.Drawing.Point(4, 165);
            this.optModulo.Margin = new System.Windows.Forms.Padding(2);
            this.optModulo.Name = "optModulo";
            this.optModulo.Size = new System.Drawing.Size(59, 17);
            this.optModulo.TabIndex = 7;
            this.optModulo.TabStop = true;
            this.optModulo.Text = "modulo";
            this.optModulo.UseVisualStyleBackColor = true;
            // 
            // optFactorial
            // 
            this.optFactorial.AutoSize = true;
            this.optFactorial.Location = new System.Drawing.Point(4, 144);
            this.optFactorial.Margin = new System.Windows.Forms.Padding(2);
            this.optFactorial.Name = "optFactorial";
            this.optFactorial.Size = new System.Drawing.Size(62, 17);
            this.optFactorial.TabIndex = 6;
            this.optFactorial.TabStop = true;
            this.optFactorial.Text = "factorial";
            this.optFactorial.UseVisualStyleBackColor = true;
            // 
            // optProcentaje
            // 
            this.optProcentaje.AutoSize = true;
            this.optProcentaje.Location = new System.Drawing.Point(4, 123);
            this.optProcentaje.Margin = new System.Windows.Forms.Padding(2);
            this.optProcentaje.Name = "optProcentaje";
            this.optProcentaje.Size = new System.Drawing.Size(75, 17);
            this.optProcentaje.TabIndex = 5;
            this.optProcentaje.TabStop = true;
            this.optProcentaje.Text = "procentaje";
            this.optProcentaje.UseVisualStyleBackColor = true;
            // 
            // optExponente
            // 
            this.optExponente.AutoSize = true;
            this.optExponente.Location = new System.Drawing.Point(4, 102);
            this.optExponente.Margin = new System.Windows.Forms.Padding(2);
            this.optExponente.Name = "optExponente";
            this.optExponente.Size = new System.Drawing.Size(76, 17);
            this.optExponente.TabIndex = 4;
            this.optExponente.TabStop = true;
            this.optExponente.Text = "Exponente";
            this.optExponente.UseVisualStyleBackColor = true;
            // 
            // optDivicion
            // 
            this.optDivicion.AutoSize = true;
            this.optDivicion.Location = new System.Drawing.Point(4, 80);
            this.optDivicion.Margin = new System.Windows.Forms.Padding(2);
            this.optDivicion.Name = "optDivicion";
            this.optDivicion.Size = new System.Drawing.Size(62, 17);
            this.optDivicion.TabIndex = 3;
            this.optDivicion.TabStop = true;
            this.optDivicion.Text = "Division";
            this.optDivicion.UseVisualStyleBackColor = true;
            // 
            // optMultiplicacion
            // 
            this.optMultiplicacion.AutoSize = true;
            this.optMultiplicacion.Location = new System.Drawing.Point(4, 59);
            this.optMultiplicacion.Margin = new System.Windows.Forms.Padding(2);
            this.optMultiplicacion.Name = "optMultiplicacion";
            this.optMultiplicacion.Size = new System.Drawing.Size(88, 17);
            this.optMultiplicacion.TabIndex = 2;
            this.optMultiplicacion.TabStop = true;
            this.optMultiplicacion.Text = "multiplicacion";
            this.optMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // optResta
            // 
            this.optResta.AutoSize = true;
            this.optResta.Location = new System.Drawing.Point(4, 38);
            this.optResta.Margin = new System.Windows.Forms.Padding(2);
            this.optResta.Name = "optResta";
            this.optResta.Size = new System.Drawing.Size(53, 17);
            this.optResta.TabIndex = 1;
            this.optResta.TabStop = true;
            this.optResta.Text = "Resta";
            this.optResta.UseVisualStyleBackColor = true;
            // 
            // optSuma
            // 
            this.optSuma.AutoSize = true;
            this.optSuma.Location = new System.Drawing.Point(4, 17);
            this.optSuma.Margin = new System.Windows.Forms.Padding(2);
            this.optSuma.Name = "optSuma";
            this.optSuma.Size = new System.Drawing.Size(52, 17);
            this.optSuma.TabIndex = 0;
            this.optSuma.TabStop = true;
            this.optSuma.Text = "Suma";
            this.optSuma.UseVisualStyleBackColor = true;
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Location = new System.Drawing.Point(104, 152);
            this.lblRespuesta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(56, 13);
            this.lblRespuesta.TabIndex = 14;
            this.lblRespuesta.Text = "respuesta:";
            // 
            // lblnum2
            // 
            this.lblnum2.AutoSize = true;
            this.lblnum2.Location = new System.Drawing.Point(104, 109);
            this.lblnum2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnum2.Name = "lblnum2";
            this.lblnum2.Size = new System.Drawing.Size(36, 13);
            this.lblnum2.TabIndex = 13;
            this.lblnum2.Text = "num2:";
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(151, 104);
            this.txtNum2.Margin = new System.Windows.Forms.Padding(2);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(104, 20);
            this.txtNum2.TabIndex = 12;
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(536, 242);
            this.btnCapturar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(94, 32);
            this.btnCapturar.TabIndex = 11;
            this.btnCapturar.Text = "Calcular";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.Location = new System.Drawing.Point(104, 73);
            this.lblnum1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(36, 13);
            this.lblnum1.TabIndex = 10;
            this.lblnum1.Text = "num1:";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(151, 68);
            this.txtNum1.Margin = new System.Windows.Forms.Padding(2);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(104, 20);
            this.txtNum1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular2);
            this.Controls.Add(this.cboOpciones);
            this.Controls.Add(this.grbOpociones);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.lblnum2);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.lblnum1);
            this.Controls.Add(this.txtNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.grbOpociones.ResumeLayout(false);
            this.grbOpociones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular2;
        private System.Windows.Forms.ComboBox cboOpciones;
        private System.Windows.Forms.GroupBox grbOpociones;
        private System.Windows.Forms.RadioButton optModulo;
        private System.Windows.Forms.RadioButton optFactorial;
        private System.Windows.Forms.RadioButton optProcentaje;
        private System.Windows.Forms.RadioButton optExponente;
        private System.Windows.Forms.RadioButton optDivicion;
        private System.Windows.Forms.RadioButton optMultiplicacion;
        private System.Windows.Forms.RadioButton optResta;
        private System.Windows.Forms.RadioButton optSuma;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.Label lblnum2;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.RadioButton optPrimo;
    }
}

