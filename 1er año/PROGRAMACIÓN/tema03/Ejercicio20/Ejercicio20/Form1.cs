﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);
            int exponente = int.Parse(txtExponente.Text);
            int resultado = 1;
            int i = 0;

            while(i < exponente)
            {
                resultado = resultado * numero;
                i++;
            }
            MessageBox.Show(resultado.ToString());
        }
    }
}