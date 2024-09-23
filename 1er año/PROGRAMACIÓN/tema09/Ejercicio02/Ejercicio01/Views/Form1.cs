using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using Microsoft.VisualBasic;
using Ejercicio02.Models;

namespace Ejercicio02
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
            Profesor profesor;
            profesor = sqlDBHelper.devuelveProfesor(pos);
            // Ponemos los valores en los textBox correspondientes
            txtDNI.Text = profesor.Dni;
            txtNombre.Text = profesor.Nombre;
            txtApellidos.Text = profesor.Apellidos;
            txtTlf.Text = profesor.Tlf;
            txtEmail.Text = profesor.eMail;

            lblMostrarNumRegistro.Text = "Registro " + (pos + 1) + " de " + sqlDBHelper.NumProfesores;

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

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            // Ponemos la primera posición
            pos = 0;
            mostrarRegistro(pos);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            // Vamos a la posición anterior.
            if(pos != 0)
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
            if(pos != sqlDBHelper.NumProfesores - 1)
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
            pos = sqlDBHelper.NumProfesores - 1;
            mostrarRegistro(pos);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            txtDNI.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            txtTlf.Clear();
            txtEmail.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool validado = true;
            // Metemos los datos en el nuevo registro
            if(txtDNI.Text == string.Empty)
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
            if (txtTlf.Text == string.Empty)
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
                Profesor profesor = new Profesor(txtDNI.Text, txtNombre.Text,
                txtApellidos.Text, txtTlf.Text, txtEmail.Text);
                sqlDBHelper.anyadirProfesor(profesor);
                // Actualizamos la posición
                pos = sqlDBHelper.NumProfesores - 1;
            }
            mostrarRegistro(pos);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Creamos el profesor con los datos del formulario
            Profesor profesor = new Profesor(txtDNI.Text, txtNombre.Text,
            txtApellidos.Text, txtTlf.Text, txtEmail.Text);
            sqlDBHelper.actualizarProfesor(profesor, pos);
            MessageBox.Show("Actualizado correctamente");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult more;
            more = MessageBox.Show("Quieres eliminar el registro actual?", "Eliminar", MessageBoxButtons.YesNo);
            if(sqlDBHelper.NumProfesores >= 1)
            {
                if (more == DialogResult.Yes)
                {

                    sqlDBHelper.eliminarProfesor(pos);
                    // Nos vamos al primer registro y lo mostramos
                    pos = 0;
                    mostrarRegistro(pos);
                    MessageBox.Show("Eliminado correctamente");
                }
               
            }
            else
            {
                MessageBox.Show("No hay registros por eliminar");
                txtDNI.Clear();
                txtNombre.Clear();
                txtApellidos.Clear();
                txtTlf.Clear();
                txtEmail.Clear();
            }

        }

        private void btnMostrarLista_Click(object sender, EventArgs e)
        {
            string listado = sqlDBHelper.mostrarListaProfesores();
            MessageBox.Show(listado);
            
        }

        private void btnBuscarApellido_Click(object sender, EventArgs e)
        {
            string apellido = Interaction.InputBox("Introduzca el apellido");
            string apellidoMinuscula = apellido.ToLower();
            bool encontrado = false;
            pos = 0;

            if (!string.IsNullOrEmpty(apellido))
            {
                pos = sqlDBHelper.buscarXApellido(apellidoMinuscula, ref encontrado);
                if (!encontrado)
                {
                    MessageBox.Show("No existe el apellido en la BD"); 
                }
                else
                {
                    mostrarRegistro(pos);
                }
            }
            else
            {
                MessageBox.Show("Apellido vacio, vuelva a escribirlo");
            }
            
        }
    }
}
