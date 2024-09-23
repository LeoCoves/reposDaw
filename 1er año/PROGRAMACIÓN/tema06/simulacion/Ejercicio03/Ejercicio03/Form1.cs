using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> lista1 = new List<string>();
        List<string> lista2 = new List<string>();

        void eliminarRepe(List<string> lista1, List<string> lista2)
        {
            for(int i = 0; i < lista1.Count; i++)
            {
                if (lista2.Contains(lista1[i]))
                {
                    string name = lista1[i];
                    if(comprobar(lista2, name))
                    {
                        lista1.RemoveAt(i);
                    }
                }
        }

        bool comprobar(List<string> list, string name)
        {
                bool encontrado = false;
                int i = 0;
                while(i < lista2.Count)
                {
                    if(name == lista2[i])
                    {
                        i++;
                    }
                }
                if(i >= 2)
                {
                    encontrado = true;
                }
                return encontrado;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
                
        }
    }
}
