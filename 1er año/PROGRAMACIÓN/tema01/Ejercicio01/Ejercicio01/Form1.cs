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

        private void Boton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha apretado el primer botón.");
        }

        private void Boton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha apretado el segundo botón");
        }
    }
}
