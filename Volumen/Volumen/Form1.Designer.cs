namespace Volumen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn1Convertir = new System.Windows.Forms.Button();
            this.btn2ConvertirVol = new System.Windows.Forms.Button();
            this.cbo1ConvertirVol = new System.Windows.Forms.ComboBox();
            this.cbo2ConvertidoVol = new System.Windows.Forms.ComboBox();
            this.txt1CantidadVol = new System.Windows.Forms.TextBox();
            this.txt2ResultadoVol = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversor de Volumen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingese la canidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(492, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(191, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Equivale A:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(154, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Convertir de:";
            // 
            // btn1Convertir
            // 
            this.btn1Convertir.Location = new System.Drawing.Point(251, 333);
            this.btn1Convertir.Name = "btn1Convertir";
            this.btn1Convertir.Size = new System.Drawing.Size(99, 36);
            this.btn1Convertir.TabIndex = 5;
            this.btn1Convertir.Text = "Convertir";
            this.btn1Convertir.UseVisualStyleBackColor = true;
            this.btn1Convertir.Click += new System.EventHandler(this.btn1Convertir_Click);
            // 
            // btn2ConvertirVol
            // 
            this.btn2ConvertirVol.Location = new System.Drawing.Point(446, 333);
            this.btn2ConvertirVol.Name = "btn2ConvertirVol";
            this.btn2ConvertirVol.Size = new System.Drawing.Size(98, 36);
            this.btn2ConvertirVol.TabIndex = 6;
            this.btn2ConvertirVol.Text = "Salir";
            this.btn2ConvertirVol.UseVisualStyleBackColor = true;
            this.btn2ConvertirVol.Click += new System.EventHandler(this.btn2ConvertirVol_Click_1);
            // 
            // cbo1ConvertirVol
            // 
            this.cbo1ConvertirVol.FormattingEnabled = true;
            this.cbo1ConvertirVol.Items.AddRange(new object[] {
            "Litro",
            "Mililitro",
            "Galón imperial",
            "Cuarto imperial",
            "Taza imperial",
            "Onza liquida imperial",
            "Cucharada imperial",
            "Cucharadita imperial",
            "Pie cúbico"});
            this.cbo1ConvertirVol.Location = new System.Drawing.Point(322, 195);
            this.cbo1ConvertirVol.Name = "cbo1ConvertirVol";
            this.cbo1ConvertirVol.Size = new System.Drawing.Size(121, 21);
            this.cbo1ConvertirVol.TabIndex = 7;
            // 
            // cbo2ConvertidoVol
            // 
            this.cbo2ConvertidoVol.FormattingEnabled = true;
            this.cbo2ConvertidoVol.Items.AddRange(new object[] {
            "Litro",
            "Mililitro",
            "Galón imperial",
            "Cuarto imperial",
            "Taza imperial",
            "Onza liquida imperial",
            "Cucharada imperial",
            "Cucharadita imperial",
            "Pie cúbica"});
            this.cbo2ConvertidoVol.Location = new System.Drawing.Point(553, 195);
            this.cbo2ConvertidoVol.Name = "cbo2ConvertidoVol";
            this.cbo2ConvertidoVol.Size = new System.Drawing.Size(121, 21);
            this.cbo2ConvertidoVol.TabIndex = 8;
            // 
            // txt1CantidadVol
            // 
            this.txt1CantidadVol.Location = new System.Drawing.Point(345, 119);
            this.txt1CantidadVol.Name = "txt1CantidadVol";
            this.txt1CantidadVol.Size = new System.Drawing.Size(100, 20);
            this.txt1CantidadVol.TabIndex = 9;
            this.txt1CantidadVol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt2ResultadoVol
            // 
            this.txt2ResultadoVol.Location = new System.Drawing.Point(345, 263);
            this.txt2ResultadoVol.Name = "txt2ResultadoVol";
            this.txt2ResultadoVol.Size = new System.Drawing.Size(100, 20);
            this.txt2ResultadoVol.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt2ResultadoVol);
            this.Controls.Add(this.txt1CantidadVol);
            this.Controls.Add(this.cbo2ConvertidoVol);
            this.Controls.Add(this.cbo1ConvertirVol);
            this.Controls.Add(this.btn2ConvertirVol);
            this.Controls.Add(this.btn1Convertir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn1Convertir;
        private System.Windows.Forms.Button btn2ConvertirVol;
        private System.Windows.Forms.ComboBox cbo1ConvertirVol;
        private System.Windows.Forms.ComboBox cbo2ConvertidoVol;
        private System.Windows.Forms.TextBox txt1CantidadVol;
        private System.Windows.Forms.TextBox txt2ResultadoVol;
    }
}

