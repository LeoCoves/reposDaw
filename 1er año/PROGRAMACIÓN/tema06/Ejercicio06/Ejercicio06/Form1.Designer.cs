namespace Ejercicio06
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
            this.btnRead1 = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnRead2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRead1
            // 
            this.btnRead1.Location = new System.Drawing.Point(216, 71);
            this.btnRead1.Name = "btnRead1";
            this.btnRead1.Size = new System.Drawing.Size(140, 50);
            this.btnRead1.TabIndex = 0;
            this.btnRead1.Text = "Read first list";
            this.btnRead1.UseVisualStyleBackColor = true;
            this.btnRead1.Click += new System.EventHandler(this.btnRead1_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(310, 159);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(140, 45);
            this.btnSort.TabIndex = 1;
            this.btnSort.Text = "Sort the lists";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(310, 240);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(140, 61);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Copy and sort at the third list without repeat values";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnRead2
            // 
            this.btnRead2.Location = new System.Drawing.Point(417, 71);
            this.btnRead2.Name = "btnRead2";
            this.btnRead2.Size = new System.Drawing.Size(133, 50);
            this.btnRead2.TabIndex = 3;
            this.btnRead2.Text = "Read second List";
            this.btnRead2.UseVisualStyleBackColor = true;
            this.btnRead2.Click += new System.EventHandler(this.btnRead2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRead2);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnRead1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRead1;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnRead2;
    }
}

