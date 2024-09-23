namespace Ejercicio09
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
            this.tCuadroTexto3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.boton1 = new System.Windows.Forms.Button();
            this.boton2 = new System.Windows.Forms.Button();
            this.boton3 = new System.Windows.Forms.Button();
            this.boton4 = new System.Windows.Forms.Button();
            this.boton5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tCuadroTexto1
            // 
            this.tCuadroTexto1.Location = new System.Drawing.Point(210, 128);
            this.tCuadroTexto1.Name = "tCuadroTexto1";
            this.tCuadroTexto1.Size = new System.Drawing.Size(100, 20);
            this.tCuadroTexto1.TabIndex = 0;
            // 
            // tCuadroTexto2
            // 
            this.tCuadroTexto2.Location = new System.Drawing.Point(210, 177);
            this.tCuadroTexto2.Name = "tCuadroTexto2";
            this.tCuadroTexto2.Size = new System.Drawing.Size(100, 20);
            this.tCuadroTexto2.TabIndex = 1;
            // 
            // tCuadroTexto3
            // 
            this.tCuadroTexto3.Location = new System.Drawing.Point(210, 307);
            this.tCuadroTexto3.Name = "tCuadroTexto3";
            this.tCuadroTexto3.Size = new System.Drawing.Size(100, 20);
            this.tCuadroTexto3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numero 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultado";
            // 
            // boton1
            // 
            this.boton1.Location = new System.Drawing.Point(481, 124);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(75, 23);
            this.boton1.TabIndex = 6;
            this.boton1.Text = "+";
            this.boton1.UseVisualStyleBackColor = true;
            this.boton1.Click += new System.EventHandler(this.boton1_Click);
            // 
            // boton2
            // 
            this.boton2.Location = new System.Drawing.Point(616, 125);
            this.boton2.Name = "boton2";
            this.boton2.Size = new System.Drawing.Size(75, 23);
            this.boton2.TabIndex = 7;
            this.boton2.Text = "-";
            this.boton2.UseVisualStyleBackColor = true;
            this.boton2.Click += new System.EventHandler(this.boton2_Click);
            // 
            // boton3
            // 
            this.boton3.Location = new System.Drawing.Point(481, 198);
            this.boton3.Name = "boton3";
            this.boton3.Size = new System.Drawing.Size(75, 23);
            this.boton3.TabIndex = 8;
            this.boton3.Text = "*";
            this.boton3.UseVisualStyleBackColor = true;
            this.boton3.Click += new System.EventHandler(this.boton3_Click);
            // 
            // boton4
            // 
            this.boton4.Location = new System.Drawing.Point(616, 198);
            this.boton4.Name = "boton4";
            this.boton4.Size = new System.Drawing.Size(75, 23);
            this.boton4.TabIndex = 9;
            this.boton4.Text = "/";
            this.boton4.UseVisualStyleBackColor = true;
            this.boton4.Click += new System.EventHandler(this.boton4_Click);
            // 
            // boton5
            // 
            this.boton5.Location = new System.Drawing.Point(547, 271);
            this.boton5.Name = "boton5";
            this.boton5.Size = new System.Drawing.Size(75, 23);
            this.boton5.TabIndex = 10;
            this.boton5.Text = "%";
            this.boton5.UseVisualStyleBackColor = true;
            this.boton5.Click += new System.EventHandler(this.boton5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boton5);
            this.Controls.Add(this.boton4);
            this.Controls.Add(this.boton3);
            this.Controls.Add(this.boton2);
            this.Controls.Add(this.boton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tCuadroTexto3);
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
        private System.Windows.Forms.TextBox tCuadroTexto3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button boton1;
        private System.Windows.Forms.Button boton2;
        private System.Windows.Forms.Button boton3;
        private System.Windows.Forms.Button boton4;
        private System.Windows.Forms.Button boton5;
    }
}

