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

namespace Ejercicio04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> listBase = new List<int>();
        List<int> listExp = new List<int>();
        List<int> listRes = new List<int>();

        void readList(List<int> list)
        {
            for(int i = 0; i < 10; i++)
            {
                int num = int.Parse(Interaction.InputBox("Introduce"));
                list.Add(num);
            }
        }

        int potencia(int a, int b)
        {
            int num = 1;

            if(a == 0)
            {
                num = 0;
            }
            else
            {
                for(int i = 0; i < b; i++)
                {
                    num *= a;
                }
            }
            return num;
        }

        void calcular(List<int> listBase, List<int> listExp, List<int> listRes)
        {
            int num;
            for(int i = 0; i < 10; i++)
            {
                num = potencia(listBase[i], listExp[i]);
                listRes.Add(num);
            }
        }

        string showList(List<int> list)
        {
            string texto = "La lista es: \n";
            for(int i = 0; i < 10; i++)
            {
                texto += list[i] + ", ";
            }
            return texto;
        }

        private void btnBase_Click(object sender, EventArgs e)
        {
            readList(listBase);
        }

        private void btnExponent_Click(object sender, EventArgs e)
        {
            readList(listExp);
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            calcular(listBase, listExp, listRes);
            MessageBox.Show(showList(listRes));
        }
    }
}
