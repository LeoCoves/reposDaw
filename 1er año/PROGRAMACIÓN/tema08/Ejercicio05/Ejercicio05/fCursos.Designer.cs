namespace Ejercicio05
{
    partial class fCursos
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
            this.btnMostrarAlumnosDelCurso = new System.Windows.Forms.Button();
            this.btnMostrarCursos = new System.Windows.Forms.Button();
            this.btnEliminarCurso = new System.Windows.Forms.Button();
            this.btnAñadirCurso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMostrarAlumnosDelCurso
            // 
            this.btnMostrarAlumnosDelCurso.Location = new System.Drawing.Point(310, 270);
            this.btnMostrarAlumnosDelCurso.Name = "btnMostrarAlumnosDelCurso";
            this.btnMostrarAlumnosDelCurso.Size = new System.Drawing.Size(144, 44);
            this.btnMostrarAlumnosDelCurso.TabIndex = 7;
            this.btnMostrarAlumnosDelCurso.Text = "Mostrar todos los Alumnos pertenecientes a un Curso";
            this.btnMostrarAlumnosDelCurso.UseVisualStyleBackColor = true;
            this.btnMostrarAlumnosDelCurso.Click += new System.EventHandler(this.btnMostrarAlumnosDelCurso_Click);
            // 
            // btnMostrarCursos
            // 
            this.btnMostrarCursos.Location = new System.Drawing.Point(310, 214);
            this.btnMostrarCursos.Name = "btnMostrarCursos";
            this.btnMostrarCursos.Size = new System.Drawing.Size(144, 41);
            this.btnMostrarCursos.TabIndex = 6;
            this.btnMostrarCursos.Text = "Mostrar Todos los Cursos";
            this.btnMostrarCursos.UseVisualStyleBackColor = true;
            this.btnMostrarCursos.Click += new System.EventHandler(this.btnMostrarCursos_Click);
            // 
            // btnEliminarCurso
            // 
            this.btnEliminarCurso.Location = new System.Drawing.Point(310, 161);
            this.btnEliminarCurso.Name = "btnEliminarCurso";
            this.btnEliminarCurso.Size = new System.Drawing.Size(144, 38);
            this.btnEliminarCurso.TabIndex = 5;
            this.btnEliminarCurso.Text = "Eliminar Curso";
            this.btnEliminarCurso.UseVisualStyleBackColor = true;
            this.btnEliminarCurso.Click += new System.EventHandler(this.btnEliminarCurso_Click);
            // 
            // btnAñadirCurso
            // 
            this.btnAñadirCurso.Location = new System.Drawing.Point(310, 107);
            this.btnAñadirCurso.Name = "btnAñadirCurso";
            this.btnAñadirCurso.Size = new System.Drawing.Size(144, 37);
            this.btnAñadirCurso.TabIndex = 4;
            this.btnAñadirCurso.Text = "Añadir Curso";
            this.btnAñadirCurso.UseVisualStyleBackColor = true;
            this.btnAñadirCurso.Click += new System.EventHandler(this.btnAñadirCurso_Click);
            // 
            // fCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrarAlumnosDelCurso);
            this.Controls.Add(this.btnMostrarCursos);
            this.Controls.Add(this.btnEliminarCurso);
            this.Controls.Add(this.btnAñadirCurso);
            this.Name = "fCursos";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarAlumnosDelCurso;
        private System.Windows.Forms.Button btnMostrarCursos;
        private System.Windows.Forms.Button btnEliminarCurso;
        private System.Windows.Forms.Button btnAñadirCurso;
    }
}