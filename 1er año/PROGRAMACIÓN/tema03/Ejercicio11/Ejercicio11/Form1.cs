using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {

            int horas, minutos, segundos;

            horas = int.Parse(txt1.Text);
            minutos = int.Parse(txt2.Text);
            segundos = int.Parse(txt3.Text);

            if ((horas >= 0 && horas <= 23) && (minutos >= 0 && minutos < 59) && (segundos >= 0 && segundos <= 59))
            {
                segundos++;

                if(segundos > 59)
                {
                    minutos++;
                    segundos = 0;
                }

                if (minutos > 59)
                {
                    horas++;
                    minutos = 0;
                }

                if (horas > 23)
                {
                    horas = 00;
                }

                MessageBox.Show($"La hora es: {horas} horas, {minutos} minutos y {segundos} segundos.");
            }

            else
            {
                MessageBox.Show("Formato no valido");
            }
        }
    }
}
