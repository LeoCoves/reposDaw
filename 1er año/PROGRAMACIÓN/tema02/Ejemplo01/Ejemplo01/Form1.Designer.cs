namespace Ejemplo01
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
            this.Nombre = new System.Windows.Forms.Label();
            this.Apellido = new System.Windows.Forms.Label();
            this.tCuadroTexto1 = new System.Windows.Forms.TextBox();
            this.tCuadroTexto2 = new System.Windows.Forms.TextBox();
            this.bMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(275, 103);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.AutoSize = true;
            this.Apellido.Location = new System.Drawing.Point(275, 152);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(49, 13);
            this.Apellido.TabIndex = 1;
            this.Apellido.Text = "Apellidos";
            // 
            // tCuadroTexto1
            // 
            this.tCuadroTexto1.Location = new System.Drawing.Point(357, 100);
            this.tCuadroTexto1.Name = "tCuadroTexto1";
            this.tCuadroTexto1.Size = new System.Drawing.Size(100, 20);
            this.tCuadroTexto1.TabIndex = 2;
            // 
            // tCuadroTexto2
            // 
            this.tCuadroTexto2.Location = new System.Drawing.Point(357, 149);
            this.tCuadroTexto2.Name = "tCuadroTexto2";
            this.tCuadroTexto2.Size = new System.Drawing.Size(100, 20);
            this.tCuadroTexto2.TabIndex = 3;
            // 
            // bMostrar
            // 
            this.bMostrar.Location = new System.Drawing.Point(303, 237);
            this.bMostrar.Name = "bMostrar";
            this.bMostrar.Size = new System.Drawing.Size(130, 60);
            this.bMostrar.TabIndex = 4;
            this.bMostrar.Text = "Mostrar Nombre Completo";
            this.bMostrar.UseVisualStyleBackColor = true;
            this.bMostrar.Click += new System.EventHandler(this.bMostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bMostrar);
            this.Controls.Add(this.tCuadroTexto2);
            this.Controls.Add(this.tCuadroTexto1);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.Nombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Apellido;
        private System.Windows.Forms.TextBox tCuadroTexto1;
        private System.Windows.Forms.TextBox tCuadroTexto2;
        private System.Windows.Forms.Button bMostrar;
    }
}

