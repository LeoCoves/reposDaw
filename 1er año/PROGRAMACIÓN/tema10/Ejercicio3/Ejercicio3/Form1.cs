using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'concesionarioDataSet.COCHES' Puede moverla o quitarla según sea necesario.
            this.COCHESTableAdapter.Fill(this.concesionarioDataSet.COCHES);

        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            COCHESbindingSource.MoveFirst();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            COCHESbindingSource.MovePrevious();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            COCHESbindingSource.MoveNext();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            COCHESbindingSource.MoveLast();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            COCHESbindingSource.AddNew();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            COCHESbindingSource.EndEdit();
            COCHESTableAdapter.Update(concesionarioDataSet.COCHES);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            COCHESbindingSource.EndEdit();
            COCHESTableAdapter.Update(concesionarioDataSet.COCHES);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            COCHESbindingSource.RemoveCurrent();
            // Actualiza la BD
            COCHESTableAdapter.Update(concesionarioDataSet.COCHES);
        }

        private void btnMostrarLista_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarXModelo_Click(object sender, EventArgs e)
        {

        }
    }
}
