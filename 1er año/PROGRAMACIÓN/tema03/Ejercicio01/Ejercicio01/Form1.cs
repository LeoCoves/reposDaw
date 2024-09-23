using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void boton1_Click(object sender, EventArgs e)
        {

            try 
            {


                int num;

                num = int.Parse(tCuadroTexto1.Text);

                if (num == 2)
                {
                    MessageBox.Show("el número introducido es el dos");
                }

                else 
                {
                    MessageBox.Show("el número introducido NO es el dos");
                }
            }

            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido el error:" + fEx.Message);
            }

            
        }
    }
}
