using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoComponentes2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_Instituto__1_DataSet.Profesores' Puede moverla o quitarla según sea necesario.
            this.profesoresTableAdapter.Fill(this._Instituto__1_DataSet.Profesores);

        }
    }
}
