using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Ejercicio02.Models
{
    public class SqlDBHelper
    {
        // Miembros para guardar el dataSet y el dataAdapter de profesores.
        private DataSet dataSetProfs;
        private SqlDataAdapter daProfesores;
        // Miembro para guardar el número de profesores.
        private int mNumProfesores;
        // Propiedad de solo lectura.
        public int NumProfesores
        {
            get => mNumProfesores;
        }
        // Constructor del objeto.
        // En el mismo hacemos la conexión y creamos dataSet y dataAdapter
        public SqlDBHelper()
        {
            string cadenaConexion = "Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename= C:\\Users\\leocovguz\\Desktop\\repos\\daw\\1er año\\PROGRAMACIÓN\\tema09\\Ejercicio01\\Ejercicio01\\App_Data\\Instituto (1).mdf; Integrated Security=True; Connect Timeout=30";
            SqlConnection con = new SqlConnection(cadenaConexion);
            // Abrimos la conexión.
            con.Open();

            string cadenaSQL = "SELECT * From Profesores";

            daProfesores = new SqlDataAdapter(cadenaSQL, con);

            dataSetProfs = new DataSet();

            daProfesores.Fill(dataSetProfs, "Profesores");


            // Obtenemos el número de registros
            mNumProfesores = dataSetProfs.Tables["Profesores"].Rows.Count;

            // Cerramos la conexión.
            con.Close();

        }

        // Método que a partir de una posición en la BD
        // Devuelve un objeto profesor.
        // Devuelve null si pos está fuera de los límites
        public Profesor devuelveProfesor(int pos)
        {
            Profesor profesor = null;
            if (pos >= 0 && pos < mNumProfesores)
            {
                // Objeto que nos permite recoger un registro de la tabla.
                DataRow dRegistro;
                // Cogemos el registro de la posición pos en la tabla Profesores
                dRegistro = dataSetProfs.Tables["Profesores"].Rows[pos];
                // Cogemos el valor de cada una de las columnas del registro
                // y creamos el objeto profesor con esos datos.
                profesor = new Profesor(dRegistro[0].ToString(),
                dRegistro[1].ToString(), dRegistro[2].ToString(),
                dRegistro[3].ToString(), dRegistro[4].ToString());
            }
            return profesor;
        }
        // Metodos CRUD
        // Método que reconecta y actualiza la BD
        private void reconectarBD()
        {
            // Reconectamos con el dataAdapter y actualizamos la BD
            SqlCommandBuilder cb = new SqlCommandBuilder(daProfesores);
            daProfesores.Update(dataSetProfs, "Profesores");
        }

        // Método que añade un profesor a nuestra BD
        public void anyadirProfesor(Profesor profesor)
        {
            // Creamos un nuevo registro.
            DataRow dRegistro = dataSetProfs.Tables["Profesores"].NewRow();
            // Metemos los datos en el nuevo registro
            dRegistro[0] = profesor.Dni;
            dRegistro[1] = profesor.Nombre;
            dRegistro[2] = profesor.Apellidos;
            dRegistro[3] = profesor.Tlf;
            dRegistro[4] = profesor.eMail;
            // Si quisieramos hacerlo por nombre de columna en vez de posición
            // dRegistro["DNI"] = profesor.Dni;
            // Añadimos el registro al Dataset
            dataSetProfs.Tables["Profesores"].Rows.Add(dRegistro);
            // Reconectamos y actualizamos la BD
            reconectarBD();
            // Actualizamos el número de profesores
            mNumProfesores++;
        }

        // Actualizamos los datos del profesor
        // situado en la posición pos
        public void actualizarProfesor(Profesor profesor, int pos)
        {
            // Cogemos el registro situado en la posición actual.
            DataRow dRegistro = dataSetProfs.Tables["Profesores"].Rows[pos];
            // Metemos los datos en el registro
            dRegistro[0] = profesor.Dni;
            dRegistro[1] = profesor.Nombre;
            dRegistro[2] = profesor.Apellidos;
            dRegistro[3] = profesor.Tlf;
            dRegistro[4] = profesor.eMail;
            // Si quisieramos hacerlo por nombre de columna en vez de posición
            // dRegistro["DNI"] = profesor.Dni;
            // Reconectamos y actualizamos la BD
            reconectarBD();
        }

        public void eliminarProfesor(int pos)
        {
            // Eliminamos el registro situado en la posición actual.
            dataSetProfs.Tables["Profesores"].Rows[pos].Delete();
            // Tenemos un profesor menos
            mNumProfesores--;
            // Reconectamos y actualizamos la BD
            reconectarBD();
        }

        public string mostrarListaProfesores()
        {
            string listado = "Listado de Profesores:\n";
            DataRow dRegistro;


            for (int pos = 0; pos < mNumProfesores; pos++)
            {
                dRegistro = dataSetProfs.Tables["Profesores"].Rows[pos];
                listado += "DNI: " + dRegistro[0].ToString() +
                            " | Nombre Completo: " + dRegistro[1].ToString() + " " + dRegistro[2].ToString() + "\n";
            }
            return listado;
        }

        public int buscarXApellido(string apellidoMinuscula, ref bool encontrado)
        {
            int pos = 0;
            DataRow dRegistro;
            for (int i = 0; i < mNumProfesores && !encontrado; i++)
            {
                dRegistro = dataSetProfs.Tables["Profesores"].Rows[i];
                string registroMinuscula = dRegistro[2].ToString().ToLower();

                if (registroMinuscula.Contains(apellidoMinuscula))
                {
                    pos = i;
                    encontrado = true;
                }
            }
            return pos;
        }
    }
}