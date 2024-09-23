using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulacro
{
    public class Disco
    {
        private string mGrupo;
        private string mTitulo;
        private int mDuracion;
        private int mNumVendidos;
        private List<string> mCanciones;

        public string Grupo
        {
            get { return mGrupo; }
            set { mGrupo = value; }
        }
        public string Titulo
        {
            get { return mTitulo; }
            set { mTitulo = value; }
        }

        public int Duracion
        {
            get { return mDuracion; }
            set { mDuracion = value; }
        }

        public int NumVendidos
        {
            get { return mNumVendidos;}
            set {  mNumVendidos = value; }
        }
        public Disco()
        {
            mGrupo = "";
            mTitulo = "";
            mDuracion = 0;
            mNumVendidos = 0;
            mCanciones = new List<string>();
        }


        private string mostrarCanciones()
        {
            string texto = "";
            if(mCanciones.Count > 0)
            {
                texto += "Canciones: ";
                for (int i = 0; i < mCanciones.Count; i++)
                {
                    texto += mCanciones[i] + ", ";
                }
            }
            else
            {
                texto += "No hay canciones";
            }
            return texto;
        }

        public string mostrarDatos()
        {
            string texto = "Datos del disco: \n";
            texto += "Grupo: " + mGrupo + "\n";
            texto += "Titulo: " + mTitulo + "\n";
            texto += "Duracion: " + mDuracion + " segundos\n";
            texto += "Num Vendidos: " + mNumVendidos + " discos vendidos\n";
            texto += mostrarCanciones() + "\n";
            return texto;
        }

        public bool buscarCancion(string cancion)
        {
            bool encontrado = false;
            for(int i = 0; i < mCanciones.Count;i++)
            {
                if(cancion == mCanciones[i])
                {
                    encontrado = true;
                }
            }
            return encontrado;
        }

        public void eliminarCanciones()
        {
            mCanciones.Clear();
        }
    }
}
