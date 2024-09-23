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

namespace Ejercicio3.Models
{
    public class SqlDBHelper
    {
        // Miembros para guardar el dataSet y el dataAdapter de profesores.
        private DataSet dataSetCoches;
        private SqlDataAdapter daCoches;
        // Miembro para guardar el número de profesores.
        private int mNumCoches;
        // Propiedad de solo lectura.
        public int NumCoches
        {
            get => mNumCoches;
        }
        // Constructor del objeto.
        // En el mismo hacemos la conexión y creamos dataSet y dataAdapter
        public SqlDBHelper()
        {
            string relative = @"..\..\App_Data\Concesionario.mdf"; //obtener ruta relativa
            string absolute = Path.GetFullPath(relative); //obtener ruta absoluta
            string cadenaConexion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" +
            absolute + " ;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(cadenaConexion);

            // Abrimos la conexión.
            con.Open();

            string cadenaSQL = "SELECT * From COCHES";

            daCoches = new SqlDataAdapter(cadenaSQL, con);

            dataSetCoches = new DataSet();

            daCoches.Fill(dataSetCoches, "COCHES");


            // Obtenemos el número de registros
            mNumCoches = dataSetCoches.Tables["COCHES"].Rows.Count;

            // Cerramos la conexión.
            con.Close();

        }

        // Método que a partir de una posición en la BD
        // Devuelve un objeto profesor.
        // Devuelve null si pos está fuera de los límites
        public Coche devuelveCoche(int pos)
        {
            Coche coche = null;
            if (pos >= 0 && pos < mNumCoches)
            {
                // Objeto que nos permite recoger un registro de la tabla.
                DataRow dRegistro;
                // Cogemos el registro de la posición pos en la tabla Profesores
                dRegistro = dataSetCoches.Tables["COCHES"].Rows[pos];
                // Cogemos el valor de cada una de las columnas del registro
                // y creamos el objeto profesor con esos datos.
                coche = new Coche(dRegistro[0].ToString(),
                dRegistro[1].ToString(), dRegistro[2].ToString(),
                int.Parse(dRegistro[3].ToString()), dRegistro[4].ToString(),
                dRegistro[5].ToString(), double.Parse(dRegistro[6].ToString()));
            }
            return coche;
        }
        // Metodos CRUD
        // Método que reconecta y actualiza la BD
        private void reconectarBD()
        {
            // Reconectamos con el dataAdapter y actualizamos la BD
            SqlCommandBuilder cb = new SqlCommandBuilder(daCoches);
            daCoches.Update(dataSetCoches, "COCHES");
        }

        // Método que añade un profesor a nuestra BD
        public void anyadirCoche(Coche coche)
        {
            // Creamos un nuevo registro.
            DataRow dRegistro = dataSetCoches.Tables["COCHES"].NewRow();
            // Metemos los datos en el nuevo registro
            dRegistro[0] = coche.Matricula;
            dRegistro[1] = coche.Marca;
            dRegistro[2] = coche.Modelo;
            dRegistro[3] = coche.Potencia;
            dRegistro[4] = coche.Color;
            dRegistro[5] = coche.Anyo;
            dRegistro[6] = coche.Precio;

            // Si quisieramos hacerlo por nombre de columna en vez de posición
            // dRegistro["DNI"] = profesor.Dni;
            // Añadimos el registro al Dataset
            dataSetCoches.Tables["COCHES"].Rows.Add(dRegistro);
            // Reconectamos y actualizamos la BD
            reconectarBD();
            // Actualizamos el número de profesores
            mNumCoches++;
        }

        // Actualizamos los datos del profesor
        // situado en la posición pos
        public void actualizarCoche(Coche coche, int pos)
        {
            // Cogemos el registro situado en la posición actual.
            DataRow dRegistro = dataSetCoches.Tables["COCHES"].Rows[pos];
            // Metemos los datos en el registro
            dRegistro[0] = coche.Matricula;
            dRegistro[1] = coche.Marca;
            dRegistro[2] = coche.Modelo;
            dRegistro[3] = coche.Potencia;
            dRegistro[4] = coche.Color;
            dRegistro[5] = coche.Anyo;
            dRegistro[6] = coche.Precio;
            // Si quisieramos hacerlo por nombre de columna en vez de posición
            // dRegistro["DNI"] = profesor.Dni;
            // Reconectamos y actualizamos la BD
            reconectarBD();
        }

        public void eliminarCoche(int pos)
        {
            // Eliminamos el registro situado en la posición actual.
            dataSetCoches.Tables["COCHES"].Rows[pos].Delete();
            // Tenemos un profesor menos
            mNumCoches--;
            // Reconectamos y actualizamos la BD
            reconectarBD();
        }

        public string mostrarListaCoches()
        {
            string listado = "Listado de Coches:\n";
            DataRow dRegistro;


            for (int pos = 0; pos < mNumCoches; pos++)
            {
                dRegistro = dataSetCoches.Tables["COCHES"].Rows[pos];
                listado += "Matricula: " + dRegistro[0].ToString() +
                            " | Marca y Modelo: " + dRegistro[1].ToString() + " " + dRegistro[2].ToString() + "\n";
            }
            return listado;
        }

        public int buscarXModelo(string modeloMinuscula, ref bool encontrado)
        {
            int pos = 0;
            DataRow dRegistro;
            for (int i = 0; i < mNumCoches && !encontrado; i++)
            {
                dRegistro = dataSetCoches.Tables["COCHES"].Rows[i];
                string registroMinuscula = dRegistro[2].ToString().ToLower();

                if (registroMinuscula.Contains(modeloMinuscula))
                {
                    pos = i;
                    encontrado = true;
                }
            }
            return pos;
        }
    }
}