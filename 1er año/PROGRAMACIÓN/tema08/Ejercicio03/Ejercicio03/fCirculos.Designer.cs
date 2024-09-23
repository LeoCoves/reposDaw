namespace Ejercicio03
{
    partial class fCirculos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAnyadirCirculo = new System.Windows.Forms.Button();
            this.txtPosX = new System.Windows.Forms.TextBox();
            this.txtPosY = new System.Windows.Forms.TextBox();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblPosX = new System.Windows.Forms.Label();
            this.lblPosY = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblRadio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAnyadirCirculo
            // 
            this.btnAnyadirCirculo.Location = new System.Drawing.Point(309, 290);
            this.btnAnyadirCirculo.Name = "btnAnyadirCirculo";
            this.btnAnyadirCirculo.Size = new System.Drawing.Size(135, 43);
            this.btnAnyadirCirculo.TabIndex = 0;
            this.btnAnyadirCirculo.Text = "Añadir Circulo";
            this.btnAnyadirCirculo.UseVisualStyleBackColor = true;
            this.btnAnyadirCirculo.Click += new System.EventHandler(this.btnAnyadirCirculo_Click);
            // 
            // txtPosX
            // 
            this.txtPosX.Location = new System.Drawing.Point(405, 55);
            this.txtPosX.Name = "txtPosX";
            this.txtPosX.Size = new System.Drawing.Size(99, 20);
            this.txtPosX.TabIndex = 1;
            // 
            // txtPosY
            // 
            this.txtPosY.Location = new System.Drawing.Point(405, 109);
            this.txtPosY.Name = "txtPosY";
            this.txtPosY.Size = new System.Drawing.Size(99, 20);
            this.txtPosY.TabIndex = 2;
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(405, 219);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(99, 20);
            this.txtRadio.TabIndex = 3;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(405, 166);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(99, 20);
            this.txtColor.TabIndex = 4;
            // 
            // lblPosX
            // 
            this.lblPosX.AutoSize = true;
            this.lblPosX.Location = new System.Drawing.Point(283, 58);
            this.lblPosX.Name = "lblPosX";
            this.lblPosX.Size = new System.Drawing.Size(45, 13);
            this.lblPosX.TabIndex = 5;
            this.lblPosX.Text = "lblPosX:";
            // 
            // lblPosY
            // 
            this.lblPosY.AutoSize = true;
            this.lblPosY.Location = new System.Drawing.Point(283, 112);
            this.lblPosY.Name = "lblPosY";
            this.lblPosY.Size = new System.Drawing.Size(45, 13);
            this.lblPosY.TabIndex = 6;
            this.lblPosY.Text = "lblPosY:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(283, 169);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(34, 13);
            this.lblColor.TabIndex = 7;
            this.lblColor.Text = "Color:";
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Location = new System.Drawing.Point(283, 222);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(38, 13);
            this.lblRadio.TabIndex = 8;
            this.lblRadio.Text = "Radio:";
            // 
            // fCirculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRadio);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblPosY);
            this.Controls.Add(this.lblPosX);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.txtPosY);
            this.Controls.Add(this.txtPosX);
            this.Controls.Add(this.btnAnyadirCirculo);
            this.Name = "fCirculos";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.fCirculos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnyadirCirculo;
        private System.Windows.Forms.TextBox txtPosX;
        private System.Windows.Forms.TextBox txtPosY;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label lblPosX;
        private System.Windows.Forms.Label lblPosY;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblRadio;
    }
}