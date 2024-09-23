namespace Ejercicio03
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
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblPotencia = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtPotencia = new System.Windows.Forms.TextBox();
            this.grpNavegar = new System.Windows.Forms.GroupBox();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.grpAnyadir = new System.Windows.Forms.GroupBox();
            this.btnAnyadir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grpModificar = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnMostrarLista = new System.Windows.Forms.Button();
            this.btnBuscarXModelo = new System.Windows.Forms.Button();
            this.lblMostrarNumRegistro = new System.Windows.Forms.Label();
            this.grpNavegar.SuspendLayout();
            this.grpAnyadir.SuspendLayout();
            this.grpModificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(34, 39);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(50, 13);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matricula";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(34, 72);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Marca";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(34, 110);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 2;
            this.lblModelo.Text = "Modelo";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(285, 39);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 3;
            this.lblColor.Text = "Color";
            // 
            // lblPotencia
            // 
            this.lblPotencia.AutoSize = true;
            this.lblPotencia.Location = new System.Drawing.Point(34, 150);
            this.lblPotencia.Name = "lblPotencia";
            this.lblPotencia.Size = new System.Drawing.Size(49, 13);
            this.lblPotencia.TabIndex = 4;
            this.lblPotencia.Text = "Potencia";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(285, 72);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(26, 13);
            this.lblAño.TabIndex = 5;
            this.lblAño.Text = "Año";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(285, 110);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(114, 31);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(131, 20);
            this.txtMatricula.TabIndex = 7;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(114, 65);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(131, 20);
            this.txtMarca.TabIndex = 8;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(114, 103);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(131, 20);
            this.txtModelo.TabIndex = 9;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(337, 103);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 10;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(337, 65);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(100, 20);
            this.txtAño.TabIndex = 11;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(337, 32);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 12;
            // 
            // txtPotencia
            // 
            this.txtPotencia.Location = new System.Drawing.Point(114, 143);
            this.txtPotencia.Name = "txtPotencia";
            this.txtPotencia.Size = new System.Drawing.Size(131, 20);
            this.txtPotencia.TabIndex = 13;
            // 
            // grpNavegar
            // 
            this.grpNavegar.Controls.Add(this.btnUltimo);
            this.grpNavegar.Controls.Add(this.btnSiguiente);
            this.grpNavegar.Controls.Add(this.btnAnterior);
            this.grpNavegar.Controls.Add(this.btnPrimero);
            this.grpNavegar.Location = new System.Drawing.Point(23, 185);
            this.grpNavegar.Name = "grpNavegar";
            this.grpNavegar.Size = new System.Drawing.Size(637, 100);
            this.grpNavegar.TabIndex = 14;
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
            // grpAnyadir
            // 
            this.grpAnyadir.Controls.Add(this.btnAnyadir);
            this.grpAnyadir.Controls.Add(this.btnGuardar);
            this.grpAnyadir.Location = new System.Drawing.Point(23, 323);
            this.grpAnyadir.Name = "grpAnyadir";
            this.grpAnyadir.Size = new System.Drawing.Size(299, 100);
            this.grpAnyadir.TabIndex = 15;
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
            // grpModificar
            // 
            this.grpModificar.Controls.Add(this.btnEliminar);
            this.grpModificar.Controls.Add(this.btnActualizar);
            this.grpModificar.Location = new System.Drawing.Point(358, 323);
            this.grpModificar.Name = "grpModificar";
            this.grpModificar.Size = new System.Drawing.Size(302, 100);
            this.grpModificar.TabIndex = 16;
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
            // btnMostrarLista
            // 
            this.btnMostrarLista.Location = new System.Drawing.Point(489, 34);
            this.btnMostrarLista.Name = "btnMostrarLista";
            this.btnMostrarLista.Size = new System.Drawing.Size(171, 42);
            this.btnMostrarLista.TabIndex = 17;
            this.btnMostrarLista.Text = "Mostrar Lista";
            this.btnMostrarLista.UseVisualStyleBackColor = true;
            this.btnMostrarLista.Click += new System.EventHandler(this.btnMostrarLista_Click);
            // 
            // btnBuscarXModelo
            // 
            this.btnBuscarXModelo.Location = new System.Drawing.Point(489, 103);
            this.btnBuscarXModelo.Name = "btnBuscarXModelo";
            this.btnBuscarXModelo.Size = new System.Drawing.Size(171, 42);
            this.btnBuscarXModelo.TabIndex = 18;
            this.btnBuscarXModelo.Text = "Buscar X Modelo";
            this.btnBuscarXModelo.UseVisualStyleBackColor = true;
            this.btnBuscarXModelo.Click += new System.EventHandler(this.btnBuscarXModelo_Click);
            // 
            // lblMostrarNumRegistro
            // 
            this.lblMostrarNumRegistro.AutoSize = true;
            this.lblMostrarNumRegistro.Location = new System.Drawing.Point(288, 150);
            this.lblMostrarNumRegistro.Name = "lblMostrarNumRegistro";
            this.lblMostrarNumRegistro.Size = new System.Drawing.Size(10, 13);
            this.lblMostrarNumRegistro.TabIndex = 19;
            this.lblMostrarNumRegistro.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 450);
            this.Controls.Add(this.lblMostrarNumRegistro);
            this.Controls.Add(this.btnBuscarXModelo);
            this.Controls.Add(this.btnMostrarLista);
            this.Controls.Add(this.grpModificar);
            this.Controls.Add(this.grpAnyadir);
            this.Controls.Add(this.grpNavegar);
            this.Controls.Add(this.txtPotencia);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.lblPotencia);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblMatricula);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpNavegar.ResumeLayout(false);
            this.grpAnyadir.ResumeLayout(false);
            this.grpModificar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblPotencia;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtPotencia;
        private System.Windows.Forms.GroupBox grpNavegar;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.GroupBox grpAnyadir;
        private System.Windows.Forms.Button btnAnyadir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox grpModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnMostrarLista;
        private System.Windows.Forms.Button btnBuscarXModelo;
        private System.Windows.Forms.Label lblMostrarNumRegistro;
    }
}

