using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> firstList = new List<int>();
        List<int> secondList = new List<int>();
        List<int> thirdList = new List<int>();

        void readList(List<int> list)
        {
            DialogResult more;
            int num;

            do
            {
                num = int.Parse(Interaction.InputBox("Introduce un numero"));
                list.Add(num);

                more = MessageBox.Show("Do you want introduce more values?", "value", MessageBoxButtons.YesNo);
            } while (more == DialogResult.Yes);
        }

        string showList(List<int> list)
        {
            string text = "The list is: ";

            foreach(int num in list)
            {
                text += num + ", ";
            }
            return text;
        }


        string showBothList(List<int> firstList, List<int> secondList)
        {
            string text;
            text = "The first list: \n" + showList(firstList);
            text += "The second list: \n" + showList(secondList);

            return text;
        }

        void moveList(List<int> firstList, List<int> secondList)
        {
            int i = 0;
            int j = 0;

            while (i < firstList.Count && j < secondList.Count)
            {
                if (firstList[i] < secondList[j])
                {
                    thirdList.Add(firstList[i]);
                    firstList.RemoveAt(i);
                }
                else 
                {
                    thirdList.Add(secondList[j]);
                    secondList.RemoveAt(j);
                }
            }
            while (i < firstList.Count)
            {
                thirdList.Add(firstList[i]);
                firstList.RemoveAt(j);
            }
            while (j < secondList.Count)
            {
                thirdList.Add(secondList[j]);
                secondList.RemoveAt(j);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            readList(firstList);
            readList(secondList); 
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(showBothList(firstList, secondList));
            
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            thirdList.Clear();
            moveList(firstList, secondList);
            MessageBox.Show(showList(thirdList));
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            thirdList.Clear();

        }
    }
}
