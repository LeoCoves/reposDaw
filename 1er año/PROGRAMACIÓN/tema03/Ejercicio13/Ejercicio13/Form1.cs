using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnfor_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txt1.Text);
            int i;
            string texto = "Los valores son: ";

            
                for (i = 2; i <= numero; i += 2)
                
                    texto = texto + i + ", ";
                    MessageBox.Show(texto);
                
            
        }

        private void btnwhile_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txt1.Text);
            int i = 2;
            string texto = "Los valores son: ";

            while (i <= numero)
            {
                texto = texto + i + ", ";
                i += 2;
            }
            MessageBox.Show(texto);
        }

        private void btndowhile_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txt1.Text);
            int i = 2;
            string texto = "Los valores son";

            do
            {
                texto = texto + i + ", ";
                i += 2;
            } while (i <= numero);

            MessageBox.Show(texto); 
        }
    }
}
