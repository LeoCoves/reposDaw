namespace Ejercicio05
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
            this.btnRead = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.BtnCopy = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(308, 74);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(150, 53);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Read the two list";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(308, 161);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(150, 48);
            this.btnSort.TabIndex = 1;
            this.btnSort.Text = "Order two list";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // BtnCopy
            // 
            this.BtnCopy.Location = new System.Drawing.Point(308, 295);
            this.BtnCopy.Name = "BtnCopy";
            this.BtnCopy.Size = new System.Drawing.Size(150, 51);
            this.BtnCopy.TabIndex = 2;
            this.BtnCopy.Text = "Move";
            this.BtnCopy.UseVisualStyleBackColor = true;
            this.BtnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(308, 227);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(150, 50);
            this.btnMove.TabIndex = 3;
            this.btnMove.Text = "Copy";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.BtnCopy);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnRead);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button BtnCopy;
        private System.Windows.Forms.Button btnMove;
    }
}

