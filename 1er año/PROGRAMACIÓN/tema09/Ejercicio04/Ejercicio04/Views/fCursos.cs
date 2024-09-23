using Ejercicio04.Models;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio04.Views
{
    public partial class fCursos : Form
    {
        public fCursos()
        {
            InitializeComponent();
        }

        // Instancia del objeto que maneja la BD.
        SqlDBHelper sqlDBHelper;
        // Variable que indica en qué registro estamos situados.
        private int pos;
        private string tabla = "Cursos";

        private void fCursos_Load(object sender, EventArgs e)
        {
            // Creamos el objeto BD
            sqlDBHelper = new SqlDBHelper(tabla);
            // Situamos la primera posición
            // y mostramos el registro
            pos = 0;
            mostrarRegistro(pos);
        }

        private void mostrarRegistro(int pos)
        {
            Curso curso;
            curso = sqlDBHelper.devuelveCurso(pos, tabla);
            // Ponemos los valores en los textBox correspondientes
            txtCodigo.Text = curso.Codigo.ToString();
            txtNombre.Text = curso.Nombre;

            lblMostrarNumRegistro.Text = "Registro " + (pos + 1) + " de " + sqlDBHelper.NumRegistros;
        }



        private void btnPrimero_Click(object sender, EventArgs e)
        {
            // Situamos la primera posición
            // y mostramos el registro
            pos = 0;
            mostrarRegistro(pos);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
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
            if (pos != sqlDBHelper.NumRegistros - 1)
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
            pos = sqlDBHelper.NumRegistros - 1;
            mostrarRegistro(pos);
        }

        private void btnAnyadir_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtNombre.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool validado = true;
            // Metemos los datos en el nuevo registro
            if (txtCodigo.Text == string.Empty)
            {
                MessageBox.Show("Campo Codigo No rellenado");
                validado = false;
            }
            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Campo Nombre No rellenado");
                validado = false;
            }

            if (validado)
            {
                // Creamos el profesor con los datos del formulario
                Curso curso = new Curso(int.Parse(txtCodigo.Text), txtNombre.Text);
                sqlDBHelper.anyadirCurso(curso, tabla);
                // Actualizamos la posición
                pos = sqlDBHelper.NumRegistros - 1;
            }
            mostrarRegistro(pos);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Curso curso = new Curso(int.Parse(txtCodigo.Text), txtNombre.Text);
            sqlDBHelper.actualizarCurso(curso, pos, tabla);
            MessageBox.Show("Actualizado correctamente");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult more;
            more = MessageBox.Show("Quieres eliminar el registro actual?", "Eliminar", MessageBoxButtons.YesNo);
            if (sqlDBHelper.NumRegistros >= 1)
            {
                if (more == DialogResult.Yes)
                {

                    sqlDBHelper.eliminarCurso(pos, tabla);
                    // Nos vamos al primer registro y lo mostramos
                    pos = 0;
                    mostrarRegistro(pos);
                    MessageBox.Show("Eliminado correctamente");
                }

            }
            else
            {
                MessageBox.Show("No hay registros por eliminar");
                txtCodigo.Clear();
                txtNombre.Clear();
            }

        }


        private void btnBuscarXNombre_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Introduzca el Nombre del Curso");
            string nombreMinuscula = nombre.ToLower();
            bool encontrado = false;
            pos = 0;

            if (!string.IsNullOrEmpty(nombre))
            {
                pos = sqlDBHelper.buscarXNombre(nombreMinuscula, ref encontrado, tabla);
                if (!encontrado)
                {
                    MessageBox.Show("No existe el nombre en la BD");
                }
                else
                {
                    mostrarRegistro(pos);
                }
            }
            else
            {
                MessageBox.Show("Campo Nombre vacio, vuelva a escribirlo");
            }
        }

        private void btnMostrarLista_Click(object sender, EventArgs e)
        {
            string listado = sqlDBHelper.mostrarListaCursos(tabla);
            MessageBox.Show(listado);
        }
    }
}
