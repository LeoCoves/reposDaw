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
    public partial class fProfesores : Form
    {
        public fProfesores()
        {
            InitializeComponent();
        }

        
        // Variable que indica en qué registro estamos situados.
        private int pos;
        private string tabla = "Profesores";
        SqlDBHelper sqlDBHelper;


        private void fProfesores_Load(object sender, EventArgs e)
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
            Profesor profesor;
            profesor = sqlDBHelper.devuelveProfesor(pos, tabla);
            // Ponemos los valores en los textBox correspondientes
            txtDni.Text = profesor.Dni;
            txtNombre.Text = profesor.Nombre;
            txtApellidos.Text = profesor.Apellidos;
            txtTelefono.Text = profesor.Tlf;
            txtEmail.Text = profesor.Email;

            lblMostrarNumRegistro.Text = "Registro " + (pos + 1) + " de " + sqlDBHelper.NumRegistros;

        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            // Ponemos la primera posición
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
            txtDni.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool validado = true;
            // Metemos los datos en el nuevo registro
            if (txtDni.Text == string.Empty)
            {
                MessageBox.Show("Campo DNI No rellenado");
                validado = false;
            }
            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Campo Nombre No rellenado");
                validado = false;
            }
            if (txtApellidos.Text == string.Empty)
            {
                MessageBox.Show("Campo Apellidos No rellenado");
                validado = false;
            }
            if (txtTelefono.Text == string.Empty)
            {
                MessageBox.Show("Campo Telefono No rellenado");
                validado = false;
            }
            if (txtEmail.Text == string.Empty)
            {
                MessageBox.Show("Campo Email No rellenado");
                validado = false;
            }

            if (validado)
            {
                // Creamos el profesor con los datos del formulario
                Profesor profesor = new Profesor(txtDni.Text, txtNombre.Text,
                txtApellidos.Text, txtTelefono.Text, txtEmail.Text);
                sqlDBHelper.anyadirProfesor(profesor, tabla);
                // Actualizamos la posición
                pos = sqlDBHelper.NumRegistros - 1;
            }
            mostrarRegistro(pos);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Creamos el profesor con los datos del formulario
            Profesor profesor = new Profesor(txtDni.Text, txtNombre.Text,
            txtApellidos.Text, txtTelefono.Text, txtEmail.Text);
            sqlDBHelper.actualizarProfesor(profesor, pos, tabla);
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

                    sqlDBHelper.eliminarProfesor(pos, tabla);
                    // Nos vamos al primer registro y lo mostramos
                    pos = 0;
                    mostrarRegistro(pos);
                    MessageBox.Show("Eliminado correctamente");
                }

            }
            else
            {
                MessageBox.Show("No hay registros por eliminar");
                txtDni.Clear();
                txtNombre.Clear();
                txtApellidos.Clear();
                txtTelefono.Clear();
                txtEmail.Clear();
            }
        }

        private void btnMostrarLista_Click(object sender, EventArgs e)
        {
            string listado = sqlDBHelper.mostrarListaProfesores(tabla);
            MessageBox.Show(listado);
        }

        private void btnBuscarXNombre_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Introduzca el Nombre del Profesor");
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


    }
}
