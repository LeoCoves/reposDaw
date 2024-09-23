namespace Ejercicio13
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
            this.btndowhile = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnfor
            // 
            this.btnfor.Location = new System.Drawing.Point(152, 166);
            this.btnfor.Name = "btnfor";
            this.btnfor.Size = new System.Drawing.Size(93, 35);
            this.btnfor.TabIndex = 0;
            this.btnfor.Text = "FOR";
            this.btnfor.UseVisualStyleBackColor = true;
            this.btnfor.Click += new System.EventHandler(this.btnfor_Click);
            // 
            // btnwhile
            // 
            this.btnwhile.Location = new System.Drawing.Point(328, 166);
            this.btnwhile.Name = "btnwhile";
            this.btnwhile.Size = new System.Drawing.Size(91, 35);
            this.btnwhile.TabIndex = 1;
            this.btnwhile.Text = "WHILE";
            this.btnwhile.UseVisualStyleBackColor = true;
            this.btnwhile.Click += new System.EventHandler(this.btnwhile_Click);
            // 
            // btndowhile
            // 
            this.btndowhile.Location = new System.Drawing.Point(499, 166);
            this.btndowhile.Name = "btndowhile";
            this.btndowhile.Size = new System.Drawing.Size(84, 35);
            this.btndowhile.TabIndex = 2;
            this.btndowhile.Text = "DOWHILE";
            this.btndowhile.UseVisualStyleBackColor = true;
            this.btndowhile.Click += new System.EventHandler(this.btndowhile_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(319, 95);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(113, 20);
            this.txt1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btndowhile);
            this.Controls.Add(this.btnwhile);
            this.Controls.Add(this.btnfor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnfor;
        private System.Windows.Forms.Button btnwhile;
        private System.Windows.Forms.Button btndowhile;
        private System.Windows.Forms.TextBox txt1;
    }
}

