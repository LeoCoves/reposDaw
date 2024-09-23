using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void boton1_Click(object sender, EventArgs e)
        {
            try
            {
                int num1, num2, num3;
                int ressuma;
                int resproducto;

                num1 = int.Parse(tCuadroTexto1.Text);
                num2 = int.Parse(tCuadroTexto2.Text);
                num3 = int.Parse(tCuadroTexto3.Text);

                ressuma = num1 + num2 + num3;
                resproducto = num1 * num2 * num3;

                tCuadroTexto4.Text = ("La suma es de " + ressuma.ToString() + " y el producto de " + resproducto.ToString());
            }

            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido el error:" +  fEx.Message);   
            }

            catch (DivideByZeroException oEx)
            {
                MessageBox.Show(oEx.Message);
            }
          
        }
    }
}
