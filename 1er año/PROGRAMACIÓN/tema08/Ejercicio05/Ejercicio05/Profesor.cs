using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    public class Profesor:Persona
    {
        private int mCodigoCursoTutor;
        private List<string> mAsignaturas;
        private string mCorreo;

        public int CodigoCursoTutor
        {
            get { return mCodigoCursoTutor; }
            set { mCodigoCursoTutor = value; }
        }
        public string Correo
        {
            get { return mCorreo; }
            set { mCorreo = value; }
        }

        public Profesor(string dni, string nombre, string telefono, int codCursoTutor, string correo) : base(dni, nombre, telefono)
        {
            mCodigoCursoTutor = codCursoTutor;
            mAsignaturas = new List<string>();
            mCorreo = correo;
        }

        private string mostrarAsignaturasImpartidas()
        {
            string texto = "";

            if (mAsignaturas.Count > 0)
            {
                for (int i = 0; i < mAsignaturas.Count; i++)
                {
                    texto += mAsignaturas[i] + ", ";
                }
            }
            else
            {
                texto += "No hay Asignaturas almacenadas";
            }
            return texto;
        }

        public string mostrarDatosProfesor()
        {
            string texto = "\nDatos del Profesor: \n";
            texto += "DNI: " + Dni + "\n";
            texto += "Nombre: " + Nombre + "\n";
            texto += "Telefono: " + Telefono + "\n";
            texto += "Asignaturas Impartidas: " + mostrarAsignaturasImpartidas() + "\n";
            if (mCodigoCursoTutor != null)
            {
                texto += "Codigo Curso el cual tutoriza: " + mCodigoCursoTutor + "\n";
            }
            else
            {
                texto += "No es tutor";
            }
            texto += "Correo: " + Correo + "\n";
            return texto;
        }
        public void anyadirAsignatura(string asignatura)
        {
            mAsignaturas.Add(asignatura);
        }

        public bool sinAsignaturas()
        {
            string texto = mostrarAsignaturasImpartidas();
            bool vacio = false;

            if (texto == "No hay Asignaturas almacenadas")
            {
                vacio = true;
            }
            return vacio;
        }

        public void eliminarAsignaturas()
        {
            mAsignaturas.Clear();
        }

        public bool buscarAsignatura(string Asignatura)
        {
            bool encontrado = false;

            for (int i = 0; i < mAsignaturas.Count; i++)
            {
                if (string.Equals(mAsignaturas[i], Asignatura, StringComparison.OrdinalIgnoreCase))
                {
                    encontrado = true;
                }
            }
            return encontrado;
        }
    }
}
