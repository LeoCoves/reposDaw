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

namespace Ejercicio03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> listOriginal = new List<int>();
        List<int> listPrime = new List<int>();

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

        bool isPrime(int num)
        {
            bool searched = true;
            if(num > 1)
            {
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        searched = false;
                    }
                }
            }
            else
            {
                searched = true;
            }
            return searched;
        }

        void copyList(List<int> listOriginal, List<int> listPrime)
        {
            for (int i = 0; i < listOriginal.Count; i++)
            {
                if (isPrime(listOriginal[i]))
                {
                    listPrime.Add(listOriginal[i]);
                }
            }
        }

        void moveList(List<int> listOriginal, List<int> listPrime)
        {
            for (int i = 0; i < listOriginal.Count; i++)
            {
                if (isPrime(listOriginal[i]))
                {
                    listPrime.Add(listOriginal[i]);
                    listOriginal.RemoveAt(i);
                }
            }
        }

        string mostrarLista(List<int> list)
        {
            string texto = "";
            for (int i = 0; i < list.Count; i++)
            {
                texto += list[i] + ", ";
            }
            return texto;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            listOriginal.Clear();
            readList(listOriginal);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            listPrime.Clear();
            copyList(listOriginal, listPrime);
            MessageBox.Show("Lista: " + mostrarLista(listOriginal) + "\n" +
                            "Prime Lista: " + mostrarLista(listPrime));
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            listPrime.Clear();
            moveList(listOriginal, listPrime);
            MessageBox.Show("Lista: " + mostrarLista(listOriginal) + "\n" +
                            "Prime Lista: " + mostrarLista(listPrime));
        }
    }
}
