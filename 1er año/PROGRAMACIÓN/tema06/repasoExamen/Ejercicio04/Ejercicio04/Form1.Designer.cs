namespace Ejercicio04
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
            this.btnBase = new System.Windows.Forms.Button();
            this.btnExponent = new System.Windows.Forms.Button();
            this.btnRes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBase
            // 
            this.btnBase.Location = new System.Drawing.Point(118, 92);
            this.btnBase.Name = "btnBase";
            this.btnBase.Size = new System.Drawing.Size(100, 51);
            this.btnBase.TabIndex = 0;
            this.btnBase.Text = "Base";
            this.btnBase.UseVisualStyleBackColor = true;
            this.btnBase.Click += new System.EventHandler(this.btnBase_Click);
            // 
            // btnExponent
            // 
            this.btnExponent.Location = new System.Drawing.Point(267, 92);
            this.btnExponent.Name = "btnExponent";
            this.btnExponent.Size = new System.Drawing.Size(103, 51);
            this.btnExponent.TabIndex = 1;
            this.btnExponent.Text = "Exponent";
            this.btnExponent.UseVisualStyleBackColor = true;
            this.btnExponent.Click += new System.EventHandler(this.btnExponent_Click);
            // 
            // btnRes
            // 
            this.btnRes.Location = new System.Drawing.Point(158, 175);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(162, 43);
            this.btnRes.TabIndex = 2;
            this.btnRes.Text = "Resultado";
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 426);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.btnExponent);
            this.Controls.Add(this.btnBase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBase;
        private System.Windows.Forms.Button btnExponent;
        private System.Windows.Forms.Button btnRes;
    }
}

