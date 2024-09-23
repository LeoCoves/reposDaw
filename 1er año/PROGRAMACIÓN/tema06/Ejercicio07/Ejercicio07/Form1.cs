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

        List<string> nameList = new List<string>();

        void readList(List<string> list)
        {
            DialogResult more;
            string name = Interaction.InputBox("Enter the first name");
            list.Add(name);
            bool inserted = false;

            more = MessageBox.Show("Do you want enter more names?", "name", MessageBoxButtons.YesNo);
            while (more == DialogResult.Yes) 
            {
                name = Interaction.InputBox("Enter a name: ");
                int i = 0;
                inserted = false;

                while (i < list.Count && !inserted)
                {
                    if (string.Compare(name, list[i]) <= 0)
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

        
        string mostrarList(List<string> nameList)
        {
            string text = "The list of names is: \n";

            foreach(string name in nameList)
            {
                text += name + ", ";
            }
            return text;

           
        }

        

        private void btnRead_Click(object sender, EventArgs e)
        {
            readList(nameList);
        }

        private void showList_Click(object sender, EventArgs e)
        {
            string text = mostrarList(nameList);
            MessageBox.Show(text);
        }
    }
}
