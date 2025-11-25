namespace Vectores_C_
{
    partial class vectores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.lblMenor = new System.Windows.Forms.Label();
            this.lblMayor = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblSuma = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(342, 53);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(100, 20);
            this.txtSerie.TabIndex = 11;
            this.txtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMenor
            // 
            this.lblMenor.AutoSize = true;
            this.lblMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenor.Location = new System.Drawing.Point(180, 264);
            this.lblMenor.Name = "lblMenor";
            this.lblMenor.Size = new System.Drawing.Size(64, 20);
            this.lblMenor.TabIndex = 6;
            this.lblMenor.Text = "Menor:";
            // 
            // lblMayor
            // 
            this.lblMayor.AutoSize = true;
            this.lblMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMayor.Location = new System.Drawing.Point(183, 229);
            this.lblMayor.Name = "lblMayor";
            this.lblMayor.Size = new System.Drawing.Size(62, 20);
            this.lblMayor.TabIndex = 7;
            this.lblMayor.Text = "Mayor:";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio.Location = new System.Drawing.Point(158, 189);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(84, 20);
            this.lblPromedio.TabIndex = 8;
            this.lblPromedio.Text = "Promedio";
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuma.Location = new System.Drawing.Point(183, 148);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(51, 18);
            this.lblSuma.TabIndex = 9;
            this.lblSuma.Text = "Suma";
            this.lblSuma.Click += new System.EventHandler(this.lblSuma_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Serie de numeros";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(276, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 55);
            this.button2.TabIndex = 5;
            this.button2.Text = "Salir?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(539, 216);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(105, 68);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular:";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // vectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.lblMenor);
            this.Controls.Add(this.lblMayor);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCalcular);
            this.Name = "vectores";
            this.Text = "vectores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label lblMenor;
        private System.Windows.Forms.Label lblMayor;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCalcular;
    }
}