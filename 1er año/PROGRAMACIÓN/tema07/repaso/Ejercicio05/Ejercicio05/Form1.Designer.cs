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
            this.btnAddEmployer = new System.Windows.Forms.Button();
            this.btnDelEmployer = new System.Windows.Forms.Button();
            this.brnShowListEmp = new System.Windows.Forms.Button();
            this.btnOrderEmpAlf = new System.Windows.Forms.Button();
            this.showDataEmp = new System.Windows.Forms.Button();
            this.btnAddSales = new System.Windows.Forms.Button();
            this.btnShowEmpMaySales = new System.Windows.Forms.Button();
            this.btnDelSales = new System.Windows.Forms.Button();
            this.btnOrderEmpSales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddEmployer
            // 
            this.btnAddEmployer.Location = new System.Drawing.Point(58, 50);
            this.btnAddEmployer.Name = "btnAddEmployer";
            this.btnAddEmployer.Size = new System.Drawing.Size(140, 35);
            this.btnAddEmployer.TabIndex = 0;
            this.btnAddEmployer.Text = "Introducir Empleado";
            this.btnAddEmployer.UseVisualStyleBackColor = true;
            this.btnAddEmployer.Click += new System.EventHandler(this.btnAddEmployer_Click);
            // 
            // btnDelEmployer
            // 
            this.btnDelEmployer.Location = new System.Drawing.Point(255, 50);
            this.btnDelEmployer.Name = "btnDelEmployer";
            this.btnDelEmployer.Size = new System.Drawing.Size(146, 35);
            this.btnDelEmployer.TabIndex = 1;
            this.btnDelEmployer.Text = "Eliminar Empleado";
            this.btnDelEmployer.UseVisualStyleBackColor = true;
            this.btnDelEmployer.Click += new System.EventHandler(this.btnDelEmployer_Click);
            // 
            // brnShowListEmp
            // 
            this.brnShowListEmp.Location = new System.Drawing.Point(473, 50);
            this.brnShowListEmp.Name = "brnShowListEmp";
            this.brnShowListEmp.Size = new System.Drawing.Size(143, 35);
            this.brnShowListEmp.TabIndex = 2;
            this.brnShowListEmp.Text = "Mostrar Lista Empleados";
            this.brnShowListEmp.UseVisualStyleBackColor = true;
            this.brnShowListEmp.Click += new System.EventHandler(this.brnShowListEmp_Click);
            // 
            // btnOrderEmpAlf
            // 
            this.btnOrderEmpAlf.Location = new System.Drawing.Point(143, 117);
            this.btnOrderEmpAlf.Name = "btnOrderEmpAlf";
            this.btnOrderEmpAlf.Size = new System.Drawing.Size(155, 37);
            this.btnOrderEmpAlf.TabIndex = 3;
            this.btnOrderEmpAlf.Text = "Ordenar Empleados Alfabeticamente";
            this.btnOrderEmpAlf.UseVisualStyleBackColor = true;
            this.btnOrderEmpAlf.Click += new System.EventHandler(this.btnOrderEmpAlf_Click);
            // 
            // showDataEmp
            // 
            this.showDataEmp.Location = new System.Drawing.Point(359, 117);
            this.showDataEmp.Name = "showDataEmp";
            this.showDataEmp.Size = new System.Drawing.Size(152, 37);
            this.showDataEmp.TabIndex = 4;
            this.showDataEmp.Text = "Mostrar Datos Empleado";
            this.showDataEmp.UseVisualStyleBackColor = true;
            this.showDataEmp.Click += new System.EventHandler(this.showDataEmp_Click);
            // 
            // btnAddSales
            // 
            this.btnAddSales.Location = new System.Drawing.Point(58, 205);
            this.btnAddSales.Name = "btnAddSales";
            this.btnAddSales.Size = new System.Drawing.Size(203, 36);
            this.btnAddSales.TabIndex = 5;
            this.btnAddSales.Text = "Añadir Ventas Empleado";
            this.btnAddSales.UseVisualStyleBackColor = true;
            this.btnAddSales.Click += new System.EventHandler(this.btnAddSales_Click);
            // 
            // btnShowEmpMaySales
            // 
            this.btnShowEmpMaySales.Location = new System.Drawing.Point(401, 205);
            this.btnShowEmpMaySales.Name = "btnShowEmpMaySales";
            this.btnShowEmpMaySales.Size = new System.Drawing.Size(215, 36);
            this.btnShowEmpMaySales.TabIndex = 6;
            this.btnShowEmpMaySales.Text = "Mostrar Empleado Mayores Ventas";
            this.btnShowEmpMaySales.UseVisualStyleBackColor = true;
            this.btnShowEmpMaySales.Click += new System.EventHandler(this.btnShowEmpMaySales_Click);
            // 
            // btnDelSales
            // 
            this.btnDelSales.Location = new System.Drawing.Point(58, 284);
            this.btnDelSales.Name = "btnDelSales";
            this.btnDelSales.Size = new System.Drawing.Size(203, 37);
            this.btnDelSales.TabIndex = 7;
            this.btnDelSales.Text = "Eliminar Ventas Empleado";
            this.btnDelSales.UseVisualStyleBackColor = true;
            this.btnDelSales.Click += new System.EventHandler(this.btnDelSales_Click);
            // 
            // btnOrderEmpSales
            // 
            this.btnOrderEmpSales.Location = new System.Drawing.Point(401, 284);
            this.btnOrderEmpSales.Name = "btnOrderEmpSales";
            this.btnOrderEmpSales.Size = new System.Drawing.Size(215, 37);
            this.btnOrderEmpSales.TabIndex = 8;
            this.btnOrderEmpSales.Text = "Ordenar Empleados por Ventas";
            this.btnOrderEmpSales.UseVisualStyleBackColor = true;
            this.btnOrderEmpSales.Click += new System.EventHandler(this.btnOrderEmpSales_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOrderEmpSales);
            this.Controls.Add(this.btnDelSales);
            this.Controls.Add(this.btnShowEmpMaySales);
            this.Controls.Add(this.btnAddSales);
            this.Controls.Add(this.showDataEmp);
            this.Controls.Add(this.btnOrderEmpAlf);
            this.Controls.Add(this.brnShowListEmp);
            this.Controls.Add(this.btnDelEmployer);
            this.Controls.Add(this.btnAddEmployer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddEmployer;
        private System.Windows.Forms.Button btnDelEmployer;
        private System.Windows.Forms.Button brnShowListEmp;
        private System.Windows.Forms.Button btnOrderEmpAlf;
        private System.Windows.Forms.Button showDataEmp;
        private System.Windows.Forms.Button btnAddSales;
        private System.Windows.Forms.Button btnShowEmpMaySales;
        private System.Windows.Forms.Button btnDelSales;
        private System.Windows.Forms.Button btnOrderEmpSales;
    }
}

