namespace Ejemplo02
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
            this.boton1 = new System.Windows.Forms.Button();
            this.tCuadroTexto1 = new System.Windows.Forms.TextBox();
            this.Text1 = new System.Windows.Forms.Label();
            this.boton2 = new System.Windows.Forms.Button();
            this.Text2 = new System.Windows.Forms.Label();
            this.Text3 = new System.Windows.Forms.Label();
            this.tCuadroTexto2 = new System.Windows.Forms.TextBox();
            this.tCuadroTexto3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // boton1
            // 
            this.boton1.Location = new System.Drawing.Point(523, 105);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(150, 50);
            this.boton1.TabIndex = 0;
            this.boton1.Text = "Suma";
            this.boton1.UseVisualStyleBackColor = true;
            this.boton1.Click += new System.EventHandler(this.bMostrar_Click);
            // 
            // tCuadroTexto1
            // 
            this.tCuadroTexto1.Location = new System.Drawing.Point(176, 105);
            this.tCuadroTexto1.Name = "tCuadroTexto1";
            this.tCuadroTexto1.Size = new System.Drawing.Size(100, 20);
            this.tCuadroTexto1.TabIndex = 1;
            // 
            // Text1
            // 
            this.Text1.AutoSize = true;
            this.Text1.Location = new System.Drawing.Point(98, 108);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(53, 13);
            this.Text1.TabIndex = 2;
            this.Text1.Text = "Numero 1";
            // 
            // boton2
            // 
            this.boton2.Location = new System.Drawing.Point(523, 229);
            this.boton2.Name = "boton2";
            this.boton2.Size = new System.Drawing.Size(150, 50);
            this.boton2.TabIndex = 3;
            this.boton2.Text = "Restar";
            this.boton2.UseVisualStyleBackColor = true;
            this.boton2.Click += new System.EventHandler(this.boton2_Click);
            // 
            // Text2
            // 
            this.Text2.AutoSize = true;
            this.Text2.Location = new System.Drawing.Point(101, 159);
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(53, 13);
            this.Text2.TabIndex = 4;
            this.Text2.Text = "Numero 2";
            // 
            // Text3
            // 
            this.Text3.AutoSize = true;
            this.Text3.Location = new System.Drawing.Point(114, 255);
            this.Text3.Name = "Text3";
            this.Text3.Size = new System.Drawing.Size(55, 13);
            this.Text3.TabIndex = 5;
            this.Text3.Text = "Resultado";
            // 
            // tCuadroTexto2
            // 
            this.tCuadroTexto2.Location = new System.Drawing.Point(176, 156);
            this.tCuadroTexto2.Name = "tCuadroTexto2";
            this.tCuadroTexto2.Size = new System.Drawing.Size(100, 20);
            this.tCuadroTexto2.TabIndex = 6;
            // 
            // tCuadroTexto3
            // 
            this.tCuadroTexto3.Location = new System.Drawing.Point(196, 252);
            this.tCuadroTexto3.Name = "tCuadroTexto3";
            this.tCuadroTexto3.Size = new System.Drawing.Size(100, 20);
            this.tCuadroTexto3.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tCuadroTexto3);
            this.Controls.Add(this.tCuadroTexto2);
            this.Controls.Add(this.Text3);
            this.Controls.Add(this.Text2);
            this.Controls.Add(this.boton2);
            this.Controls.Add(this.Text1);
            this.Controls.Add(this.tCuadroTexto1);
            this.Controls.Add(this.boton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boton1;
        private System.Windows.Forms.TextBox tCuadroTexto1;
        private System.Windows.Forms.Label Text1;
        private System.Windows.Forms.Button boton2;
        private System.Windows.Forms.Label Text2;
        private System.Windows.Forms.Label Text3;
        private System.Windows.Forms.TextBox tCuadroTexto2;
        private System.Windows.Forms.TextBox tCuadroTexto3;
    }
}

