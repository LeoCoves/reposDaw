namespace Ejercicio08
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
            this.ReadRandomLottery = new System.Windows.Forms.Button();
            this.ReadMyLottery = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReadRandomLottery
            // 
            this.ReadRandomLottery.Location = new System.Drawing.Point(143, 176);
            this.ReadRandomLottery.Name = "ReadRandomLottery";
            this.ReadRandomLottery.Size = new System.Drawing.Size(124, 61);
            this.ReadRandomLottery.TabIndex = 0;
            this.ReadRandomLottery.Text = "Read Primitive Lottery";
            this.ReadRandomLottery.UseVisualStyleBackColor = true;
            this.ReadRandomLottery.Click += new System.EventHandler(this.ReadRandomLottery_Click);
            // 
            // ReadMyLottery
            // 
            this.ReadMyLottery.Location = new System.Drawing.Point(335, 176);
            this.ReadMyLottery.Name = "ReadMyLottery";
            this.ReadMyLottery.Size = new System.Drawing.Size(123, 61);
            this.ReadMyLottery.TabIndex = 1;
            this.ReadMyLottery.Text = "Read my lottery";
            this.ReadMyLottery.UseVisualStyleBackColor = true;
            this.ReadMyLottery.Click += new System.EventHandler(this.ReadMyLottery_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(534, 176);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(121, 61);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check the winner";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.ReadMyLottery);
            this.Controls.Add(this.ReadRandomLottery);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReadRandomLottery;
        private System.Windows.Forms.Button ReadMyLottery;
        private System.Windows.Forms.Button btnCheck;
    }
}

