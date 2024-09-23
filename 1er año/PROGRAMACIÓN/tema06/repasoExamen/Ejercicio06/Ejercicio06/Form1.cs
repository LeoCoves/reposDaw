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

namespace Ejercicio06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> vector1 = new List<int>();
        List<int> vector2 = new List<int>();
        List<int> vector3 = new List<int>();

        void readList(List<int> list)
        {
            DialogResult more;
            int num;
            do
            {
                num = int.Parse(Interaction.InputBox("Introduce numeros"));
                list.Add(num);

                more = MessageBox.Show("Do you want enter more numbers?", "number", MessageBoxButtons.YesNo);
                list.Sort();
            } while (more == DialogResult.Yes);
        }

        void copyList(List<int> vector1, List<int> vector2, List<int> vector3)
        {
            int i = 0;
            int j = 0;
            while (i < vector1.Count && j < vector2.Count)
            {
                if (vector1[i] <= vector2[j])
                {
                    if (!vector3.Contains(vector1[i]))
                    {
                        vector3.Add(vector1[i]);
                        
                    }
                    i++;
                }
                else
                {
                    if (!vector3.Contains(vector2[j]))
                    {
                        vector3.Add(vector2[j]);
                        
                    }
                    j++;
                }
            }
            
            while(j < vector2.Count)
            {
                if (!vector3.Contains(vector2[j]))
                {
                    vector3.Add(vector2[j]);
                    j++;
                }
                
            }
            while (i < vector1.Count)
            {
                if (!vector3.Contains(vector1[i]))
                {
                    vector3.Add(vector1[i]);
                    i++;
                }
            }
        }

        void moveList(List<int> vector1, List<int> vector2, List<int> vector3)
        {
            int i = 0;
            int j = 0;
            while (i < vector1.Count && j < vector2.Count)
            {
                if (vector1[i] <= vector2[j])
                {
                    if (!vector3.Contains(vector1[i]))
                    {
                        vector3.Add(vector1[i]);
                        vector1.RemoveAt(i);

                    }
                }
                else
                {
                    if (!vector3.Contains(vector2[j]))
                    {
                        vector3.Add(vector2[j]);
                        vector2.RemoveAt(j);
                    }
                }
            }

            while (j < vector2.Count)
            {
                if (!vector3.Contains(vector2[j]))
                {
                    vector3.Add(vector2[j]);
                    vector2.RemoveAt(j);
                }
            }
            while (i < vector1.Count)
            {
                if (!vector3.Contains(vector1[i]))
                {
                    vector3.Add(vector1[i]);
                    vector1.RemoveAt(i);
                }
            }
        }

        string showList(List<int> list)
        {
            string text = "";

            foreach (int num in list)
            {
                text += num + ", ";
            }
            return text;
        }

        string showBothList(List<int> firstList, List<int> secondList, List<int> thirdList)
        {
            string text;
            text = "\nThe first list is: \n" + showList(firstList);
            text += "\nThe second list is: \n" + showList(secondList);
            text += "\nThe third list is: \n" + showList(thirdList);

            return text;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            readList(vector1);
            MessageBox.Show("Now the second list");
            readList(vector2);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            vector3.Clear();
            copyList(vector1, vector2, vector3);
            MessageBox.Show(showBothList(vector1, vector2, vector3));
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            vector3.Clear();
            moveList(vector1, vector2, vector3);
            MessageBox.Show(showBothList(vector1, vector2, vector3));
        }
    }
}
