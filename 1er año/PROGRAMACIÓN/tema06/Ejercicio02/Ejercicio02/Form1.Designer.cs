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
            this.btnMove = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(471, 232);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(131, 54);
            this.btnMove.TabIndex = 11;
            this.btnMove.Text = "Move even numbers to another list";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(471, 75);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(131, 54);
            this.btnCopy.TabIndex = 10;
            this.btnCopy.Text = "Copy even numbers to another list";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(117, 232);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(137, 54);
            this.btnShow.TabIndex = 9;
            this.btnShow.Text = "Show Lists";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(117, 63);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(137, 56);
            this.btnRead.TabIndex = 12;
            this.btnRead.Text = "Read List";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnRead;
    }
}

