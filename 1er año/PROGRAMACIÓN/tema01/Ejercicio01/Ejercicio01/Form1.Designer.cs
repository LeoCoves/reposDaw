namespace Ejercicio01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Boton1 = new System.Windows.Forms.Button();
            this.Boton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Boton1
            // 
            this.Boton1.Location = new System.Drawing.Point(108, 128);
            this.Boton1.Name = "Boton1";
            this.Boton1.Size = new System.Drawing.Size(129, 44);
            this.Boton1.TabIndex = 0;
            this.Boton1.Text = "Boton";
            this.Boton1.UseVisualStyleBackColor = true;
            this.Boton1.Click += new System.EventHandler(this.Boton1_Click);
            // 
            // Boton2
            // 
            this.Boton2.Location = new System.Drawing.Point(134, 210);
            this.Boton2.Name = "Boton2";
            this.Boton2.Size = new System.Drawing.Size(75, 39);
            this.Boton2.TabIndex = 1;
            this.Boton2.Text = "OTRO BOTON";
            this.Boton2.UseVisualStyleBackColor = true;
            this.Boton2.Click += new System.EventHandler(this.Boton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(344, 461);
            this.Controls.Add(this.Boton2);
            this.Controls.Add(this.Boton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Boton1;
        private System.Windows.Forms.Button Boton2;
    }
}

