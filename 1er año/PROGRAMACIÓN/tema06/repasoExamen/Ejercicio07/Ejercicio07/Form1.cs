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

namespace Ejercicio07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> listName = new List<string>();

        void readName(List<string> list)
        {
            int i = 0;
            DialogResult more;
            string name = Interaction.InputBox("Enter the first name");
            list.Add(name);
            more = MessageBox.Show("Do you want enter more names?", "name", MessageBoxButtons.YesNo);
            bool inserted = false;

            while (more == DialogResult.Yes) 
            {
                name = Interaction.InputBox("Enter the first name");

                while(i < list.Count && !inserted)
                {
                    if(string.Compare(name, list[i]) <= 0) // name < list[i] alfabeticamente
                    {
                        list.Insert(i, name);
                        inserted = true;
                    }
                    else
                    {
                        i++;
                    }
                }
                if (!inserted)
                {
                    list.Add(name);
                }
                more = MessageBox.Show("Do you want enter more names?", "name", MessageBoxButtons.YesNo);
            } 
        }

        string showList(List<string> list)
        {
            string texto = "La lista de nombres es: \n";
            for(int i = 0; i < list.Count; i++)
            {
                texto += list[i] + "\n";
            }
            return texto;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            readName(listName);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            showList(listName);
        }
    }
}
