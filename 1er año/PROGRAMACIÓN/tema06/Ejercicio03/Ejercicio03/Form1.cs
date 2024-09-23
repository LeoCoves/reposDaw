using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
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
                num = int.Parse(Interaction.InputBox("Introduce a number into the list: "));
                list.Add(num);

                more = MessageBox.Show("Do you want introduce more values?", "value", MessageBoxButtons.YesNo);
            } while (more == DialogResult.Yes);
        }

        bool isPrime(int num)
        {
            bool searched = true;

            if (num <= 1)
            {
                searched = false;
            }
            else
            {
                for (int i = 2; i <= num/2 && !searched; i++)
                {
                    if (num % i == 0)
                    {
                        searched = false;
                    }
                }
            }
            return searched;
        }
       

        string showList(List<int> listOriginal)
        {
            string text = "";

            for(int i = 0; i < listOriginal.Count; i++)
            {
                text += listOriginal[i] + ", ";
            }
            text += "\n";

            return text;
        }

        string showBothList(List<int> listOriginal, List<int> listPrime)
        {
            string text;
            text = "The first list: " + showList(listOriginal) + "\n";
            text += "The prime list: " + showList(listPrime);

            return text;
        }

        void copyList(List<int> listOriginal, List<int> listPrime)
        {
           foreach(int num in listOriginal)
            {
                if (isPrime(num))
                {
                    listPrime.Add(num);
                }
            }
        }

        void moveList(List<int> listOriginal, List<int> listPrime)
        {
            int i = 0;

            while (i < listOriginal.Count)
            {
                if (isPrime(listOriginal[i]))
                {
                    listPrime.Add(listOriginal[i]);
                    listOriginal.RemoveAt(i);
                }
                else
                    i++;
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            readList(listOriginal);
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            string text = showBothList(listOriginal, listPrime);
            MessageBox.Show(text);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            listPrime.Clear();
            copyList(listOriginal, listPrime);
            MessageBox.Show(showBothList(listOriginal, listPrime));
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            listPrime.Clear();
            moveList(listOriginal, listPrime);
            MessageBox.Show(showBothList(listOriginal, listPrime));
        }
    }
}
