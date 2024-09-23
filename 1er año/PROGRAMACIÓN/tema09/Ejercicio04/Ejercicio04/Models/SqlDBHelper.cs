using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;

namespace Ejercicio04.Models
{
    public class SqlDBHelper
    {
        // Miembros para guardar el dataSet y el dataAdapter de profesores.
        private DataSet dataSetInstituto;
        private SqlDataAdapter daInstituto;
        // Miembro para guardar el número de profesores.
        private int mNumRegistros;
        // Propiedad de solo lectura.
        public int NumRegistros
        {
            get => mNumRegistros;
        }

        
        public SqlDBHelper(string tabla)
        {
            string relative = @"..\..\App_Data\Instituto (1).mdf"; //obtener ruta relativa
            string absolute = Path.GetFullPath(relative); //obtener ruta absoluta
            string cadenaConexion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" +
            absolute + " ;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(cadenaConexion);
            // Abrimos la conexión.
            con.Open();

            string cadenaSQLInsti = "SELECT * From " + tabla;
            daInstituto = new SqlDataAdapter(cadenaSQLInsti, con);


            dataSetInstituto = new DataSet();

            daInstituto.Fill(dataSetInstituto, tabla);



            // Obtenemos el número de registros
            mNumRegistros = dataSetInstituto.Tables[tabla].Rows.Count;

            // Cerramos la conexión.
            con.Close();

        }

        public Profesor devuelveProfesor(int pos, string tabla)
        {
            Profesor profesor = null;
            if (pos >= 0 && pos < mNumRegistros)
            {
                // Objeto que nos permite recoger un registro de la tabla.
                DataRow dRegistro;
                // Cogemos el registro de la posición pos en la tabla Profesores
                dRegistro = dataSetInstituto.Tables[tabla].Rows[pos];
                // Cogemos el valor de cada una de las columnas del registro
                // y creamos el objeto profesor con esos datos.
                profesor = new Profesor(dRegistro[0].ToString(),
                dRegistro[1].ToString(), dRegistro[2].ToString(),
                dRegistro[3].ToString(), dRegistro[4].ToString());
            }
            return profesor;
        }

        public Curso devuelveCurso(int pos, string tabla)
        {
            Curso curso = null;
            if (pos >= 0 && pos < mNumRegistros)
            {
                // Objeto que nos permite recoger un registro de la tabla.
                DataRow dRegistro;
                // Cogemos el registro de la posición pos en la tabla Profesores
                dRegistro = dataSetInstituto.Tables[tabla].Rows[pos];
                // Cogemos el valor de cada una de las columnas del registro
                // y creamos el objeto profesor con esos datos.
                curso = new Curso(int.Parse(dRegistro[0].ToString()),
                dRegistro[1].ToString());
            }
            return curso;
        }

        public Alumno devuelveAlumno(int pos, string tabla)
        {
            Alumno alumno = null;
            if (pos >= 0 && pos < mNumRegistros)
            {
                // Objeto que nos permite recoger un registro de la tabla.
                DataRow dRegistro;
                // Cogemos el registro de la posición pos en la tabla Profesores
                dRegistro = dataSetInstituto.Tables[tabla].Rows[pos];
                // Cogemos el valor de cada una de las columnas del registro
                // y creamos el objeto profesor con esos datos.
                alumno = new Alumno(dRegistro[0].ToString(),
                dRegistro[1].ToString(), dRegistro[2].ToString(),
                dRegistro[3].ToString(), dRegistro[4].ToString(),
                dRegistro[5].ToString());
            }
            return alumno;
        }
        // Metodos CRUD
        // Método que reconecta y actualiza la BD
        private void reconectarBD(string tabla)
        {
            // Reconectamos con el dataAdapter y actualizamos la BD
            SqlCommandBuilder cb = new SqlCommandBuilder(daInstituto);
            daInstituto.Update(dataSetInstituto, tabla);
        }

        // Método que añade un profesor a nuestra BD
        public void anyadirProfesor(Profesor profesor, string tabla)
        {
            // Creamos un nuevo registro.
            DataRow dRegistro = dataSetInstituto.Tables[tabla].NewRow();
            // Metemos los datos en el nuevo registro
            dRegistro[0] = profesor.Dni;
            dRegistro[1] = profesor.Nombre;
            dRegistro[2] = profesor.Apellidos;
            dRegistro[3] = profesor.Tlf;
            dRegistro[4] = profesor.Email;

            dataSetInstituto.Tables[tabla].Rows.Add(dRegistro);
            // Reconectamos y actualizamos la BD
            reconectarBD(tabla);
            // Actualizamos el número de profesores
            mNumRegistros++;
        }

        public void anyadirCurso(Curso curso, string tabla)
        {
            // Creamos un nuevo registro.
            DataRow dRegistro = dataSetInstituto.Tables[tabla].NewRow();

            dRegistro[0] = curso.Codigo;
            dRegistro[1] = curso.Nombre;


            dataSetInstituto.Tables[tabla].Rows.Add(dRegistro);

            reconectarBD(tabla);

            mNumRegistros++;
        }

