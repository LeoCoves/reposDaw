namespace Ejercicio02
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
            this.TCuadroTexto = new System.Windows.Forms.TextBox();
            this.Texto1 = new System.Windows.Forms.Label();
            this.Boton1 = new System.Windows.Forms.Button();
            this.Boton2 = new System.Windows.Forms.Button();
            this.Boton3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TCuadroTexto
            // 
            this.TCuadroTexto.Location = new System.Drawing.Point(99, 122);
            this.TCuadroTexto.Name = "TCuadroTexto";
            this.TCuadroTexto.Size = new System.Drawing.Size(400, 20);
            this.TCuadroTexto.TabIndex = 0;
            this.TCuadroTexto.Text = "Escriba aquí";
            // 
            // Texto1
            // 
            this.Texto1.AutoSize = true;
            this.Texto1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Texto1.Location = new System.Drawing.Point(180, 59);
            this.Texto1.Name = "Texto1";
            this.Texto1.Size = new System.Drawing.Size(225, 30);
            this.Texto1.TabIndex = 1;
            this.Texto1.Text = "Mi primer formulario";
            // 
            // Boton1
            // 
            this.Boton1.Location = new System.Drawing.Point(99, 183);
            this.Boton1.Name = "Boton1";
            this.Boton1.Size = new System.Drawing.Size(400, 40);
            this.Boton1.TabIndex = 2;
            this.Boton1.Text = "Muestre el contenido del cuadro de texto";
            this.Boton1.UseVisualStyleBackColor = true;
            this.Boton1.Click += new System.EventHandler(this.Boton1_Click);
            // 
            // Boton2
            // 
            this.Boton2.Location = new System.Drawing.Point(99, 267);
            this.Boton2.Name = "Boton2";
            this.Boton2.Size = new System.Drawing.Size(400, 40);
            this.Boton2.TabIndex = 3;
            this.Boton2.Text = "Cambia el color del formulario";
            this.Boton2.UseVisualStyleBackColor = true;
            this.Boton2.Click += new System.EventHandler(this.Boton2_Click);
            // 
            // Boton3
            // 
            this.Boton3.Location = new System.Drawing.Point(99, 349);
            this.Boton3.Name = "Boton3";
            this.Boton3.Size = new System.Drawing.Size(400, 40);
            this.Boton3.TabIndex = 4;
            this.Boton3.Text = "Cambia el color del texto del cuadro";
            this.Boton3.UseVisualStyleBackColor = true;
            this.Boton3.Click += new System.EventHandler(this.Boton3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.Boton3);
            this.Controls.Add(this.Boton2);
            this.Controls.Add(this.Boton1);
            this.Controls.Add(this.Texto1);
            this.Controls.Add(this.TCuadroTexto);
            this.Name = "Form1";
            this.Text = "Ejercicio02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TCuadroTexto;
        private System.Windows.Forms.Label Texto1;
        private System.Windows.Forms.Button Boton1;
        private System.Windows.Forms.Button Boton2;
        private System.Windows.Forms.Button Boton3;
    }
}

