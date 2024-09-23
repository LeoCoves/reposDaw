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

namespace Ejercicio01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataSet dataSetProfs;
        SqlDataAdapter dataAdapterProfs;

        // Variable que indica en qué registro estamos situados.
        private int pos;
        private int maxRegistros;
        private void mostrarRegistro(int pos)
        {
            // Objeto que nos permite recoger un registro de la tabla.
            DataRow dRegistro;
            // Cogemos el registro de la posición pos en la tabla Profesores
            dRegistro = dataSetProfs.Tables["Profesores"].Rows[pos];
            // Cogemos el valor de cada una de las columnas del registro
            // y lo ponemos en el textBox correspondiente.
            txtDNI.Text = dRegistro[0].ToString();
            txtNombre.Text = dRegistro[1].ToString();
            txtApellidos.Text = dRegistro[2].ToString();
            txtTlf.Text = dRegistro[3].ToString();
            txtEmail.Text = dRegistro[4].ToString();
            //También lo podemos hacer con el nombre del campo. Sería:
            //txtDNI.Text = dRegistro["DNI"].ToString();
            //txtNombre.Text = dRegistro["Nombre"].ToString();
            //txtApellidos.Text = dRegistro["Apellido"].ToString();
            //txtTlf.Text = dRegistro["Tlf"].ToString();
            //txteMail.Text = dRegistro["EMail"].ToString();

            lblMostrarNumRegistro.Text = "Registro " + (pos + 1) + " de " + maxRegistros;

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
            string cadenaConexion = "Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename= C:\\Users\\leocovguz\\Desktop\\repos\\daw\\1er año\\PROGRAMACIÓN\\tema09\\Ejercicio01\\Ejercicio01\\App_Data\\Instituto (1).mdf; Integrated Security=True; Connect Timeout=30";
            SqlConnection con = new SqlConnection(cadenaConexion);
            // Abrimos la conexión.
            con.Open();

            string cadenaSQL = "SELECT * From Profesores";

            dataAdapterProfs = new SqlDataAdapter(cadenaSQL, con);

            dataSetProfs = new DataSet();

            dataAdapterProfs.Fill(dataSetProfs, "Profesores");

            // Situamos la primera posición
            pos = 0;
            

            // Obtenemos el número de registros
            maxRegistros = dataSetProfs.Tables["Profesores"].Rows.Count;
            mostrarRegistro(pos);
            // Cerramos la conexión.
            con.Close();

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
            if(pos != maxRegistros - 1)
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
            pos = maxRegistros - 1;
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
            // Creamos un nuevo registro.
            DataRow dRegistro = dataSetProfs.Tables["Profesores"].NewRow();
            // Metemos los datos en el nuevo registro
            if(txtDNI.Text == string.Empty)
            {
                MessageBox.Show("Campo DNI No rellenado");
                validado = false;
            }
            else
            {
                dRegistro[0] = txtDNI.Text;
            }

            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Campo Nombre No rellenado");
                validado = false;
            }
            else
            {
                dRegistro[1] = txtNombre.Text;
            }
            if (txtApellidos.Text == string.Empty)
            {
                MessageBox.Show("Campo Apellidos No rellenado");
                validado = false;
            }
            else
            {
                dRegistro[2] = txtApellidos.Text;
            }
            if (txtTlf.Text == string.Empty)
            {
                MessageBox.Show("Campo Telefono No rellenado");
                validado = false;
            }
            else
            {
                dRegistro[3] = txtTlf.Text;
            }
            if (txtEmail.Text == string.Empty)
            {
                MessageBox.Show("Campo Email No rellenado");
                validado = false;
            }
            else
            {
                dRegistro[4] = txtEmail.Text;
            }

            if (validado)
            {
                // Si quisieramos hacerlo por nombre de columna en vez de posición
                /* dRegistro["DNI"] = txtDNI.Text;
                 dRegistro["Nombre"] = txtNombre.Text;
                 dRegistro["Apellido"] = txtApellidos.Text;
                 dRegistro["Tlf"] = txtTlf.Text;
                 dRegistro["EMail"] = txteMail.Text;*/
                // Añadimos el registro al Dataset
                dataSetProfs.Tables["Profesores"].Rows.Add(dRegistro);
                // Reconectamos con el dataAdapter y actualizamos la BD
                SqlCommandBuilder cb = new SqlCommandBuilder(dataAdapterProfs);
                dataAdapterProfs.Update(dataSetProfs, "Profesores");
                // Actualizamos el número de registros y la posición en la tabla
                maxRegistros++;
                pos = maxRegistros - 1;
            }
            mostrarRegistro(pos);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Cogemos el registro situado en la posición actual.
            DataRow dRegistro = dataSetProfs.Tables["Profesores"].Rows[pos];
            // Metemos los datos en el registro
            dRegistro[0] = txtDNI.Text;
            dRegistro[1] = txtNombre.Text;
            dRegistro[2] = txtApellidos.Text;
            dRegistro[3] = txtTlf.Text;
            dRegistro[4] = txtEmail.Text;
            // Si quisieramos hacerlo por nombre de columna en vez de posición
            /* dRegistro["DNI"] = txtDNI.Text;
            dRegistro["Nombre"] = txtNombre.Text;
            dRegistro["Apellido"] = txtApellidos.Text;
            dRegistro["Tlf"] = txtTlf.Text;
            dRegistro["EMail"] = txteMail.Text;*/
            // Reconectamos con el dataAdapter y actualizamos la BD
            SqlCommandBuilder cb = new SqlCommandBuilder(dataAdapterProfs);
            dataAdapterProfs.Update(dataSetProfs, "Profesores");
            MessageBox.Show("Actualizado correctamente");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult more;
            more = MessageBox.Show("Quieres eliminar el registro actual?", "Eliminar", MessageBoxButtons.YesNo);
            if(maxRegistros >= 1)
            {
                if (more == DialogResult.Yes)
                {

                    // Eliminamos el registro situado en la posición actual.
                    dataSetProfs.Tables["Profesores"].Rows[pos].Delete();
                    // Tenemos un registro menos
                    maxRegistros--;
                    // Nos vamos al primer registro y lo mostramos
                    pos = 0;
                    // Reconectamos con el dataAdapter y actualizamos la BD
                    SqlCommandBuilder cb = new SqlCommandBuilder(dataAdapterProfs);
                    dataAdapterProfs.Update(dataSetProfs, "Profesores");

                    if(maxRegistros >= 1)
                    {
                        mostrarRegistro(pos);
                    }

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
            string listado = "Listado de Profesores:\n";
            DataRow dRegistro;
            
            for(int i = 0; i < maxRegistros; i++)
            {
                pos = i;
                dRegistro = dataSetProfs.Tables["Profesores"].Rows[pos];
                listado += "DNI: " + dRegistro[0].ToString() +
                            " | Nombre Completo: " + dRegistro[1].ToString() + " " + dRegistro[2].ToString() + "\n";
            }
            MessageBox.Show(listado);
            
        }

        private void btnBuscarApellido_Click(object sender, EventArgs e)
        {
            string apellido = Interaction.InputBox("Introduzca el apellido");
            string apellidoMinuscula = apellido.ToLower();
            DataRow dRegistro;
            bool encontrado = false;

            if (!string.IsNullOrEmpty(apellido))
            {
                for (int i = 0; i < maxRegistros && !encontrado; i++)
                {
                    pos = i;
                    dRegistro = dataSetProfs.Tables["Profesores"].Rows[pos];
                    string registroMinuscula = dRegistro[2].ToString().ToLower();

                    if (registroMinuscula.Contains(apellidoMinuscula))
                    {
                        mostrarRegistro(pos);
                        encontrado = true;
                    }
                }
                if (!encontrado)
                {
                    MessageBox.Show("No existe el apellido en la BD");
                    pos = 0;
                }
            }
            else
            {
                MessageBox.Show("Apellido vacio, vuelva a escribirlo");
            }
            mostrarRegistro(pos);
        }
    }
}
