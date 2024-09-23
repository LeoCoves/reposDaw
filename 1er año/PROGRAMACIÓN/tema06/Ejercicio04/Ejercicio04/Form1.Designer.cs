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
            this.btnExp = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBase
            // 
            this.btnBase.Location = new System.Drawing.Point(179, 117);
            this.btnBase.Name = "btnBase";
            this.btnBase.Size = new System.Drawing.Size(117, 54);
            this.btnBase.TabIndex = 0;
            this.btnBase.Text = "Read Base Value";
            this.btnBase.UseVisualStyleBackColor = true;
            this.btnBase.Click += new System.EventHandler(this.btnBase_Click);
            // 
            // btnExp
            // 
            this.btnExp.Location = new System.Drawing.Point(179, 218);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(117, 53);
            this.btnExp.TabIndex = 1;
            this.btnExp.Text = "Read Exponent Value";
            this.btnExp.UseVisualStyleBackColor = true;
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(434, 169);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(125, 58);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Show Result";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnExp);
            this.Controls.Add(this.btnBase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBase;
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.Button btnShow;
    }
}

