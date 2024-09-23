namespace Ejercicio13
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
            this.tCuadroTexto1 = new System.Windows.Forms.TextBox();
            this.tCuadroTexto2 = new System.Windows.Forms.TextBox();
            this.tCuadroTexto3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tCuadroTexto4 = new System.Windows.Forms.TextBox();
            this.tCuadroTexto5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tCuadroTexto1
            // 
            this.tCuadroTexto1.Location = new System.Drawing.Point(159, 84);
            this.tCuadroTexto1.Name = "tCuadroTexto1";
            this.tCuadroTexto1.Size = new System.Drawing.Size(100, 20);
            this.tCuadroTexto1.TabIndex = 0;
            // 
            // tCuadroTexto2
            // 
            this.tCuadroTexto2.Location = new System.Drawing.Point(159, 129);
            this.tCuadroTexto2.Name = "tCuadroTexto2";
            this.tCuadroTexto2.Size = new System.Drawing.Size(100, 20);
            this.tCuadroTexto2.TabIndex = 1;
            // 
            // tCuadroTexto3
            // 
            this.tCuadroTexto3.Location = new System.Drawing.Point(159, 176);
            this.tCuadroTexto3.Name = "tCuadroTexto3";
            this.tCuadroTexto3.Size = new System.Drawing.Size(100, 20);
            this.tCuadroTexto3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Horas trabajadas mensuales";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Horas extras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Paga por hora";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(408, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "CALCULAR NÓMINA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tCuadroTexto4
            // 
            this.tCuadroTexto4.Location = new System.Drawing.Point(408, 283);
            this.tCuadroTexto4.Name = "tCuadroTexto4";
            this.tCuadroTexto4.Size = new System.Drawing.Size(169, 20);
            this.tCuadroTexto4.TabIndex = 7;
            // 
            // tCuadroTexto5
            // 
            this.tCuadroTexto5.Location = new System.Drawing.Point(408, 356);
            this.tCuadroTexto5.Name = "tCuadroTexto5";
            this.tCuadroTexto5.Size = new System.Drawing.Size(169, 20);
            this.tCuadroTexto5.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(430, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nómina sin retenciones";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(430, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nómina con retenciones";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tCuadroTexto5);
            this.Controls.Add(this.tCuadroTexto4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tCuadroTexto3);
            this.Controls.Add(this.tCuadroTexto2);
            this.Controls.Add(this.tCuadroTexto1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tCuadroTexto1;
        private System.Windows.Forms.TextBox tCuadroTexto2;
        private System.Windows.Forms.TextBox tCuadroTexto3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tCuadroTexto4;
        private System.Windows.Forms.TextBox tCuadroTexto5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

