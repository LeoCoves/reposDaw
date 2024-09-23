namespace Ejercicio14bien
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
            this.btnfor = new System.Windows.Forms.Button();
            this.btnwhile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnfor
            // 
            this.btnfor.Location = new System.Drawing.Point(316, 115);
            this.btnfor.Name = "btnfor";
            this.btnfor.Size = new System.Drawing.Size(167, 54);
            this.btnfor.TabIndex = 0;
            this.btnfor.Text = "Suma FOR 1-10";
            this.btnfor.UseVisualStyleBackColor = true;
            this.btnfor.Click += new System.EventHandler(this.btnfor_Click);
            // 
            // btnwhile
            // 
            this.btnwhile.Location = new System.Drawing.Point(316, 263);
            this.btnwhile.Name = "btnwhile";
            this.btnwhile.Size = new System.Drawing.Size(167, 52);
            this.btnwhile.TabIndex = 1;
            this.btnwhile.Text = "Suma WHILE 1-10";
            this.btnwhile.UseVisualStyleBackColor = true;
            this.btnwhile.Click += new System.EventHandler(this.btnwhile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnwhile);
            this.Controls.Add(this.btnfor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnfor;
        private System.Windows.Forms.Button btnwhile;
    }
}

