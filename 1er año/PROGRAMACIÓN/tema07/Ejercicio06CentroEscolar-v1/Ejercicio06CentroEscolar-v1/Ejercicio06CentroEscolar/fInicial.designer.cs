namespace Ejercicio06CentroEscolar
{
    partial class fInicial
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bCursos = new System.Windows.Forms.Button();
            this.bAlumnos = new System.Windows.Forms.Button();
            this.bProfesores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bCursos
            // 
            this.bCursos.Location = new System.Drawing.Point(72, 47);
            this.bCursos.Name = "bCursos";
            this.bCursos.Size = new System.Drawing.Size(136, 29);
            this.bCursos.TabIndex = 0;
            this.bCursos.Text = "Gestión de Cursos";
            this.bCursos.UseVisualStyleBackColor = true;
            this.bCursos.Click += new System.EventHandler(this.bCursos_Click);
            // 
            // bAlumnos
            // 
            this.bAlumnos.Location = new System.Drawing.Point(72, 98);
            this.bAlumnos.Name = "bAlumnos";
            this.bAlumnos.Size = new System.Drawing.Size(136, 33);
            this.bAlumnos.TabIndex = 1;
            this.bAlumnos.Text = "Gestión de Alumnos";
            this.bAlumnos.UseVisualStyleBackColor = true;
            this.bAlumnos.Click += new System.EventHandler(this.bAlumnos_Click);
            // 
            // bProfesores
            // 
            this.bProfesores.Location = new System.Drawing.Point(72, 154);
            this.bProfesores.Name = "bProfesores";
            this.bProfesores.Size = new System.Drawing.Size(136, 32);
            this.bProfesores.TabIndex = 2;
            this.bProfesores.Text = "Gestión de Profesores";
            this.bProfesores.UseVisualStyleBackColor = true;
            this.bProfesores.Click += new System.EventHandler(this.bProfesores_Click);
            // 
            // fInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.bProfesores);
            this.Controls.Add(this.bAlumnos);
            this.Controls.Add(this.bCursos);
            this.Name = "fInicial";
            this.Text = "Gestión de Instituto";
            this.Load += new System.EventHandler(this.fInicial_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bCursos;
        private System.Windows.Forms.Button bAlumnos;
        private System.Windows.Forms.Button bProfesores;
    }
}

