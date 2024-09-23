using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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

        List<int> edades = new List<int>();

        void readList(List<int> list)
        {
            DialogResult more;
            int num;
            do
            {
                num = int.Parse(Interaction.InputBox("Introduce"));
                list.Add(num);
                if (mayorEdad(num))
                {
                    MessageBox.Show("Es mayor de edad");
                }
                else
                {
                    MessageBox.Show("No es mayor");
                }

                more = MessageBox.Show("YEs??", "edad", MessageBoxButtons.YesNo);
            } while (more == DialogResult.Yes);
        }

        void minMaxEdad(List<int> list, out int max, out int min)
        {
            max = 0;
            min = list[0];
            for(int i = 0; i <  list.Count; i++)
            {
                if (list[i] > max)
                {
                    max = list[i];
                }
                else if (list[i] < min) 
                {
                    min = list[i];
                }
            }
        }

        bool mayorEdad(int num)
        {
            bool mayor = false;

            if (num >= 18)
            {
                mayor = true;
            }
            return mayor;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            readList(edades);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int max, min;
            minMaxEdad(edades, out max, out min);
            MessageBox.Show("La edad maxima es " + max + " y la minima es " + min);
        }
    }
}
