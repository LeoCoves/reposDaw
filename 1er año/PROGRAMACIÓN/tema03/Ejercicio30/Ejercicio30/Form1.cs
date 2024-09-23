using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string usuario = (Interaction.InputBox("Escriba su usuario"));
            int contraseña = int.Parse(Interaction.InputBox("Escriba su contraseña"));

            string user = "root";
            int passwrd = 1234;
            int intentos = 4;
            bool acierto = false;

            if (usuario == user && contraseña == passwrd)

            {
                MessageBox.Show("Bienvenido al sistema " + user);
            }

            else
            {
                for (int i = 0; i < intentos && acierto == false; intentos--)
                {
                    MessageBox.Show("Te quedan " + intentos + " intentos");

                    usuario = (Interaction.InputBox("Escriba su usuario"));
                    contraseña = int.Parse(Interaction.InputBox("Escriba su contraseña"));

                    if (usuario == user && contraseña == passwrd)
                    {
                        MessageBox.Show("Bienvenido al sistema " + user);
                        acierto = true;
                        
                    }
                    
                }
                if (acierto == false)
                {
                    MessageBox.Show("Se te acabaron los intentos");
                }
                
                //MessageBox.Show("Se te acabaron los intentos");


            }
            
        }
    }
}
