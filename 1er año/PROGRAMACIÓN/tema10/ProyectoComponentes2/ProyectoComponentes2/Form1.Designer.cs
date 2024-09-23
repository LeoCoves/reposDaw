namespace ProyectoComponentes2
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
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._Instituto__1_DataSet = new ProyectoComponentes2._Instituto__1_DataSet();
            this.profesoresTableAdapter = new ProyectoComponentes2._Instituto__1_DataSetTableAdapters.ProfesoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Instituto__1_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDni
            // 
            this.txtDni.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "DNI", true));
            this.txtDni.Location = new System.Drawing.Point(97, 58);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Nombre", true));
            this.txtNombre.Location = new System.Drawing.Point(97, 119);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Profesores";
            this.bindingSource1.DataSource = this._Instituto__1_DataSet;
            // 
            // _Instituto__1_DataSet
            // 
            this._Instituto__1_DataSet.DataSetName = "_Instituto__1_DataSet";
            this._Instituto__1_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // profesoresTableAdapter
            // 
            this.profesoresTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDni);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Instituto__1_DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.BindingSource bindingSource1;
        private _Instituto__1_DataSet _Instituto__1_DataSet;
        private _Instituto__1_DataSetTableAdapters.ProfesoresTableAdapter profesoresTableAdapter;
    }
}

