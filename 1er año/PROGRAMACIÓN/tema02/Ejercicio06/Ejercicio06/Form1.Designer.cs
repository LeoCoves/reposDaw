namespace Ejercicio06
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
            this.boton = new System.Windows.Forms.Button();
            this.CuadroTexto1 = new System.Windows.Forms.TextBox();
            this.CuadroTexto2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CuadroTexto3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // boton
            // 
            this.boton.Location = new System.Drawing.Point(348, 146);
            this.boton.Name = "boton";
            this.boton.Size = new System.Drawing.Size(75, 23);
            this.boton.TabIndex = 0;
            this.boton.Text = "dividir";
            this.boton.UseVisualStyleBackColor = true;
            this.boton.Click += new System.EventHandler(this.boton_Click);
            // 
            // CuadroTexto1
            // 
            this.CuadroTexto1.Location = new System.Drawing.Point(131, 107);
            this.CuadroTexto1.Name = "CuadroTexto1";
            this.CuadroTexto1.Size = new System.Drawing.Size(100, 20);
            this.CuadroTexto1.TabIndex = 1;
            // 
            // CuadroTexto2
            // 
            this.CuadroTexto2.Location = new System.Drawing.Point(131, 174);
            this.CuadroTexto2.Name = "CuadroTexto2";
            this.CuadroTexto2.Size = new System.Drawing.Size(100, 20);
            this.CuadroTexto2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "numero1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "numero2";
            // 
            // CuadroTexto3
            // 
            this.CuadroTexto3.Location = new System.Drawing.Point(131, 308);
            this.CuadroTexto3.Name = "CuadroTexto3";
            this.CuadroTexto3.Size = new System.Drawing.Size(372, 20);
            this.CuadroTexto3.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "resultado";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(571, 439);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CuadroTexto3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CuadroTexto2);
            this.Controls.Add(this.CuadroTexto1);
            this.Controls.Add(this.boton);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tCuadroTexto1;
        private System.Windows.Forms.TextBox tCuadroTexto2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button boton1;
        private System.Windows.Forms.Button boton;
        private System.Windows.Forms.TextBox CuadroTexto1;
        private System.Windows.Forms.TextBox CuadroTexto2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CuadroTexto3;
        private System.Windows.Forms.Label label5;
    }
}

