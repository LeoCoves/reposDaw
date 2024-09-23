namespace Ejemplo01
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
            this.Bprimero = new System.Windows.Forms.Button();
            this.Bsegundo = new System.Windows.Forms.Button();
            this.LEtiqueta = new System.Windows.Forms.Label();
            this.TCuadroTexto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Bprimero
            // 
            this.Bprimero.Location = new System.Drawing.Point(354, 211);
            this.Bprimero.Name = "Bprimero";
            this.Bprimero.Size = new System.Drawing.Size(75, 23);
            this.Bprimero.TabIndex = 0;
            this.Bprimero.Text = "BOTON";
            this.Bprimero.UseVisualStyleBackColor = true;
            this.Bprimero.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bsegundo
            // 
            this.Bsegundo.Location = new System.Drawing.Point(341, 328);
            this.Bsegundo.Name = "Bsegundo";
            this.Bsegundo.Size = new System.Drawing.Size(99, 47);
            this.Bsegundo.TabIndex = 1;
            this.Bsegundo.Text = "OTRO BOTON";
            this.Bsegundo.UseVisualStyleBackColor = true;
            this.Bsegundo.Click += new System.EventHandler(this.Bsegundo_Click);
            // 
            // LEtiqueta
            // 
            this.LEtiqueta.AutoSize = true;
            this.LEtiqueta.Location = new System.Drawing.Point(375, 75);
            this.LEtiqueta.Name = "LEtiqueta";
            this.LEtiqueta.Size = new System.Drawing.Size(35, 13);
            this.LEtiqueta.TabIndex = 2;
            this.LEtiqueta.Text = "label1";
            this.LEtiqueta.Click += new System.EventHandler(this.label1_Click);
            // 
            // TCuadroTexto
            // 
            this.TCuadroTexto.Location = new System.Drawing.Point(325, 127);
            this.TCuadroTexto.Name = "TCuadroTexto";
            this.TCuadroTexto.Size = new System.Drawing.Size(129, 20);
            this.TCuadroTexto.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TCuadroTexto);
            this.Controls.Add(this.LEtiqueta);
            this.Controls.Add(this.Bsegundo);
            this.Controls.Add(this.Bprimero);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "Form1";
            this.Text = "Mi primer programa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bprimero;
        private System.Windows.Forms.Button Bsegundo;
        private System.Windows.Forms.Label LEtiqueta;
        private System.Windows.Forms.TextBox TCuadroTexto;
    }
}

