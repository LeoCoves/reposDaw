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
                num = int.Parse(Interaction.InputBox("Introduce a number: "));
                list.Add(num);


                more = MessageBox.Show("Do you want write another value?", "value", MessageBoxButtons.YesNo);

            } while (more == DialogResult.Yes);
        }

        
        string showList(List<int> list)
        {
            string text = "";

            for (int i = 0; i < list.Count; i++)
            {
                text = text + list[i] + ", ";
            }

            text += "\n";

            return text;
        }

        string showBothLists(List<int> listOriginal, List<int> listEven)
        {
            string text;

            text = "First list: " + showList(listOriginal) + "\n";
            text += "Even list: " + showList(listEven);

            return text;
        }

        void copyEvenNum(List<int> listOriginal, List<int> listEven)
        {
            int i;
            int num;

            for (i = 0; i < listOriginal.Count; i++)
            {
                num = listOriginal[i];

                if (num % 2 == 0)
                {
                    listEven.Add(listOriginal[i]);
                }
            }
        }
        void moveEvenNum(List<int> listOriginal, List<int> listEven)
        {
            int i = 0;

            while (i < listOriginal.Count)
            {
                if (listOriginal[i] % 2 == 0)
                {
                    listEven.Add(listOriginal[i]);
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
            MessageBox.Show(showBothLists(listOriginal, listEven));
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            listEven.Clear();
            copyEvenNum(listOriginal, listEven);
            MessageBox.Show(showBothLists(listOriginal, listEven));
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            listEven.Clear();
            moveEvenNum(listOriginal, listEven);
            MessageBox.Show(showBothLists(listOriginal, listEven));
        }

        
    }
}
