﻿namespace Ejercicio03
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
            this.tCuadroTexto1 = new System.Windows.Forms.TextBox();
            this.Boton1 = new System.Windows.Forms.Button();
            this.Boton2 = new System.Windows.Forms.Button();
            this.Boton3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Botón pulsado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tCuadroTexto1
            // 
            this.tCuadroTexto1.Location = new System.Drawing.Point(317, 90);
            this.tCuadroTexto1.Name = "tCuadroTexto1";
            this.tCuadroTexto1.Size = new System.Drawing.Size(300, 20);
            this.tCuadroTexto1.TabIndex = 1;
            // 
            // Boton1
            // 
            this.Boton1.Location = new System.Drawing.Point(317, 169);
            this.Boton1.Name = "Boton1";
            this.Boton1.Size = new System.Drawing.Size(75, 23);
            this.Boton1.TabIndex = 2;
            this.Boton1.Text = "Boton 1";
            this.Boton1.UseVisualStyleBackColor = true;
            this.Boton1.Click += new System.EventHandler(this.Boton1_Click);
            // 
            // Boton2
            // 
            this.Boton2.Location = new System.Drawing.Point(317, 243);
            this.Boton2.Name = "Boton2";
            this.Boton2.Size = new System.Drawing.Size(75, 23);
            this.Boton2.TabIndex = 3;
            this.Boton2.Text = "Boton 2";
            this.Boton2.UseVisualStyleBackColor = true;
            this.Boton2.Click += new System.EventHandler(this.Boton2_Click);
            // 
            // Boton3
            // 
            this.Boton3.Location = new System.Drawing.Point(504, 204);
            this.Boton3.Name = "Boton3";
            this.Boton3.Size = new System.Drawing.Size(105, 23);
            this.Boton3.TabIndex = 4;
            this.Boton3.Text = "Borrar Texto";
            this.Boton3.UseVisualStyleBackColor = true;
            this.Boton3.Click += new System.EventHandler(this.Boton3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Boton3);
            this.Controls.Add(this.Boton2);
            this.Controls.Add(this.Boton1);
            this.Controls.Add(this.tCuadroTexto1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tCuadroTexto1;
        private System.Windows.Forms.Button Boton1;
        private System.Windows.Forms.Button Boton2;
        private System.Windows.Forms.Button Boton3;
    }
}

