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

        List<int> listNum = new List<int>();

        void readList(List<int> list)
        {
            DialogResult more;
            int num = int.Parse(Interaction.InputBox("Introdce el primero"));
            list.Add(num);
            
            while(list.Count < 2)
            {
                num = int.Parse(Interaction.InputBox("Introdce el primero"));
                if (num > list[0])
                {
                    list.Add(num);
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            
            more = MessageBox.Show("Yesss?", "num", MessageBoxButtons.YesNo);

            while (more == DialogResult.Yes) 
            {
                num = int.Parse(Interaction.InputBox("Introduce"));
                int n = suma(listNum, num);

                if (comprobar(n, num))
                {
                    list.Add(num);
                }
                else
                {
                    MessageBox.Show("No");
                }

                more = MessageBox.Show("Yesss?", "num", MessageBoxButtons.YesNo);
            } 
        }

        int suma(List<int> listNum, int num)
        {
            int suma = 0;

            for(int i = listNum.Count - 2; i < listNum.Count; i++)
            {
                suma += listNum[i];
            }
            return suma;
        }

        bool comprobar(int suma, int num)
        {
            bool encontrado = false;
            if(num > suma)
            {
                encontrado = true;
            }
            return encontrado;

        }

        string showList(List<int> list)
        {
            string texto = "La lista es \n";
            for(int i = 0; i < list.Count; i++)
            {
                texto += list[i] + ", ";
            }
            return texto;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            readList(listNum);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            showList(listNum);
        }
    }
}
