namespace Ejercicio04
{
    partial class fHexagono
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
            this.lblLado = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblPosY = new System.Windows.Forms.Label();
            this.lblPosX = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtLado = new System.Windows.Forms.TextBox();
            this.txtPosY = new System.Windows.Forms.TextBox();
            this.txtPosX = new System.Windows.Forms.TextBox();
            this.btnAnyadirHexagono = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.Location = new System.Drawing.Point(290, 253);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(34, 13);
            this.lblLado.TabIndex = 35;
            this.lblLado.Text = "Lado:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(290, 200);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(34, 13);
            this.lblColor.TabIndex = 34;
            this.lblColor.Text = "Color:";
            // 
            // lblPosY
            // 
            this.lblPosY.AutoSize = true;
            this.lblPosY.Location = new System.Drawing.Point(290, 143);
            this.lblPosY.Name = "lblPosY";
            this.lblPosY.Size = new System.Drawing.Size(38, 13);
            this.lblPosY.TabIndex = 33;
            this.lblPosY.Text = "Pos Y:";
            // 
            // lblPosX
            // 
            this.lblPosX.AutoSize = true;
            this.lblPosX.Location = new System.Drawing.Point(290, 89);
            this.lblPosX.Name = "lblPosX";
            this.lblPosX.Size = new System.Drawing.Size(38, 13);
            this.lblPosX.TabIndex = 32;
            this.lblPosX.Text = "Pos X:";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(412, 197);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(99, 20);
            this.txtColor.TabIndex = 31;
            // 
            // txtLado
            // 
            this.txtLado.Location = new System.Drawing.Point(412, 250);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(99, 20);
            this.txtLado.TabIndex = 30;
            // 
            // txtPosY
            // 
            this.txtPosY.Location = new System.Drawing.Point(412, 140);
            this.txtPosY.Name = "txtPosY";
            this.txtPosY.Size = new System.Drawing.Size(99, 20);
            this.txtPosY.TabIndex = 29;
            // 
            // txtPosX
            // 
            this.txtPosX.Location = new System.Drawing.Point(412, 86);
            this.txtPosX.Name = "txtPosX";
            this.txtPosX.Size = new System.Drawing.Size(99, 20);
            this.txtPosX.TabIndex = 28;
            // 
            // btnAnyadirHexagono
            // 
            this.btnAnyadirHexagono.Location = new System.Drawing.Point(316, 321);
            this.btnAnyadirHexagono.Name = "btnAnyadirHexagono";
            this.btnAnyadirHexagono.Size = new System.Drawing.Size(135, 43);
            this.btnAnyadirHexagono.TabIndex = 27;
            this.btnAnyadirHexagono.Text = "Añadir Hexagono";
            this.btnAnyadirHexagono.UseVisualStyleBackColor = true;
            this.btnAnyadirHexagono.Click += new System.EventHandler(this.btnAnyadirHexagono_Click);
            // 
            // fHexagono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLado);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblPosY);
            this.Controls.Add(this.lblPosX);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtLado);
            this.Controls.Add(this.txtPosY);
            this.Controls.Add(this.txtPosX);
            this.Controls.Add(this.btnAnyadirHexagono);
            this.Name = "fHexagono";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblPosY;
        private System.Windows.Forms.Label lblPosX;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.TextBox txtPosY;
        private System.Windows.Forms.TextBox txtPosX;
        private System.Windows.Forms.Button btnAnyadirHexagono;
    }
}