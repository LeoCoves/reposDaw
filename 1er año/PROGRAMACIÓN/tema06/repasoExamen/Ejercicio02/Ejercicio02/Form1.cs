using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> listOriginal = new List<int>();
        List<int> listEven = new List<int>();

        void readList(List<int> list)
        {
            DialogResult more;
            int num;

            do
            {
                num = int.Parse(Interaction.InputBox("Introduce"));
                list.Add(num);

                more = MessageBox.Show("Do you want enter more values?", "value", MessageBoxButtons.YesNo);
            } while (more == DialogResult.Yes);
        }

        void copyList(List<int> listOriginal, List<int> listEven)
        {
            for(int i = 0; i < listOriginal.Count; i++)
            {
                if (listOriginal[i] % 2 == 0)
                {
                    listEven.Add(listOriginal[i]);
                }
            }
        }

        void moveList(List<int> listOriginal, List<int> listEven)
        {
            for(int i = 0; i < listOriginal.Count; i++)
            {
                if (listOriginal[i] % 2 == 0)
                {
                    listEven.Add(listOriginal[i]);
                    listOriginal.RemoveAt(i);
                }
            }
        }

        string mostrarLista(List<int> list)
        {
            string texto = "";
            for(int i = 0; i < list.Count; i++)
            {
                texto += list[i] + ", ";
            }
            return texto;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            readList(listOriginal);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            listEven.Clear();
            copyList(listOriginal, listEven);
            MessageBox.Show("Lista: " + mostrarLista(listOriginal) + "\n" +
                            "Even Lista: " + mostrarLista(listEven));
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            listEven.Clear();
            moveList(listOriginal, listEven);
            MessageBox.Show("Lista: " + mostrarLista(listOriginal) + "\n" +
                            "Even Lista: " + mostrarLista(listEven));
        }
    }
}
