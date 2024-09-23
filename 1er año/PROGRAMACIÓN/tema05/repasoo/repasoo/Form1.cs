using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace repasoo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btn_Click(object sender, EventArgs e)
        {
            int j = 2;
            int s = 0;
            int n;
            n = int.Parse(txtNum.Text);

            while (j <= n / 2)
            {
                if (n % j == 0)
                {
                    s++;
                }
                j++;
            }

            if (s == 0)
                MessageBox.Show(n + "es primo");
            else
                MessageBox.Show(n + "no es primo");


        }
    }
}
