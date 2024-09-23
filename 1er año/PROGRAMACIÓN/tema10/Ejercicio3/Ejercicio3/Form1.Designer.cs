namespace Ejercicio3
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
            this.components = new System.ComponentModel.Container();
            this.COCHESbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.concesionarioDataSet = new Ejercicio3.ConcesionarioDataSet();
            this.COCHESTableAdapter = new Ejercicio3.ConcesionarioDataSetTableAdapters.COCHESTableAdapter();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtPotencia = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblPotencia = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grpNavegar = new System.Windows.Forms.GroupBox();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.grpModificar = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnMostrarLista = new System.Windows.Forms.Button();
            this.grpActualizar = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBuscarXModelo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.COCHESbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concesionarioDataSet)).BeginInit();
            this.grpNavegar.SuspendLayout();
            this.grpModificar.SuspendLayout();
            this.grpActualizar.SuspendLayout();
            this.SuspendLayout();
            // 
            // COCHESbindingSource
            // 
            this.COCHESbindingSource.DataMember = "COCHES";
            this.COCHESbindingSource.DataSource = this.concesionarioDataSet;
            // 
            // concesionarioDataSet
            // 
            this.concesionarioDataSet.DataSetName = "ConcesionarioDataSet";
            this.concesionarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // COCHESTableAdapter
            // 
            this.COCHESTableAdapter.ClearBeforeFill = true;
            // 
            // txtMatricula
            // 
            this.txtMatricula.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.COCHESbindingSource, "Matricula", true));
            this.txtMatricula.Location = new System.Drawing.Point(120, 49);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 0;
            // 
            // txtPrecio
            // 
            this.txtPrecio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.COCHESbindingSource, "Precio", true));
            this.txtPrecio.Location = new System.Drawing.Point(354, 142);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 1;
            // 
            // txtAño
            // 
            this.txtAño.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.COCHESbindingSource, "Año", true));
            this.txtAño.Location = new System.Drawing.Point(354, 94);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(100, 20);
            this.txtAño.TabIndex = 2;
            // 
            // txtColor
            // 
            this.txtColor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.COCHESbindingSource, "Color", true));
            this.txtColor.Location = new System.Drawing.Point(354, 45);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 3;
            // 
            // txtPotencia
            // 
            this.txtPotencia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.COCHESbindingSource, "PotenciaCV", true));
            this.txtPotencia.Location = new System.Drawing.Point(120, 198);
            this.txtPotencia.Name = "txtPotencia";
            this.txtPotencia.Size = new System.Drawing.Size(100, 20);
            this.txtPotencia.TabIndex = 4;
            // 
            // txtModelo
            // 
            this.txtModelo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.COCHESbindingSource, "Modelo", true));
            this.txtModelo.Location = new System.Drawing.Point(120, 142);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 5;
            // 
            // txtMarca
            // 
            this.txtMarca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.COCHESbindingSource, "Marca", true));
            this.txtMarca.Location = new System.Drawing.Point(120, 94);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 6;
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(36, 52);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(50, 13);
            this.lblMatricula.TabIndex = 7;
            this.lblMatricula.Text = "Matricula";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(36, 97);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 8;
            this.lblMarca.Text = "Marca";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(36, 145);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 9;
            this.lblModelo.Text = "Modelo";
            // 
            // lblPotencia
            // 
            this.lblPotencia.AutoSize = true;
            this.lblPotencia.Location = new System.Drawing.Point(36, 201);
            this.lblPotencia.Name = "lblPotencia";
            this.lblPotencia.Size = new System.Drawing.Size(63, 13);
            this.lblPotencia.TabIndex = 10;
            this.lblPotencia.Text = "PotenciaCV";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(257, 56);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 11;
            this.lblColor.Text = "Color";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(257, 94);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(26, 13);
            this.lblPrecio.TabIndex = 12;
            this.lblPrecio.Text = "Año";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(257, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Precio";
            // 
            // grpNavegar
            // 
            this.grpNavegar.Controls.Add(this.btnUltimo);
            this.grpNavegar.Controls.Add(this.btnSiguiente);
            this.grpNavegar.Controls.Add(this.btnAnterior);
            this.grpNavegar.Controls.Add(this.btnPrimero);
            this.grpNavegar.Location = new System.Drawing.Point(39, 239);
            this.grpNavegar.Name = "grpNavegar";
            this.grpNavegar.Size = new System.Drawing.Size(725, 83);
            this.grpNavegar.TabIndex = 14;
            this.grpNavegar.TabStop = false;
            this.grpNavegar.Text = "Navegar";
            // 
            // btnUltimo
            // 
            this.btnUltimo.Location = new System.Drawing.Point(565, 19);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(130, 48);
            this.btnUltimo.TabIndex = 3;
            this.btnUltimo.Text = "Ultimo";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(396, 19);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(130, 48);
            this.btnSiguiente.TabIndex = 2;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(207, 19);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(130, 48);
            this.btnAnterior.TabIndex = 1;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnPrimero
            // 
            this.btnPrimero.Location = new System.Drawing.Point(30, 19);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(130, 48);
            this.btnPrimero.TabIndex = 0;
            this.btnPrimero.Text = "Primero";
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // grpModificar
            // 
            this.grpModificar.Controls.Add(this.btnGuardar);
            this.grpModificar.Controls.Add(this.btnNuevo);
            this.grpModificar.Location = new System.Drawing.Point(39, 338);
            this.grpModificar.Name = "grpModificar";
            this.grpModificar.Size = new System.Drawing.Size(359, 85);
            this.grpModificar.TabIndex = 15;
            this.grpModificar.TabStop = false;
            this.grpModificar.Text = "Modificar";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(207, 19);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(130, 48);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar Nuevo";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(30, 19);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(130, 48);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnMostrarLista
            // 
            this.btnMostrarLista.Location = new System.Drawing.Point(533, 52);
            this.btnMostrarLista.Name = "btnMostrarLista";
            this.btnMostrarLista.Size = new System.Drawing.Size(220, 48);
            this.btnMostrarLista.TabIndex = 6;
            this.btnMostrarLista.Text = "Mostrar Lista";
            this.btnMostrarLista.UseVisualStyleBackColor = true;
            this.btnMostrarLista.Click += new System.EventHandler(this.btnMostrarLista_Click);
            // 
            // grpActualizar
            // 
            this.grpActualizar.Controls.Add(this.btnEliminar);
            this.grpActualizar.Controls.Add(this.btnActualizar);
            this.grpActualizar.Location = new System.Drawing.Point(423, 338);
            this.grpActualizar.Name = "grpActualizar";
            this.grpActualizar.Size = new System.Drawing.Size(341, 85);
            this.grpActualizar.TabIndex = 16;
            this.grpActualizar.TabStop = false;
            this.grpActualizar.Text = "Actualizar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(181, 19);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(130, 48);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(12, 22);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(130, 48);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBuscarXModelo
            // 
            this.btnBuscarXModelo.Location = new System.Drawing.Point(533, 128);
            this.btnBuscarXModelo.Name = "btnBuscarXModelo";
            this.btnBuscarXModelo.Size = new System.Drawing.Size(220, 46);
            this.btnBuscarXModelo.TabIndex = 17;
            this.btnBuscarXModelo.Text = "Buscar X modelo";
            this.btnBuscarXModelo.UseVisualStyleBackColor = true;
            this.btnBuscarXModelo.Click += new System.EventHandler(this.btnBuscarXModelo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscarXModelo);
            this.Controls.Add(this.grpActualizar);
            this.Controls.Add(this.btnMostrarLista);
            this.Controls.Add(this.grpModificar);
            this.Controls.Add(this.grpNavegar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblPotencia);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtPotencia);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtMatricula);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.COCHESbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concesionarioDataSet)).EndInit();
            this.grpNavegar.ResumeLayout(false);
            this.grpModificar.ResumeLayout(false);
            this.grpActualizar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource COCHESbindingSource;
        private ConcesionarioDataSet concesionarioDataSet;
        private ConcesionarioDataSetTableAdapters.COCHESTableAdapter COCHESTableAdapter;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtPotencia;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblPotencia;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpNavegar;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.GroupBox grpModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnMostrarLista;
        private System.Windows.Forms.GroupBox grpActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBuscarXModelo;
    }
}