        public void anyadirAlumno (Alumno alumno, string tabla)
        {

            DataRow dRegistro = dataSetInstituto.Tables[tabla].NewRow();

            dRegistro[0] = alumno.Dni;
            dRegistro[1] = alumno.Nombre;
            dRegistro[2] = alumno.Apellidos;
            dRegistro[3] = alumno.Direccion;
            dRegistro[4] = alumno.Tlf;
            dRegistro[5] = alumno.Email;


            dataSetInstituto.Tables[tabla].Rows.Add(dRegistro);

            reconectarBD(tabla);

            mNumRegistros++;
        }

        public void actualizarProfesor(Profesor profesor, int pos, string tabla)
        {
            DataRow dRegistro = dataSetInstituto.Tables[tabla].Rows[pos];

            dRegistro[0] = profesor.Dni;
            dRegistro[1] = profesor.Nombre;
            dRegistro[2] = profesor.Apellidos;
            dRegistro[3] = profesor.Tlf;
            dRegistro[4] = profesor.Email;

            reconectarBD(tabla);
        }

        public void actualizarCurso(Curso curso, int pos, string tabla)
        {
            DataRow dRegistro = dataSetInstituto.Tables[tabla].Rows[pos];

            dRegistro[0] = curso.Codigo;
            dRegistro[1] = curso.Nombre;

            reconectarBD(tabla);
        }

        public void actualizarAlumno(Alumno alumno, int pos, string tabla)
        {
            DataRow dRegistro = dataSetInstituto.Tables[tabla].Rows[pos];

            dRegistro[0] = alumno.Dni;
            dRegistro[1] = alumno.Nombre;
            dRegistro[2] = alumno.Apellidos;
            dRegistro[3] = alumno.Direccion;
            dRegistro[4] = alumno.Tlf;
            dRegistro[5] = alumno.Email;

            reconectarBD(tabla);
        }
        public void eliminarProfesor(int pos, string tabla)
        {
            // Eliminamos el registro situado en la posición actual.
            dataSetInstituto.Tables[tabla].Rows[pos].Delete();
            // Tenemos un profesor menos
            mNumRegistros--;
            // Reconectamos y actualizamos la BD
            reconectarBD(tabla);
        }

        public void eliminarCurso(int pos, string tabla)
        {
            // Eliminamos el registro situado en la posición actual.
            dataSetInstituto.Tables[tabla].Rows[pos].Delete();
            // Tenemos un profesor menos
            mNumRegistros--;
            // Reconectamos y actualizamos la BD
            reconectarBD(tabla);
        }

        public void eliminarAlumno(int pos, string tabla)
        {
            // Eliminamos el registro situado en la posición actual.
            dataSetInstituto.Tables[tabla].Rows[pos].Delete();
            // Tenemos un profesor menos
            mNumRegistros--;
            // Reconectamos y actualizamos la BD
            reconectarBD(tabla);
        }


        public string mostrarListaProfesores(string tabla)
        {
            string listado = "Listado de Profesores:\n";
            DataRow dRegistro;


            for (int pos = 0; pos < mNumRegistros; pos++)
            {
                dRegistro = dataSetInstituto.Tables[tabla].Rows[pos];
                listado += "DNI: " + dRegistro[0].ToString() +
                            " | Nombre Completo: " + dRegistro[1].ToString() + " " + dRegistro[2].ToString() + "\n";
            }
            return listado;
        }

        public string mostrarListaCursos(string tabla)
        {
            string listado = "Listado de Cursos:\n";
            DataRow dRegistro;


            for (int pos = 0; pos < mNumRegistros; pos++)
            {
                dRegistro = dataSetInstituto.Tables[tabla].Rows[pos];
                listado += "Codigo: " + dRegistro[0].ToString() +
                            " | Nombre: " + dRegistro[1].ToString() + "\n";
            }
            return listado;
        }

        public string mostrarListaAlumnos(string tabla)
        {
            string listado = "Listado de Alumnos:\n";
            DataRow dRegistro;


            for (int pos = 0; pos < mNumRegistros; pos++)
            {
                dRegistro = dataSetInstituto.Tables[tabla].Rows[pos];
                listado += "DNI: " + dRegistro[0].ToString() +
                            " | Nombre Completo: " + dRegistro[1].ToString() + " " + dRegistro[2].ToString() + "\n";
            }
            return listado;
        }

        public int buscarXApellido(string apellidoMinuscula, ref bool encontrado, string tabla)
        {
            int pos = 0;
            DataRow dRegistro;
            for (int i = 0; i < mNumRegistros && !encontrado; i++)
            {
                dRegistro = dataSetInstituto.Tables[tabla].Rows[i];
                string registroMinuscula = dRegistro[2].ToString().ToLower();

                if (registroMinuscula.Contains(apellidoMinuscula))
                {
                    pos = i;
                    encontrado = true;
                }
            }
            return pos;
        }

        public int buscarXNombre(string apellidoMinuscula, ref bool encontrado, string tabla)
        {
            int pos = 0;
            DataRow dRegistro;
            for (int i = 0; i < mNumRegistros && !encontrado; i++)
            {
                dRegistro = dataSetInstituto.Tables[tabla].Rows[i];
                string registroMinuscula = dRegistro[1].ToString().ToLower();

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