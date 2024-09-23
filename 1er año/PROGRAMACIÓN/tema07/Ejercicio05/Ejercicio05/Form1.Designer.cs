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
            this.grupoEmpleados = new System.Windows.Forms.GroupBox();
            this.btnEnterEmployer = new System.Windows.Forms.Button();
            this.grupoVentas = new System.Windows.Forms.GroupBox();
            this.btnDelEmployer = new System.Windows.Forms.Button();
            this.btnShowListEmployer = new System.Windows.Forms.Button();
            this.btnOrderEmployerAlf = new System.Windows.Forms.Button();
            this.btnShowDataEmployer = new System.Windows.Forms.Button();
            this.btnAddSales = new System.Windows.Forms.Button();
            this.btnDelSales = new System.Windows.Forms.Button();
            this.btnShowEmpBestSales = new System.Windows.Forms.Button();
            this.btnOrderEmpXSales = new System.Windows.Forms.Button();
            this.grupoEmpleados.SuspendLayout();
            this.grupoVentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupoEmpleados
            // 
            this.grupoEmpleados.Controls.Add(this.btnShowDataEmployer);
            this.grupoEmpleados.Controls.Add(this.btnOrderEmployerAlf);
            this.grupoEmpleados.Controls.Add(this.btnShowListEmployer);
            this.grupoEmpleados.Controls.Add(this.btnDelEmployer);
            this.grupoEmpleados.Controls.Add(this.btnEnterEmployer);
            this.grupoEmpleados.Location = new System.Drawing.Point(119, 65);
            this.grupoEmpleados.Name = "grupoEmpleados";
            this.grupoEmpleados.Size = new System.Drawing.Size(533, 151);
            this.grupoEmpleados.TabIndex = 2;
            this.grupoEmpleados.TabStop = false;
            this.grupoEmpleados.Text = "Empleados";
            // 
            // btnEnterEmployer
            // 
            this.btnEnterEmployer.Location = new System.Drawing.Point(24, 33);
            this.btnEnterEmployer.Name = "btnEnterEmployer";
            this.btnEnterEmployer.Size = new System.Drawing.Size(129, 36);
            this.btnEnterEmployer.TabIndex = 0;
            this.btnEnterEmployer.Text = "Introducir Empleado";
            this.btnEnterEmployer.UseVisualStyleBackColor = true;
            this.btnEnterEmployer.Click += new System.EventHandler(this.btnEnterEmployer_Click);
            // 
            // grupoVentas
            // 
            this.grupoVentas.Controls.Add(this.btnOrderEmpXSales);
            this.grupoVentas.Controls.Add(this.btnShowEmpBestSales);
            this.grupoVentas.Controls.Add(this.btnDelSales);
            this.grupoVentas.Controls.Add(this.btnAddSales);
            this.grupoVentas.Location = new System.Drawing.Point(119, 245);
            this.grupoVentas.Name = "grupoVentas";
            this.grupoVentas.Size = new System.Drawing.Size(533, 144);
            this.grupoVentas.TabIndex = 3;
            this.grupoVentas.TabStop = false;
            this.grupoVentas.Text = "Ventas";
            // 
            // btnDelEmployer
            // 
            this.btnDelEmployer.Location = new System.Drawing.Point(190, 33);
            this.btnDelEmployer.Name = "btnDelEmployer";
            this.btnDelEmployer.Size = new System.Drawing.Size(139, 36);
            this.btnDelEmployer.TabIndex = 1;
            this.btnDelEmployer.Text = "Eliminar Empleado";
            this.btnDelEmployer.UseVisualStyleBackColor = true;
            this.btnDelEmployer.Click += new System.EventHandler(this.btnDelEmployer_Click);
            // 
            // btnShowListEmployer
            // 
            this.btnShowListEmployer.Location = new System.Drawing.Point(363, 33);
            this.btnShowListEmployer.Name = "btnShowListEmployer";
            this.btnShowListEmployer.Size = new System.Drawing.Size(142, 36);
            this.btnShowListEmployer.TabIndex = 2;
            this.btnShowListEmployer.Text = "Mostrar Lista Empleados";
            this.btnShowListEmployer.UseVisualStyleBackColor = true;
            this.btnShowListEmployer.Click += new System.EventHandler(this.btnShowListEmployer_Click);
            // 
            // btnOrderEmployerAlf
            // 
            this.btnOrderEmployerAlf.Location = new System.Drawing.Point(24, 87);
            this.btnOrderEmployerAlf.Name = "btnOrderEmployerAlf";
            this.btnOrderEmployerAlf.Size = new System.Drawing.Size(220, 36);
            this.btnOrderEmployerAlf.TabIndex = 3;
            this.btnOrderEmployerAlf.Text = "Ordenar Empleados por Orden Alfabetico";
            this.btnOrderEmployerAlf.UseVisualStyleBackColor = true;
            this.btnOrderEmployerAlf.Click += new System.EventHandler(this.btnOrderEmployerAlf_Click);
            // 
            // btnShowDataEmployer
            // 
            this.btnShowDataEmployer.Location = new System.Drawing.Point(270, 87);
            this.btnShowDataEmployer.Name = "btnShowDataEmployer";
            this.btnShowDataEmployer.Size = new System.Drawing.Size(235, 36);
            this.btnShowDataEmployer.TabIndex = 4;
            this.btnShowDataEmployer.Text = "Mostrar Datos Empleado";
            this.btnShowDataEmployer.UseVisualStyleBackColor = true;
            this.btnShowDataEmployer.Click += new System.EventHandler(this.btnShowDataEmployer_Click);
            // 
            // btnAddSales
            // 
            this.btnAddSales.Location = new System.Drawing.Point(24, 34);
            this.btnAddSales.Name = "btnAddSales";
            this.btnAddSales.Size = new System.Drawing.Size(206, 35);
            this.btnAddSales.TabIndex = 0;
            this.btnAddSales.Text = "Añadir Ventas a Empleado";
            this.btnAddSales.UseVisualStyleBackColor = true;
            this.btnAddSales.Click += new System.EventHandler(this.btnAddSales_Click);
            // 
            // btnDelSales
            // 
            this.btnDelSales.Location = new System.Drawing.Point(24, 85);
            this.btnDelSales.Name = "btnDelSales";
            this.btnDelSales.Size = new System.Drawing.Size(206, 35);
            this.btnDelSales.TabIndex = 1;
            this.btnDelSales.Text = "Eliminar las Ventas de un Empleado";
            this.btnDelSales.UseVisualStyleBackColor = true;
            this.btnDelSales.Click += new System.EventHandler(this.btnDelSales_Click);
            // 
            // btnShowEmpBestSales
            // 
            this.btnShowEmpBestSales.Location = new System.Drawing.Point(295, 34);
            this.btnShowEmpBestSales.Name = "btnShowEmpBestSales";
            this.btnShowEmpBestSales.Size = new System.Drawing.Size(210, 35);
            this.btnShowEmpBestSales.TabIndex = 2;
            this.btnShowEmpBestSales.Text = "Mostrar Empleado con mayores Ventas";
            this.btnShowEmpBestSales.UseVisualStyleBackColor = true;
            this.btnShowEmpBestSales.Click += new System.EventHandler(this.btnShowEmpBestSales_Click);
            // 
            // btnOrderEmpXSales
            // 
            this.btnOrderEmpXSales.Location = new System.Drawing.Point(295, 85);
            this.btnOrderEmpXSales.Name = "btnOrderEmpXSales";
            this.btnOrderEmpXSales.Size = new System.Drawing.Size(210, 35);
            this.btnOrderEmpXSales.TabIndex = 3;
            this.btnOrderEmpXSales.Text = "Ordenar Empleados por Ventas";
            this.btnOrderEmpXSales.UseVisualStyleBackColor = true;
            this.btnOrderEmpXSales.Click += new System.EventHandler(this.btnOrderEmpXSales_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grupoVentas);
            this.Controls.Add(this.grupoEmpleados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grupoEmpleados.ResumeLayout(false);
            this.grupoVentas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grupoEmpleados;
        private System.Windows.Forms.Button btnShowDataEmployer;
        private System.Windows.Forms.Button btnOrderEmployerAlf;
        private System.Windows.Forms.Button btnShowListEmployer;
        private System.Windows.Forms.Button btnDelEmployer;
        private System.Windows.Forms.Button btnEnterEmployer;
        private System.Windows.Forms.GroupBox grupoVentas;
        private System.Windows.Forms.Button btnOrderEmpXSales;
        private System.Windows.Forms.Button btnShowEmpBestSales;
        private System.Windows.Forms.Button btnDelSales;
        private System.Windows.Forms.Button btnAddSales;
    }
}

