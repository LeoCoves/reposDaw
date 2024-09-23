using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {


                int res;

                res = int.Parse(txt1.Text);

                switch (res)
                {
                    case 1:
                        MessageBox.Show("Se ha mostrado el 1");
                        break;

                    case 2:
                        MessageBox.Show("Se ha mostrado el 2");
                        break;

                    case 3:
                        MessageBox.Show("Se ha mostrado el 3");
                        break;

                    case 4:
                        MessageBox.Show("Se ha mostrado el 4");
                        break;

                    case 5:
                        MessageBox.Show("Se ha mostrado el 5");
                        break;

                    default:
                        MessageBox.Show("Numero inválido");
                        break;
                }

            } 
            
            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido este error:" + fEx.Message);
            }
        }
    }
}
