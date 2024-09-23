namespace Ejercicio15
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
            this.btnMayorMenor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMayorMenor
            // 
            this.btnMayorMenor.Location = new System.Drawing.Point(272, 188);
            this.btnMayorMenor.Name = "btnMayorMenor";
            this.btnMayorMenor.Size = new System.Drawing.Size(218, 88);
            this.btnMayorMenor.TabIndex = 0;
            this.btnMayorMenor.Text = "Calcular Mayor y Menor";
            this.btnMayorMenor.UseVisualStyleBackColor = true;
            this.btnMayorMenor.Click += new System.EventHandler(this.btnMayorMenor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMayorMenor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMayorMenor;
    }
}

