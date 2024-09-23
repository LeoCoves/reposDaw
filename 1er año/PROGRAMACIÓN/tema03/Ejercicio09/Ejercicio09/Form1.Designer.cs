namespace Ejercicio09
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Realizar un programa que pida una cantidad de dinero (en pesetas), y muestre en u" +
    "na etiqueta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(470, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "cuantos billetes de 10.000, de 5.000, de 2.000, de 1000 y monedas de 100 y 25 le " +
    "corresponden. ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(449, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Por ejemplo: 27.375 le corresponde 2 de 10.000, 1 de 5.000, 1 de 2.000, 3 de 100 " +
    "y 3 de 25. ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hacerlo de forma que si corresponde 0 billetes no aparezca.";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(261, 142);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(34, 13);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "Valor:";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(312, 369);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(113, 26);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "Calcular";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(332, 139);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(144, 20);
            this.txt1.TabIndex = 6;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(309, 189);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(0, 13);
            this.lbl2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label lbl2;
    }
}

