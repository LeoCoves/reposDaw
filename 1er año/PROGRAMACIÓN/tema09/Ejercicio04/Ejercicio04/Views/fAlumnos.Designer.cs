namespace Ejercicio04.Views
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
            this.lblMostrarNumRegistro = new System.Windows.Forms.Label();
            this.btnBuscarXApellido = new System.Windows.Forms.Button();
            this.btnMostrarLista = new System.Windows.Forms.Button();
            this.grpModificar = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.grpAnyadir = new System.Windows.Forms.GroupBox();
            this.btnAnyadir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grpNavegar = new System.Windows.Forms.GroupBox();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTlf = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.grpModificar.SuspendLayout();
            this.grpAnyadir.SuspendLayout();
            this.grpNavegar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMostrarNumRegistro
            // 
            this.lblMostrarNumRegistro.AutoSize = true;
            this.lblMostrarNumRegistro.Location = new System.Drawing.Point(347, 148);
            this.lblMostrarNumRegistro.Name = "lblMostrarNumRegistro";
            this.lblMostrarNumRegistro.Size = new System.Drawing.Size(10, 13);
            this.lblMostrarNumRegistro.TabIndex = 39;
            this.lblMostrarNumRegistro.Text = ".";
            // 
            // btnBuscarXApellido
            // 
            this.btnBuscarXApellido.Location = new System.Drawing.Point(548, 101);
            this.btnBuscarXApellido.Name = "btnBuscarXApellido";
            this.btnBuscarXApellido.Size = new System.Drawing.Size(171, 42);
            this.btnBuscarXApellido.TabIndex = 38;
            this.btnBuscarXApellido.Text = "Buscar X Apellido";
            this.btnBuscarXApellido.UseVisualStyleBackColor = true;
            this.btnBuscarXApellido.Click += new System.EventHandler(this.btnBuscarXApellido_Click);
            // 
            // btnMostrarLista
            // 
            this.btnMostrarLista.Location = new System.Drawing.Point(548, 32);
            this.btnMostrarLista.Name = "btnMostrarLista";
            this.btnMostrarLista.Size = new System.Drawing.Size(171, 42);
            this.btnMostrarLista.TabIndex = 37;
            this.btnMostrarLista.Text = "Mostrar Lista";
            this.btnMostrarLista.UseVisualStyleBackColor = true;
            this.btnMostrarLista.Click += new System.EventHandler(this.btnMostrarLista_Click);
            // 
            // grpModificar
            // 
            this.grpModificar.Controls.Add(this.btnEliminar);
            this.grpModificar.Controls.Add(this.btnActualizar);
            this.grpModificar.Location = new System.Drawing.Point(417, 321);
            this.grpModificar.Name = "grpModificar";
            this.grpModificar.Size = new System.Drawing.Size(302, 100);
            this.grpModificar.TabIndex = 36;
            this.grpModificar.TabStop = false;
            this.grpModificar.Text = "Modificar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(161, 31);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(118, 42);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(22, 31);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(118, 42);
            this.btnActualizar.TabIndex = 22;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // grpAnyadir
            // 
            this.grpAnyadir.Controls.Add(this.btnAnyadir);
            this.grpAnyadir.Controls.Add(this.btnGuardar);
            this.grpAnyadir.Location = new System.Drawing.Point(82, 321);
            this.grpAnyadir.Name = "grpAnyadir";
            this.grpAnyadir.Size = new System.Drawing.Size(299, 100);
            this.grpAnyadir.TabIndex = 35;
            this.grpAnyadir.TabStop = false;
            this.grpAnyadir.Text = "Añadir";
            // 
            // btnAnyadir
            // 
            this.btnAnyadir.Location = new System.Drawing.Point(14, 31);
            this.btnAnyadir.Name = "btnAnyadir";
            this.btnAnyadir.Size = new System.Drawing.Size(118, 42);
            this.btnAnyadir.TabIndex = 20;
            this.btnAnyadir.Text = "Añadir";
            this.btnAnyadir.UseVisualStyleBackColor = true;
            this.btnAnyadir.Click += new System.EventHandler(this.btnAnyadir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(165, 31);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(123, 42);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar Nuevo";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // grpNavegar
            // 
            this.grpNavegar.Controls.Add(this.btnUltimo);
            this.grpNavegar.Controls.Add(this.btnSiguiente);
            this.grpNavegar.Controls.Add(this.btnAnterior);
            this.grpNavegar.Controls.Add(this.btnPrimero);
            this.grpNavegar.Location = new System.Drawing.Point(82, 183);
            this.grpNavegar.Name = "grpNavegar";
            this.grpNavegar.Size = new System.Drawing.Size(637, 100);
            this.grpNavegar.TabIndex = 34;
            this.grpNavegar.TabStop = false;
            this.grpNavegar.Text = "Navegar";
            // 
            // btnUltimo
            // 
            this.btnUltimo.Location = new System.Drawing.Point(466, 32);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(129, 42);
            this.btnUltimo.TabIndex = 22;
            this.btnUltimo.Text = "Ultimo";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(326, 32);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(129, 42);
            this.btnSiguiente.TabIndex = 21;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(180, 32);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(129, 42);
            this.btnAnterior.TabIndex = 20;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnPrimero
            // 
            this.btnPrimero.Location = new System.Drawing.Point(36, 32);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(129, 42);
            this.btnPrimero.TabIndex = 19;
            this.btnPrimero.Text = "Primero";
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(396, 29);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 33;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(396, 63);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 32;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(396, 101);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 31;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(173, 101);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(131, 20);
            this.txtApellido.TabIndex = 29;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(173, 63);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(131, 20);
            this.txtNombre.TabIndex = 28;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(173, 29);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(131, 20);
            this.txtDni.TabIndex = 27;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(332, 104);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 25;
            this.lblEmail.Text = "Email";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(332, 32);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 24;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblTlf
            // 
            this.lblTlf.AutoSize = true;
            this.lblTlf.Location = new System.Drawing.Point(332, 66);
            this.lblTlf.Name = "lblTlf";
            this.lblTlf.Size = new System.Drawing.Size(49, 13);
            this.lblTlf.TabIndex = 23;
            this.lblTlf.Text = "Telefono";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(93, 108);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 22;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(93, 70);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 21;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(93, 37);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(23, 13);
            this.lblDni.TabIndex = 20;
            this.lblDni.Text = "Dni";
            // 
            // fAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMostrarNumRegistro);
            this.Controls.Add(this.btnBuscarXApellido);
            this.Controls.Add(this.btnMostrarLista);
            this.Controls.Add(this.grpModificar);
            this.Controls.Add(this.grpAnyadir);
            this.Controls.Add(this.grpNavegar);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblTlf);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDni);
            this.Name = "fAlumnos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.fAlumnos_Load);
            this.grpModificar.ResumeLayout(false);
            this.grpAnyadir.ResumeLayout(false);
            this.grpNavegar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMostrarNumRegistro;
        private System.Windows.Forms.Button btnBuscarXApellido;
        private System.Windows.Forms.Button btnMostrarLista;
        private System.Windows.Forms.GroupBox grpModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.GroupBox grpAnyadir;
        private System.Windows.Forms.Button btnAnyadir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox grpNavegar;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTlf;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDni;
    }
}