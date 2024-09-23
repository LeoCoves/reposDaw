namespace EjAmpliacion1
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblFigura1 = new System.Windows.Forms.Label();
            this.lblFigura2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(198, 211);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(124, 51);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Figura 1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(438, 211);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(126, 51);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "Figura 2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(329, 148);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 2;
            // 
            // lblFigura1
            // 
            this.lblFigura1.AutoSize = true;
            this.lblFigura1.Location = new System.Drawing.Point(198, 295);
            this.lblFigura1.Name = "lblFigura1";
            this.lblFigura1.Size = new System.Drawing.Size(10, 13);
            this.lblFigura1.TabIndex = 3;
            this.lblFigura1.Text = ".";
            // 
            // lblFigura2
            // 
            this.lblFigura2.AutoSize = true;
            this.lblFigura2.Location = new System.Drawing.Point(438, 294);
            this.lblFigura2.Name = "lblFigura2";
            this.lblFigura2.Size = new System.Drawing.Size(10, 13);
            this.lblFigura2.TabIndex = 4;
            this.lblFigura2.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFigura2);
            this.Controls.Add(this.lblFigura1);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblFigura1;
        private System.Windows.Forms.Label lblFigura2;
    }
}

