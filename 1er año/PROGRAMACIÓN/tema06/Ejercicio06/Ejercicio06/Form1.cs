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

namespace Ejercicio06
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
                num = int.Parse(Interaction.InputBox("Introduce a value"));
                list.Add(num);

                more = MessageBox.Show("Do you want introduce more values?", "value", MessageBoxButtons.YesNo);
            } while (more == DialogResult.Yes);
        }

        void sortList(List<int> list)
        {
            if(list.Count > 1)
            {
                list.Sort();
            }
            else
            {
                MessageBox.Show("Introduce more values");
            }
        }

        string showList(List<int> list)
        {
            string text = "The list is: ";

            foreach (int num in list)
            {
                text += num + ", ";
            }
            return text;
        }

        string showBothList(List<int> firstList, List<int> secondList)
        {
            string text;
            text = "The first list is: \n" + showList(firstList);
            text += "The second list is: \n" + showList(secondList);

            return text;
        }

        void moveList(List<int> firstList, List<int> secondList, List<int> thirdList)
        {
            int i = 0;
            int j = 0;

            while(i < firstList.Count && i < secondList.Count)
            {
                if (firstList[i] < secondList[j])
                {
                    if (!thirdList.Contains(firstList[i]))
                    {
                        thirdList.Add(firstList[i]);
                    }
                    i++;
                }
                else
                {
                    if (!thirdList.Contains(secondList[j]))
                    {
                        thirdList.Add(secondList[j]);
                    }
                    j++;
                }
            }
            while(i < firstList.Count)
            {
                if (!thirdList.Contains(firstList[i]))
                {
                    thirdList.Add(firstList[i]);
                }
                i++;
            }
            while(j < secondList.Count)
            {
                if (!thirdList.Contains(secondList[j]))
                {
                    thirdList.Add(secondList[j]);
                }
                j++;
            }
        }

        private void btnRead1_Click(object sender, EventArgs e)
        {
            readList(firstList);
        }

        private void btnRead2_Click(object sender, EventArgs e)
        {
            readList(secondList);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            sortList(firstList);
            sortList(secondList);
            MessageBox.Show(showBothList(firstList, secondList));
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            moveList(firstList, secondList);
            MessageBox.Show(showList(thirdList));
        }
    }
}
