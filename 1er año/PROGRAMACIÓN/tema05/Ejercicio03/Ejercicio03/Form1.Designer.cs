namespace Ejercicio03
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
            this.btnLeerMostrar = new System.Windows.Forms.Button();
            this.btnMenor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLeerMostrar
            // 
            this.btnLeerMostrar.Location = new System.Drawing.Point(317, 122);
            this.btnLeerMostrar.Name = "btnLeerMostrar";
            this.btnLeerMostrar.Size = new System.Drawing.Size(167, 77);
            this.btnLeerMostrar.TabIndex = 0;
            this.btnLeerMostrar.Text = "Leer y mostrar";
            this.btnLeerMostrar.UseVisualStyleBackColor = true;
            this.btnLeerMostrar.Click += new System.EventHandler(this.btnLeerMostrar_Click);
            // 
            // btnMenor
            // 
            this.btnMenor.Location = new System.Drawing.Point(317, 247);
            this.btnMenor.Name = "btnMenor";
            this.btnMenor.Size = new System.Drawing.Size(167, 76);
            this.btnMenor.TabIndex = 1;
            this.btnMenor.Text = "Mostrar menor";
            this.btnMenor.UseVisualStyleBackColor = true;
            this.btnMenor.Click += new System.EventHandler(this.btnMenor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMenor);
            this.Controls.Add(this.btnLeerMostrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLeerMostrar;
        private System.Windows.Forms.Button btnMenor;
    }
}

