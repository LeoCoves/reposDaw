namespace Ejercicio06CentroEscolar
{
    partial class fProfesores
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
            this.grupoProfesores = new System.Windows.Forms.GroupBox();
            this.bMostrarDatosProf = new System.Windows.Forms.Button();
            this.bOrdenarProfAlfabeticamente = new System.Windows.Forms.Button();
            this.bMostrarListaProf = new System.Windows.Forms.Button();
            this.bEliminarProf = new System.Windows.Forms.Button();
            this.bIntroducirProf = new System.Windows.Forms.Button();
            this.grupoAsignaturas = new System.Windows.Forms.GroupBox();
            this.bMostrarProfDeAsig = new System.Windows.Forms.Button();
            this.bEliminarAsigProf = new System.Windows.Forms.Button();
            this.bAnyadirAsigProf = new System.Windows.Forms.Button();
            this.grupoProfesores.SuspendLayout();
            this.grupoAsignaturas.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupoProfesores
            // 
            this.grupoProfesores.Controls.Add(this.bMostrarDatosProf);
            this.grupoProfesores.Controls.Add(this.bOrdenarProfAlfabeticamente);
            this.grupoProfesores.Controls.Add(this.bMostrarListaProf);
            this.grupoProfesores.Controls.Add(this.bEliminarProf);
            this.grupoProfesores.Controls.Add(this.bIntroducirProf);
            this.grupoProfesores.Location = new System.Drawing.Point(40, 23);
            this.grupoProfesores.Name = "grupoProfesores";
            this.grupoProfesores.Size = new System.Drawing.Size(730, 203);
            this.grupoProfesores.TabIndex = 0;
            this.grupoProfesores.TabStop = false;
            this.grupoProfesores.Text = "Profesores";
            // 
            // bMostrarDatosProf
            // 
            this.bMostrarDatosProf.Location = new System.Drawing.Point(379, 116);
            this.bMostrarDatosProf.Name = "bMostrarDatosProf";
            this.bMostrarDatosProf.Size = new System.Drawing.Size(263, 42);
            this.bMostrarDatosProf.TabIndex = 4;
            this.bMostrarDatosProf.Text = "Mostrar Datos Profesores";
            this.bMostrarDatosProf.UseVisualStyleBackColor = true;
            this.bMostrarDatosProf.Click += new System.EventHandler(this.bMostrarDatosProf_Click);
            // 
            // bOrdenarProfAlfabeticamente
            // 
            this.bOrdenarProfAlfabeticamente.Location = new System.Drawing.Point(96, 116);
            this.bOrdenarProfAlfabeticamente.Name = "bOrdenarProfAlfabeticamente";
            this.bOrdenarProfAlfabeticamente.Size = new System.Drawing.Size(239, 42);
            this.bOrdenarProfAlfabeticamente.TabIndex = 3;
            this.bOrdenarProfAlfabeticamente.Text = "Ordenar profesores por Orden Alfabetico";
            this.bOrdenarProfAlfabeticamente.UseVisualStyleBackColor = true;
            this.bOrdenarProfAlfabeticamente.Click += new System.EventHandler(this.bOrdenarProfAlfabeticamente_Click);
            // 
            // bMostrarListaProf
            // 
            this.bMostrarListaProf.Location = new System.Drawing.Point(516, 39);
            this.bMostrarListaProf.Name = "bMostrarListaProf";
            this.bMostrarListaProf.Size = new System.Drawing.Size(178, 42);
            this.bMostrarListaProf.TabIndex = 2;
            this.bMostrarListaProf.Text = "Mostrar Lista Profesores";
            this.bMostrarListaProf.UseVisualStyleBackColor = true;
            this.bMostrarListaProf.Click += new System.EventHandler(this.bMostrarListaProf_Click);
            // 
            // bEliminarProf
            // 
            this.bEliminarProf.Location = new System.Drawing.Point(272, 39);
            this.bEliminarProf.Name = "bEliminarProf";
            this.bEliminarProf.Size = new System.Drawing.Size(178, 42);
            this.bEliminarProf.TabIndex = 1;
            this.bEliminarProf.Text = "Eliminar Profesor";
            this.bEliminarProf.UseVisualStyleBackColor = true;
            this.bEliminarProf.Click += new System.EventHandler(this.bEliminarProf_Click);
            // 
            // bIntroducirProf
            // 
            this.bIntroducirProf.Location = new System.Drawing.Point(25, 39);
            this.bIntroducirProf.Name = "bIntroducirProf";
            this.bIntroducirProf.Size = new System.Drawing.Size(178, 42);
            this.bIntroducirProf.TabIndex = 0;
            this.bIntroducirProf.Text = "Introducir Profesor";
            this.bIntroducirProf.UseVisualStyleBackColor = true;
            this.bIntroducirProf.Click += new System.EventHandler(this.bIntroducirProf_Click);
            // 
            // grupoAsignaturas
            // 
            this.grupoAsignaturas.Controls.Add(this.bMostrarProfDeAsig);
            this.grupoAsignaturas.Controls.Add(this.bEliminarAsigProf);
            this.grupoAsignaturas.Controls.Add(this.bAnyadirAsigProf);
            this.grupoAsignaturas.Location = new System.Drawing.Point(40, 246);
            this.grupoAsignaturas.Name = "grupoAsignaturas";
            this.grupoAsignaturas.Size = new System.Drawing.Size(730, 183);
            this.grupoAsignaturas.TabIndex = 1;
            this.grupoAsignaturas.TabStop = false;
            this.grupoAsignaturas.Text = "Asignaturas";
            // 
            // bMostrarProfDeAsig
            // 
            this.bMostrarProfDeAsig.Location = new System.Drawing.Point(207, 111);
            this.bMostrarProfDeAsig.Name = "bMostrarProfDeAsig";
            this.bMostrarProfDeAsig.Size = new System.Drawing.Size(297, 42);
            this.bMostrarProfDeAsig.TabIndex = 6;
            this.bMostrarProfDeAsig.Text = "Mostrar profesores que imparten una asignatura";
            this.bMostrarProfDeAsig.UseVisualStyleBackColor = true;
            this.bMostrarProfDeAsig.Click += new System.EventHandler(this.bMostrarProfDeAsig_Click_1);
            // 
            // bEliminarAsigProf
            // 
            this.bEliminarAsigProf.Location = new System.Drawing.Point(379, 35);
            this.bEliminarAsigProf.Name = "bEliminarAsigProf";
            this.bEliminarAsigProf.Size = new System.Drawing.Size(297, 42);
            this.bEliminarAsigProf.TabIndex = 5;
            this.bEliminarAsigProf.Text = "Eliminar Asignaturas de un profesor";
            this.bEliminarAsigProf.UseVisualStyleBackColor = true;
            this.bEliminarAsigProf.Click += new System.EventHandler(this.bEliminarAsigProf_Click);
            // 
            // bAnyadirAsigProf
            // 
            this.bAnyadirAsigProf.Location = new System.Drawing.Point(38, 35);
            this.bAnyadirAsigProf.Name = "bAnyadirAsigProf";
            this.bAnyadirAsigProf.Size = new System.Drawing.Size(297, 42);
            this.bAnyadirAsigProf.TabIndex = 4;
            this.bAnyadirAsigProf.Text = "Añadir Asignatura a profesores";
            this.bAnyadirAsigProf.UseVisualStyleBackColor = true;
            this.bAnyadirAsigProf.Click += new System.EventHandler(this.bAnyadirAsigProf_Click);
            // 
            // fProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grupoAsignaturas);
            this.Controls.Add(this.grupoProfesores);
            this.Name = "fProfesores";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.fPofesores_Load);
            this.grupoProfesores.ResumeLayout(false);
            this.grupoAsignaturas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grupoProfesores;
        private System.Windows.Forms.GroupBox grupoAsignaturas;
        private System.Windows.Forms.Button bMostrarDatosProf;
        private System.Windows.Forms.Button bOrdenarProfAlfabeticamente;
        private System.Windows.Forms.Button bMostrarListaProf;
        private System.Windows.Forms.Button bEliminarProf;
        private System.Windows.Forms.Button bIntroducirProf;
        private System.Windows.Forms.Button bMostrarProfDeAsig;
        private System.Windows.Forms.Button bEliminarAsigProf;
        private System.Windows.Forms.Button bAnyadirAsigProf;
    }
}