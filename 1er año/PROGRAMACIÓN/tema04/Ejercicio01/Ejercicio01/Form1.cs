﻿using System;
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

        int suma (int num1, int num2)
        {
            int res = num1 + num2;

            return res;


        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            int n1, n2, result;

            n1 = int.Parse(txt1.Text);
            n2 = int.Parse(txt2.Text);

            result = suma(n1, n2);

            MessageBox.Show(result.ToString());
        }
    }
}
