using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
                int n = int.Parse(Interaction.InputBox("Introduce a value: "));
                list.Add(n);
            }
        }

        int potencia(int a, int b)
        {
            int resultado = 1;

            if(a == 0 )
            {
                resultado = 0;
            }
            else
            {
                for(int i = 0; i < b ; i++)
                {
                    resultado *= a;
                }
            }
            return resultado;
        }

        void calcList(List<int> listBase, List<int> listExp)
        {
            int n;

            for(int i = 0; i < listBase.Count; i++)
            {
                n = potencia(listBase[i], listExp[i]);
                listRes.Add(n);
            }
        }

        string showList(List<int> list)
        {
            string text = "The list is: \n";

            foreach(int n in list)
            {
                text += n + ", ";
            }
            return text;
        }

        private void btnBase_Click(object sender, EventArgs e)
        {
            readList(listBase);
            string text = showList(listBase);
            MessageBox.Show(text);
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            readList(listExp);
            string text = showList(listExp);
            MessageBox.Show(text);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            calcList(listBase, listExp);
            string text = showList(listRes);
            MessageBox.Show(text);
        }
    }
}
