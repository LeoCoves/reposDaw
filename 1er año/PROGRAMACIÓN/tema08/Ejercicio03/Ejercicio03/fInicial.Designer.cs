namespace Ejercicio03
{
    partial class fInicial
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
            this.btnMostrarFiguras = new System.Windows.Forms.Button();
            this.btnMostrarCirculos = new System.Windows.Forms.Button();
            this.btnMostrarCuadrados = new System.Windows.Forms.Button();
            this.btnCuadrado = new System.Windows.Forms.Button();
            this.btnCirculo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMostrarFiguras
            // 
            this.btnMostrarFiguras.Location = new System.Drawing.Point(455, 98);
            this.btnMostrarFiguras.Name = "btnMostrarFiguras";
            this.btnMostrarFiguras.Size = new System.Drawing.Size(150, 57);
            this.btnMostrarFiguras.TabIndex = 9;
            this.btnMostrarFiguras.Text = "Mostrar Todas las Figuras";
            this.btnMostrarFiguras.UseVisualStyleBackColor = true;
            this.btnMostrarFiguras.Click += new System.EventHandler(this.btnMostrarFiguras_Click);
            // 
            // btnMostrarCirculos
            // 
            this.btnMostrarCirculos.Location = new System.Drawing.Point(455, 198);
            this.btnMostrarCirculos.Name = "btnMostrarCirculos";
            this.btnMostrarCirculos.Size = new System.Drawing.Size(150, 57);
            this.btnMostrarCirculos.TabIndex = 8;
            this.btnMostrarCirculos.Text = "Mostrar Circulos";
            this.btnMostrarCirculos.UseVisualStyleBackColor = true;
            this.btnMostrarCirculos.Click += new System.EventHandler(this.btnMostrarCirculos_Click);
            // 
            // btnMostrarCuadrados
            // 
            this.btnMostrarCuadrados.Location = new System.Drawing.Point(455, 296);
            this.btnMostrarCuadrados.Name = "btnMostrarCuadrados";
            this.btnMostrarCuadrados.Size = new System.Drawing.Size(150, 57);
            this.btnMostrarCuadrados.TabIndex = 7;
            this.btnMostrarCuadrados.Text = "Mostrar Cuadrados";
            this.btnMostrarCuadrados.UseVisualStyleBackColor = true;
            this.btnMostrarCuadrados.Click += new System.EventHandler(this.btnMostrarCuadrados_Click);
            // 
            // btnCuadrado
            // 
            this.btnCuadrado.Location = new System.Drawing.Point(195, 246);
            this.btnCuadrado.Name = "btnCuadrado";
            this.btnCuadrado.Size = new System.Drawing.Size(150, 57);
            this.btnCuadrado.TabIndex = 6;
            this.btnCuadrado.Text = "Introducir Cuadrado";
            this.btnCuadrado.UseVisualStyleBackColor = true;
            this.btnCuadrado.Click += new System.EventHandler(this.btnCuadrado_Click);
            // 
            // btnCirculo
            // 
            this.btnCirculo.Location = new System.Drawing.Point(195, 148);
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Size = new System.Drawing.Size(150, 57);
            this.btnCirculo.TabIndex = 5;
            this.btnCirculo.Text = "Introducir Circulo";
            this.btnCirculo.UseVisualStyleBackColor = true;
            this.btnCirculo.Click += new System.EventHandler(this.btnCirculo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrarFiguras);
            this.Controls.Add(this.btnMostrarCirculos);
            this.Controls.Add(this.btnMostrarCuadrados);
            this.Controls.Add(this.btnCuadrado);
            this.Controls.Add(this.btnCirculo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarFiguras;
        private System.Windows.Forms.Button btnMostrarCirculos;
        private System.Windows.Forms.Button btnMostrarCuadrados;
        private System.Windows.Forms.Button btnCuadrado;
        private System.Windows.Forms.Button btnCirculo;
    }
}

