using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            const int NUMERO = 100;
            int i = 3;
            string multiplos = "";

            while (i <= NUMERO)
            {
                multiplos += i + ", ";
                i = i + 3;
            }

            MessageBox.Show(multiplos);
            
        }
    }
}
