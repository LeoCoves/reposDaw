namespace Ejercicio12
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnfor = new System.Windows.Forms.Button();
            this.btnwhile = new System.Windows.Forms.Button();
            this.btndowhile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(323, 128);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 3;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(320, 100);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(110, 13);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "Introduzca un numero";
            // 
            // btnfor
            // 
            this.btnfor.Location = new System.Drawing.Point(212, 170);
            this.btnfor.Name = "btnfor";
            this.btnfor.Size = new System.Drawing.Size(75, 23);
            this.btnfor.TabIndex = 5;
            this.btnfor.Text = "FOR";
            this.btnfor.UseVisualStyleBackColor = true;
            this.btnfor.Click += new System.EventHandler(this.btnfor_Click);
            // 
            // btnwhile
            // 
            this.btnwhile.Location = new System.Drawing.Point(335, 170);
            this.btnwhile.Name = "btnwhile";
            this.btnwhile.Size = new System.Drawing.Size(75, 23);
            this.btnwhile.TabIndex = 6;
            this.btnwhile.Text = "WHILE";
            this.btnwhile.UseVisualStyleBackColor = true;
            this.btnwhile.Click += new System.EventHandler(this.btnwhile_Click);
            // 
            // btndowhile
            // 
            this.btndowhile.Location = new System.Drawing.Point(459, 170);
            this.btndowhile.Name = "btndowhile";
            this.btndowhile.Size = new System.Drawing.Size(75, 23);
            this.btndowhile.TabIndex = 7;
            this.btndowhile.Text = "DO WHILE";
            this.btndowhile.UseVisualStyleBackColor = true;
            this.btndowhile.Click += new System.EventHandler(this.btndowhile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btndowhile);
            this.Controls.Add(this.btnwhile);
            this.Controls.Add(this.btnfor);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnfor;
        private System.Windows.Forms.Button btnwhile;
        private System.Windows.Forms.Button btndowhile;
    }
}

