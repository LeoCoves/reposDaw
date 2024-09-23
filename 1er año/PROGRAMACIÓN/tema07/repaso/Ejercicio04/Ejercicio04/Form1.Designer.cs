namespace Ejercicio04
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
            this.btnEmployer = new System.Windows.Forms.Button();
            this.btnBirthayEmp = new System.Windows.Forms.Button();
            this.btnShowList = new System.Windows.Forms.Button();
            this.btnAddSales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmployer
            // 
            this.btnEmployer.Location = new System.Drawing.Point(125, 93);
            this.btnEmployer.Name = "btnEmployer";
            this.btnEmployer.Size = new System.Drawing.Size(146, 41);
            this.btnEmployer.TabIndex = 0;
            this.btnEmployer.Text = "Introducir empleado";
            this.btnEmployer.UseVisualStyleBackColor = true;
            this.btnEmployer.Click += new System.EventHandler(this.btnEmployer_Click);
            // 
            // btnBirthayEmp
            // 
            this.btnBirthayEmp.Location = new System.Drawing.Point(125, 182);
            this.btnBirthayEmp.Name = "btnBirthayEmp";
            this.btnBirthayEmp.Size = new System.Drawing.Size(146, 41);
            this.btnBirthayEmp.TabIndex = 1;
            this.btnBirthayEmp.Text = "Cumpleaños Empleado";
            this.btnBirthayEmp.UseVisualStyleBackColor = true;
            this.btnBirthayEmp.Click += new System.EventHandler(this.btnBirthayEmp_Click);
            // 
            // btnShowList
            // 
            this.btnShowList.Location = new System.Drawing.Point(358, 93);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(149, 41);
            this.btnShowList.TabIndex = 2;
            this.btnShowList.Text = "Mostrar Lista Empleados";
            this.btnShowList.UseVisualStyleBackColor = true;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // btnAddSales
            // 
            this.btnAddSales.Location = new System.Drawing.Point(358, 182);
            this.btnAddSales.Name = "btnAddSales";
            this.btnAddSales.Size = new System.Drawing.Size(149, 41);
            this.btnAddSales.TabIndex = 3;
            this.btnAddSales.Text = "Añadir venta";
            this.btnAddSales.UseVisualStyleBackColor = true;
            this.btnAddSales.Click += new System.EventHandler(this.btnAddSales_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddSales);
            this.Controls.Add(this.btnShowList);
            this.Controls.Add(this.btnBirthayEmp);
            this.Controls.Add(this.btnEmployer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmployer;
        private System.Windows.Forms.Button btnBirthayEmp;
        private System.Windows.Forms.Button btnShowList;
        private System.Windows.Forms.Button btnAddSales;
    }
}

