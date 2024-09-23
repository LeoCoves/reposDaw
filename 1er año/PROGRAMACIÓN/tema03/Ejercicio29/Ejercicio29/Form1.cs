using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtSerie.Text);
            double resultado = 0;

            double i = 1;
            


            while (i <= num)
            {
                if (i % 2 == 0)             
                {
                    resultado -= (1 / i);
                    
                    i++;
                }
                else
                {
                    resultado += (1 / i);
                    
                    i++;
                }
            }


            MessageBox.Show("El resultado es " + resultado.ToString());
        }
        // Otra manera que esta "bien"

        //while (i <= num && signo == false)
        // {

        // resultado += (1 / i) ;
        // signo = true;
        // i++;


        //while (signo == true && i <= num)
        // {
        // resultado -=  1 / i;
        //signo = false;
        //i++;
        // }
        //}
    }
}
