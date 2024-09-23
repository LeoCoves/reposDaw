namespace Ejercicio07
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boton1 = new System.Windows.Forms.Button();
            this.tCuadroTexto2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tCuadroTexto1
            // 
            this.tCuadroTexto1.Location = new System.Drawing.Point(294, 107);
            this.tCuadroTexto1.Name = "tCuadroTexto1";
            this.tCuadroTexto1.Size = new System.Drawing.Size(100, 20);
            this.tCuadroTexto1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "altura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "cms";
            // 
            // boton1
            // 
            this.boton1.Location = new System.Drawing.Point(574, 186);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(75, 23);
            this.boton1.TabIndex = 3;
            this.boton1.Text = "Resultado";
            this.boton1.UseVisualStyleBackColor = true;
            this.boton1.Click += new System.EventHandler(this.boton1_Click);
            // 
            // tCuadroTexto2
            // 
            this.tCuadroTexto2.Location = new System.Drawing.Point(202, 330);
            this.tCuadroTexto2.Name = "tCuadroTexto2";
            this.tCuadroTexto2.Size = new System.Drawing.Size(272, 20);
            this.tCuadroTexto2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tCuadroTexto2);
            this.Controls.Add(this.boton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tCuadroTexto1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tCuadroTexto1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button boton1;
        private System.Windows.Forms.TextBox tCuadroTexto2;
    }
}

