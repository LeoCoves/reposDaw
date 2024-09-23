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


namespace Ejercicio01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List <int> numbers = new List<int>();

        private void btn1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(Interaction.InputBox("Introduce a number:"));
            numbers.Add(num);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int pos = int.Parse(Interaction.InputBox("Introduce a position:"));

            if (pos > numbers.Count)
            {
                MessageBox.Show("Introduce a correct position");
            }
            else
            {
                int num = int.Parse(Interaction.InputBox("Introduce a number:"));
                numbers.Insert(pos, num);
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            string text = "The list have this numbers: \n";

            foreach(int num in numbers)
            {
                text += num + ", ";
            }
            MessageBox.Show(text);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            int num = int.Parse(Interaction.InputBox("Introduce a value that you want see the first position:"));

            if (numbers.Contains(num)==true)
            {
                int pos = numbers.IndexOf(num);
                MessageBox.Show(pos.ToString());
            }
            else
            {
                MessageBox.Show("Introduce a correct value");
            }
        }

        

        private void btn5_Click(object sender, EventArgs e)
        {
            string text = "The positions of value: \n";
            int num = int.Parse(Interaction.InputBox("Introduce a number where you want see their positions: "));

            if (numbers.Contains(num) == true)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] == num)
                    {
                        int pos = i;
                        text += pos + ", ";
                    }
                }
                MessageBox.Show(text);
            }
            else
            {
                MessageBox.Show("Introduce a correct value");
            }
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            int num = int.Parse(Interaction.InputBox("Introduce a number where you want Remove the first value: "));

            if (numbers.Contains(num) == true)
            {
                numbers.Remove(num);
                MessageBox.Show("First value remove correctly");
            }
            else
            {
                MessageBox.Show("Insert a correct value");
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            int num = int.Parse(Interaction.InputBox("Introduce a number where you want Remove the value: "));

            if (numbers.Contains(num) == true)
            {
                for (int i = numbers.Count - 1; i >= 0; i--)
                {
                    if (numbers[i] == num)
                    {
                        numbers.RemoveAt(i);
                    }
                }
                MessageBox.Show("Values removed correctly");
            }
            else
            {
                MessageBox.Show("Introduce a correct value");
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            int pos = int.Parse(Interaction.InputBox("Introduce a number where you want Remove the position: "));
            
            if (pos <= numbers.Count)
            {
                numbers.RemoveAt(pos);
                MessageBox.Show("Position removed");
            }
            else
            {
                MessageBox.Show("This position doesn't exist");
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if(numbers.Count > 1)
            {
                numbers.Sort();
                MessageBox.Show("Ordenados correctamente");
            }
            else
            {
                MessageBox.Show("There are not a lot of positions to sort");
            }
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            if (numbers.Count != 0)
            {
                numbers.Clear();
                MessageBox.Show("All clear");
            }
            else
            {
                MessageBox.Show("This List hasn't got values");
            }
        }
    }  
    
}
