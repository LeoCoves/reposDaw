namespace Ejercicio01
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
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtTlf = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTlf = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.grpNavegar = new System.Windows.Forms.GroupBox();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.grpAñadir = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.grpModificar = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblMostrarNumRegistro = new System.Windows.Forms.Label();
            this.btnMostrarLista = new System.Windows.Forms.Button();
            this.btnBuscarApellido = new System.Windows.Forms.Button();
            this.grpNavegar.SuspendLayout();
            this.grpAñadir.SuspendLayout();
            this.grpModificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(179, 51);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 20);
            this.txtDNI.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(488, 100);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(488, 51);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(100, 20);
            this.txtApellidos.TabIndex = 2;
            // 
            // txtTlf
            // 
            this.txtTlf.Location = new System.Drawing.Point(179, 154);
            this.txtTlf.Name = "txtTlf";
            this.txtTlf.Size = new System.Drawing.Size(100, 20);
            this.txtTlf.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(179, 100);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(78, 57);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(26, 13);
            this.lblDNI.TabIndex = 5;
            this.lblDNI.Text = "DNI";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(78, 103);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // lblTlf
            // 
            this.lblTlf.AutoSize = true;
            this.lblTlf.Location = new System.Drawing.Point(78, 157);
            this.lblTlf.Name = "lblTlf";
            this.lblTlf.Size = new System.Drawing.Size(49, 13);
            this.lblTlf.TabIndex = 7;
            this.lblTlf.Text = "Telefono";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(414, 58);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(49, 13);
            this.lblApellidos.TabIndex = 8;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(414, 107);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email";
            // 
            // grpNavegar
            // 
            this.grpNavegar.Controls.Add(this.btnUltimo);
            this.grpNavegar.Controls.Add(this.btnSiguiente);
            this.grpNavegar.Controls.Add(this.btnAnterior);
            this.grpNavegar.Controls.Add(this.btnPrimero);
            this.grpNavegar.Location = new System.Drawing.Point(53, 210);
            this.grpNavegar.Name = "grpNavegar";
            this.grpNavegar.Size = new System.Drawing.Size(682, 100);
            this.grpNavegar.TabIndex = 10;
            this.grpNavegar.TabStop = false;
            this.grpNavegar.Text = "Navegar";
            // 
            // btnUltimo
            // 
            this.btnUltimo.Location = new System.Drawing.Point(539, 31);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(115, 39);
            this.btnUltimo.TabIndex = 3;
            this.btnUltimo.Text = "Ultimo";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(364, 29);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(115, 41);
            this.btnSiguiente.TabIndex = 2;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(189, 31);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(119, 39);
            this.btnAnterior.TabIndex = 1;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnPrimero
            // 
            this.btnPrimero.Location = new System.Drawing.Point(28, 33);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(108, 39);
            this.btnPrimero.TabIndex = 0;
            this.btnPrimero.Text = "Primero";
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // grpAñadir
            // 
            this.grpAñadir.Controls.Add(this.btnGuardar);
            this.grpAñadir.Controls.Add(this.btnCrear);
            this.grpAñadir.Location = new System.Drawing.Point(53, 330);
            this.grpAñadir.Name = "grpAñadir";
            this.grpAñadir.Size = new System.Drawing.Size(323, 100);
            this.grpAñadir.TabIndex = 11;
            this.grpAñadir.TabStop = false;
            this.grpAñadir.Text = "Añadir Profesor";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(172, 39);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(108, 36);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar Nuevo";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(28, 39);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(108, 36);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Añadir";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // grpModificar
            // 
            this.grpModificar.Controls.Add(this.btnEliminar);
            this.grpModificar.Controls.Add(this.btnActualizar);
            this.grpModificar.Location = new System.Drawing.Point(412, 330);
            this.grpModificar.Name = "grpModificar";
            this.grpModificar.Size = new System.Drawing.Size(323, 100);
            this.grpModificar.TabIndex = 12;
            this.grpModificar.TabStop = false;
            this.grpModificar.Text = "Modificar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(180, 39);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(108, 36);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(38, 39);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(108, 36);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblMostrarNumRegistro
            // 
            this.lblMostrarNumRegistro.AutoSize = true;
            this.lblMostrarNumRegistro.Location = new System.Drawing.Point(647, 80);
            this.lblMostrarNumRegistro.Name = "lblMostrarNumRegistro";
            this.lblMostrarNumRegistro.Size = new System.Drawing.Size(10, 13);
            this.lblMostrarNumRegistro.TabIndex = 13;
            this.lblMostrarNumRegistro.Text = ".";
            // 
            // btnMostrarLista
            // 
            this.btnMostrarLista.Location = new System.Drawing.Point(334, 162);
            this.btnMostrarLista.Name = "btnMostrarLista";
            this.btnMostrarLista.Size = new System.Drawing.Size(112, 32);
            this.btnMostrarLista.TabIndex = 14;
            this.btnMostrarLista.Text = "Mostrar Lista";
            this.btnMostrarLista.UseVisualStyleBackColor = true;
            this.btnMostrarLista.Click += new System.EventHandler(this.btnMostrarLista_Click);
            // 
            // btnBuscarApellido
            // 
            this.btnBuscarApellido.Location = new System.Drawing.Point(503, 162);
            this.btnBuscarApellido.Name = "btnBuscarApellido";
            this.btnBuscarApellido.Size = new System.Drawing.Size(112, 32);
            this.btnBuscarApellido.TabIndex = 15;
            this.btnBuscarApellido.Text = "Buscar x Apellido";
            this.btnBuscarApellido.UseVisualStyleBackColor = true;
            this.btnBuscarApellido.Click += new System.EventHandler(this.btnBuscarApellido_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscarApellido);
            this.Controls.Add(this.btnMostrarLista);
            this.Controls.Add(this.lblMostrarNumRegistro);
            this.Controls.Add(this.grpModificar);
            this.Controls.Add(this.grpAñadir);
            this.Controls.Add(this.grpNavegar);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblTlf);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtTlf);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDNI);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpNavegar.ResumeLayout(false);
            this.grpAñadir.ResumeLayout(false);
            this.grpModificar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtTlf;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTlf;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.GroupBox grpNavegar;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.GroupBox grpAñadir;
        private System.Windows.Forms.GroupBox grpModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblMostrarNumRegistro;
        private System.Windows.Forms.Button btnMostrarLista;
        private System.Windows.Forms.Button btnBuscarApellido;
    }
}

