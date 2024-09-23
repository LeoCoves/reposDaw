using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simulacro
{
    public class listaDiscos
    {
        List<Disco> mLista;

        public listaDiscos()
        {
            mLista = new List<Disco>();
        }

        public string mostrarDiscosMayVendidos()
        {
            string texto = "";
            Disco disc;

            if(mLista.Count > 0)
            {
                texto += "Discos: \n";
                for(int i = 0; i < mLista.Count; i++)
                {
                    disc = mLista[i];
                    if(disc.NumVendidos > 10000)
                    {
                        texto += disc.mostrarDatos() + "\n";
                    }
                }
            }
            else
            {
                texto += "No hay discos";
            }
            return texto;
        }

        public string buscarGrupo(string cancion)
        {
            Disco disc;
            string grupo = "";
            for(int i = 0; i < mLista.Count; i++)
            {
                disc = mLista[i];
                if (disc.buscarCancion(cancion))
                {
                    grupo += disc.Grupo + ",";
                }
            }
            return grupo;
        }

        public bool delCanciones(string grupo, string titulo)
        {
            Disco disc;
            bool encontrado = false;
            for(int i = 0; i < mLista.Count && !encontrado; i++)
            {
                disc = mLista[i];
                if(disc.Grupo == grupo && disc.Titulo == titulo)
                {
                    encontrado = true;
                    disc.eliminarCanciones();
                }
            }
            return encontrado;
        }
    }
}
