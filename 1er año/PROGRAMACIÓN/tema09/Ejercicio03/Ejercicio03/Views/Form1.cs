using Ejercicio3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Instancia del objeto que maneja la BD.
        SqlDBHelper sqlDBHelper;
        // Variable que indica en qué registro estamos situados.
        private int pos;

        private void mostrarRegistro(int pos)
        {
            Coche coche;
            coche = sqlDBHelper.devuelveCoche(pos);
            // Ponemos los valores en los textBox correspondientes
            txtMatricula.Text = coche.Matricula;
            txtMarca.Text = coche.Marca;
            txtModelo.Text = coche.Modelo;
            txtPotencia.Text = coche.Potencia.ToString();
            txtColor.Text = coche.Color;
            txtAño.Text = coche.Anyo;
            txtPrecio.Text = coche.Precio.ToString();


            lblMostrarNumRegistro.Text = "Registro " + (pos + 1) + " de " + sqlDBHelper.NumCoches;

        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            pos = 0;
            mostrarRegistro(pos);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            // Vamos a la posición anterior.
            if (pos != 0)
            {
                pos--;
                mostrarRegistro(pos);
            }
            else
            {
                MessageBox.Show("No hay anterior");
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            // Vamos a la posición siguiente
            if (pos != sqlDBHelper.NumCoches - 1)
            {
                pos++;
                mostrarRegistro(pos);
            }
            else
            {
                MessageBox.Show("No hay mas registros");
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            // Vamos a la última posición.
            // Los registros van del 0 al numero de registros - 1
            pos = sqlDBHelper.NumCoches - 1;
            mostrarRegistro(pos);
        }

        private void btnAnyadir_Click(object sender, EventArgs e)
        {
            txtMatricula.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtPotencia.Clear();
            txtColor.Clear();
            txtAño.Clear();
            txtPrecio.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool validado = true;
            // Metemos los datos en el nuevo registro
            if (txtMatricula.Text == string.Empty)
            {
                MessageBox.Show("Campo Matricula No rellenado");
                validado = false;
            }
            if (txtMarca.Text == string.Empty)
            {
                MessageBox.Show("Campo Marca No rellenado");
                validado = false;
            }
            if (txtModelo.Text == string.Empty)
            {
                MessageBox.Show("Campo Modelo No rellenado");
                validado = false;
            }
            if (txtPotencia.Text == string.Empty)
            {
                MessageBox.Show("Campo Potencia No rellenado");
                validado = false;
            }
            if (txtColor.Text == string.Empty)
            {
                MessageBox.Show("Campo Color No rellenado");
                validado = false;
            }
            if (txtAño.Text == string.Empty)
            {
                MessageBox.Show("Campo Año No rellenado");
                validado = false;
            }
            if (txtPrecio.Text == string.Empty)
            {
                MessageBox.Show("Campo Precio No rellenado");
                validado = false;
            }

            if (validado)
            {
                // Creamos el profesor con los datos del formulario
                Coche coche = new Coche(txtMatricula.Text, txtMarca.Text,
                txtModelo.Text, int.Parse(txtPotencia.Text), txtColor.Text,
                txtAño.Text, double.Parse(txtPrecio.Text));
                sqlDBHelper.anyadirCoche(coche);
                // Actualizamos la posición
                pos = sqlDBHelper.NumCoches - 1;
            }
            mostrarRegistro(pos);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Creamos el profesor con los datos del formulario
            Coche coche = new Coche(txtMatricula.Text, txtMarca.Text,
            txtModelo.Text, int.Parse(txtPotencia.Text), txtColor.Text,
            txtAño.Text, double.Parse(txtPrecio.Text));
            sqlDBHelper.actualizarCoche(coche, pos);
            MessageBox.Show("Actualizado correctamente");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult more;
            more = MessageBox.Show("Quieres eliminar el registro actual?", "Eliminar", MessageBoxButtons.YesNo);
            if (sqlDBHelper.NumCoches >= 1)
            {
                if (more == DialogResult.Yes)
                {

                    sqlDBHelper.eliminarCoche(pos);
                    // Nos vamos al primer registro y lo mostramos
                    pos = 0;
                    mostrarRegistro(pos);
                    MessageBox.Show("Eliminado correctamente");
                }

            }
            else
            {
                MessageBox.Show("No hay registros por eliminar");
                txtMatricula.Clear();
                txtMarca.Clear();
                txtModelo.Clear();
                txtPotencia.Clear();
                txtColor.Clear();
                txtAño.Clear();
                txtPrecio.Clear();
            }
        }

        private void btnMostrarLista_Click(object sender, EventArgs e)
        {
            string listado = sqlDBHelper.mostrarListaCoches();
            MessageBox.Show(listado);
        }

        private void btnBuscarXModelo_Click(object sender, EventArgs e)
        {
            string modelo = Interaction.InputBox("Introduzca el modelo");
            string modeloMinuscula = modelo.ToLower();
            bool encontrado = false;
            pos = 0;

            if (!string.IsNullOrEmpty(modelo))
            {
                pos = sqlDBHelper.buscarXModelo(modeloMinuscula, ref encontrado);
                if (!encontrado)
                {
                    MessageBox.Show("No existe el modelo en la BD");
                }
                else
                {
                    mostrarRegistro(pos);
                }
            }
            else
            {
                MessageBox.Show("Modelo vacio, vuelva a escribirlo");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Creamos el objeto BD
            sqlDBHelper = new SqlDBHelper();
            // Situamos la primera posición
            // y mostramos el registro
            pos = 0;
            mostrarRegistro(pos);
        }
    }
}
