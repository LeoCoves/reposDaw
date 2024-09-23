namespace Ejercicio10
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boton1 = new System.Windows.Forms.Button();
            this.boton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tCuadroTexto1
            // 
            this.tCuadroTexto1.Location = new System.Drawing.Point(334, 70);
            this.tCuadroTexto1.Name = "tCuadroTexto1";
            this.tCuadroTexto1.Size = new System.Drawing.Size(100, 20);
            this.tCuadroTexto1.TabIndex = 0;
            // 
            // tCuadroTexto2
            // 
            this.tCuadroTexto2.Location = new System.Drawing.Point(334, 146);
            this.tCuadroTexto2.Name = "tCuadroTexto2";
            this.tCuadroTexto2.Size = new System.Drawing.Size(100, 20);
            this.tCuadroTexto2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Euros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pesetas";
            // 
            // boton1
            // 
            this.boton1.Location = new System.Drawing.Point(312, 235);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(150, 50);
            this.boton1.TabIndex = 4;
            this.boton1.Text = "Euros a Pesetas";
            this.boton1.UseVisualStyleBackColor = true;
            this.boton1.Click += new System.EventHandler(this.boton1_Click);
            // 
            // boton2
            // 
            this.boton2.Location = new System.Drawing.Point(312, 315);
            this.boton2.Name = "boton2";
            this.boton2.Size = new System.Drawing.Size(150, 50);
            this.boton2.TabIndex = 5;
            this.boton2.Text = "Pesetas a Euros";
            this.boton2.UseVisualStyleBackColor = true;
            this.boton2.Click += new System.EventHandler(this.boton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boton2);
            this.Controls.Add(this.boton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button boton1;
        private System.Windows.Forms.Button boton2;
    }
}

