namespace Ejercicio05
{
    partial class fAlumnos
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
            this.contenedor2 = new System.Windows.Forms.GroupBox();
            this.bMostrarAluNotaMediaMenor5 = new System.Windows.Forms.Button();
            this.bMostrarAluNotaMediaMayor5 = new System.Windows.Forms.Button();
            this.bAñadirNotasAlumno = new System.Windows.Forms.Button();
            this.bEliminarNotasAlumno = new System.Windows.Forms.Button();
            this.Contenedor1 = new System.Windows.Forms.GroupBox();
            this.bMostrarAlumnosDeCurso = new System.Windows.Forms.Button();
            this.bMostrarDatosAlumno = new System.Windows.Forms.Button();
            this.bOrdenarAlumnosAlfabeticamente = new System.Windows.Forms.Button();
            this.bMostrarListaAlumnos = new System.Windows.Forms.Button();
            this.bEliminarAlumno = new System.Windows.Forms.Button();
            this.bIntroducirAlumno = new System.Windows.Forms.Button();
            this.contenedor2.SuspendLayout();
            this.Contenedor1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contenedor2
            // 
            this.contenedor2.Controls.Add(this.bMostrarAluNotaMediaMenor5);
            this.contenedor2.Controls.Add(this.bMostrarAluNotaMediaMayor5);
            this.contenedor2.Controls.Add(this.bAñadirNotasAlumno);
            this.contenedor2.Controls.Add(this.bEliminarNotasAlumno);
            this.contenedor2.Location = new System.Drawing.Point(64, 224);
            this.contenedor2.Name = "contenedor2";
            this.contenedor2.Size = new System.Drawing.Size(673, 178);
            this.contenedor2.TabIndex = 3;
            this.contenedor2.TabStop = false;
            this.contenedor2.Text = "Notas";
            // 
            // bMostrarAluNotaMediaMenor5
            // 
            this.bMostrarAluNotaMediaMenor5.Location = new System.Drawing.Point(364, 99);
            this.bMostrarAluNotaMediaMenor5.Name = "bMostrarAluNotaMediaMenor5";
            this.bMostrarAluNotaMediaMenor5.Size = new System.Drawing.Size(279, 31);
            this.bMostrarAluNotaMediaMenor5.TabIndex = 5;
            this.bMostrarAluNotaMediaMenor5.Text = "Mostrar Alumnos con Nota Media menor a 5";
            this.bMostrarAluNotaMediaMenor5.UseVisualStyleBackColor = true;
            this.bMostrarAluNotaMediaMenor5.Click += new System.EventHandler(this.bMostrarAluNotaMediaMenor5_Click);
            // 
            // bMostrarAluNotaMediaMayor5
            // 
            this.bMostrarAluNotaMediaMayor5.Location = new System.Drawing.Point(364, 36);
            this.bMostrarAluNotaMediaMayor5.Name = "bMostrarAluNotaMediaMayor5";
            this.bMostrarAluNotaMediaMayor5.Size = new System.Drawing.Size(279, 31);
            this.bMostrarAluNotaMediaMayor5.TabIndex = 6;
            this.bMostrarAluNotaMediaMayor5.Text = "Mostrar Alumnos con Nota Media igual o superior a 5";
            this.bMostrarAluNotaMediaMayor5.UseVisualStyleBackColor = true;
            this.bMostrarAluNotaMediaMayor5.Click += new System.EventHandler(this.bMostrarAluNotaMediaMayor5_Click);
            // 
            // bAñadirNotasAlumno
            // 
            this.bAñadirNotasAlumno.Location = new System.Drawing.Point(24, 36);
            this.bAñadirNotasAlumno.Name = "bAñadirNotasAlumno";
            this.bAñadirNotasAlumno.Size = new System.Drawing.Size(262, 31);
            this.bAñadirNotasAlumno.TabIndex = 7;
            this.bAñadirNotasAlumno.Text = "Añadir Notas a Alumno";
            this.bAñadirNotasAlumno.UseVisualStyleBackColor = true;
            this.bAñadirNotasAlumno.Click += new System.EventHandler(this.bAñadirNotasAlumno_Click);
            // 
            // bEliminarNotasAlumno
            // 
            this.bEliminarNotasAlumno.Location = new System.Drawing.Point(24, 99);
            this.bEliminarNotasAlumno.Name = "bEliminarNotasAlumno";
            this.bEliminarNotasAlumno.Size = new System.Drawing.Size(262, 31);
            this.bEliminarNotasAlumno.TabIndex = 8;
            this.bEliminarNotasAlumno.Text = "Eliminar las Notas de un Alumno";
            this.bEliminarNotasAlumno.UseVisualStyleBackColor = true;
            this.bEliminarNotasAlumno.Click += new System.EventHandler(this.bEliminarNotasAlumno_Click);
            // 
            // Contenedor1
            // 
            this.Contenedor1.Controls.Add(this.bMostrarAlumnosDeCurso);
            this.Contenedor1.Controls.Add(this.bMostrarDatosAlumno);
            this.Contenedor1.Controls.Add(this.bOrdenarAlumnosAlfabeticamente);
            this.Contenedor1.Controls.Add(this.bMostrarListaAlumnos);
            this.Contenedor1.Controls.Add(this.bEliminarAlumno);
            this.Contenedor1.Controls.Add(this.bIntroducirAlumno);
            this.Contenedor1.Location = new System.Drawing.Point(64, 48);
            this.Contenedor1.Name = "Contenedor1";
            this.Contenedor1.Size = new System.Drawing.Size(673, 170);
            this.Contenedor1.TabIndex = 2;
            this.Contenedor1.TabStop = false;
            this.Contenedor1.Text = "Alumnos";
            // 
            // bMostrarAlumnosDeCurso
            // 
            this.bMostrarAlumnosDeCurso.Location = new System.Drawing.Point(159, 123);
            this.bMostrarAlumnosDeCurso.Name = "bMostrarAlumnosDeCurso";
            this.bMostrarAlumnosDeCurso.Size = new System.Drawing.Size(348, 31);
            this.bMostrarAlumnosDeCurso.TabIndex = 2;
            this.bMostrarAlumnosDeCurso.Text = "Mostrar Alumnos pertenecientes a un Curso";
            this.bMostrarAlumnosDeCurso.UseVisualStyleBackColor = true;
            this.bMostrarAlumnosDeCurso.Click += new System.EventHandler(this.bMostrarAlumnosDeCurso_Click);
            // 
            // bMostrarDatosAlumno
            // 
            this.bMostrarDatosAlumno.Location = new System.Drawing.Point(364, 69);
            this.bMostrarDatosAlumno.Name = "bMostrarDatosAlumno";
            this.bMostrarDatosAlumno.Size = new System.Drawing.Size(224, 31);
            this.bMostrarDatosAlumno.TabIndex = 2;
            this.bMostrarDatosAlumno.Text = "Mostrar Datos alumno (nombre)";
            this.bMostrarDatosAlumno.UseVisualStyleBackColor = true;
            this.bMostrarDatosAlumno.Click += new System.EventHandler(this.bMostrarDatosAlumno_Click);
            // 
            // bOrdenarAlumnosAlfabeticamente
            // 
            this.bOrdenarAlumnosAlfabeticamente.Location = new System.Drawing.Point(77, 69);
            this.bOrdenarAlumnosAlfabeticamente.Name = "bOrdenarAlumnosAlfabeticamente";
            this.bOrdenarAlumnosAlfabeticamente.Size = new System.Drawing.Size(209, 31);
            this.bOrdenarAlumnosAlfabeticamente.TabIndex = 4;
            this.bOrdenarAlumnosAlfabeticamente.Text = "Ordenar Alumnos Orden Alfabetico";
            this.bOrdenarAlumnosAlfabeticamente.UseVisualStyleBackColor = true;
            this.bOrdenarAlumnosAlfabeticamente.Click += new System.EventHandler(this.bOrdenarAlumnosAlfabeticamente_Click);
            // 
            // bMostrarListaAlumnos
            // 
            this.bMostrarListaAlumnos.Location = new System.Drawing.Point(503, 19);
            this.bMostrarListaAlumnos.Name = "bMostrarListaAlumnos";
            this.bMostrarListaAlumnos.Size = new System.Drawing.Size(140, 31);
            this.bMostrarListaAlumnos.TabIndex = 3;
            this.bMostrarListaAlumnos.Text = "Mostrar Lista Alumnos";
            this.bMostrarListaAlumnos.UseVisualStyleBackColor = true;
            this.bMostrarListaAlumnos.Click += new System.EventHandler(this.bMostrarListaAlumnos_Click);
            // 
            // bEliminarAlumno
            // 
            this.bEliminarAlumno.Location = new System.Drawing.Point(252, 19);
            this.bEliminarAlumno.Name = "bEliminarAlumno";
            this.bEliminarAlumno.Size = new System.Drawing.Size(140, 31);
            this.bEliminarAlumno.TabIndex = 2;
            this.bEliminarAlumno.Text = "Eliminar Alumno";
            this.bEliminarAlumno.UseVisualStyleBackColor = true;
            this.bEliminarAlumno.Click += new System.EventHandler(this.bEliminarAlumno_Click);
            // 
            // bIntroducirAlumno
            // 
            this.bIntroducirAlumno.Location = new System.Drawing.Point(24, 19);
            this.bIntroducirAlumno.Name = "bIntroducirAlumno";
            this.bIntroducirAlumno.Size = new System.Drawing.Size(140, 31);
            this.bIntroducirAlumno.TabIndex = 0;
            this.bIntroducirAlumno.Text = "Introducir Alumno";
            this.bIntroducirAlumno.UseVisualStyleBackColor = true;
            this.bIntroducirAlumno.Click += new System.EventHandler(this.bIntroducirAlumno_Click);
            // 
            // fAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.contenedor2);
            this.Controls.Add(this.Contenedor1);
            this.Name = "fAlumnos";
            this.Text = "Form1";
            this.contenedor2.ResumeLayout(false);
            this.Contenedor1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox contenedor2;
        private System.Windows.Forms.Button bMostrarAluNotaMediaMenor5;
        private System.Windows.Forms.Button bMostrarAluNotaMediaMayor5;
        private System.Windows.Forms.Button bAñadirNotasAlumno;
        private System.Windows.Forms.Button bEliminarNotasAlumno;
        private System.Windows.Forms.GroupBox Contenedor1;
        private System.Windows.Forms.Button bMostrarAlumnosDeCurso;
        private System.Windows.Forms.Button bMostrarDatosAlumno;
        private System.Windows.Forms.Button bOrdenarAlumnosAlfabeticamente;
        private System.Windows.Forms.Button bMostrarListaAlumnos;
        private System.Windows.Forms.Button bEliminarAlumno;
        private System.Windows.Forms.Button bIntroducirAlumno;
    }
}