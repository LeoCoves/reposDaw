using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicioo23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso = double.Parse(Interaction.InputBox("Escriba su peso"));
            double totalalumnos = 0;
            double menos50 = 0;
            double entre50y65 = 0;
            double entre65y80 = 0;
            double masde80 = 0;
            
            double pesototal = 0;

            while (peso > 0) 
            {
                
                pesototal += peso;
                totalalumnos++;
                


                if (peso <= 50)
                    {
                        menos50++;
                    }

                    else if (peso > 50 && peso <= 65)
                    {
                        entre50y65++;
                    }

                    else if (peso > 65 && peso <= 80)
                    {
                        entre65y80++;
                    }

                    else
                    {
                        masde80++;
                    }

                peso = double.Parse(Interaction.InputBox("Escriba su peso"));


            } 

            double mediapeso = pesototal / totalalumnos;
            double porcentaje1 = (menos50 / totalalumnos) * 100;
            double porcentaje2 = (entre50y65 / totalalumnos) * 100;
            double porcentaje3 = (entre65y80 / totalalumnos) * 100;
            double porcentaje4 = (masde80 / totalalumnos) * 100;

            MessageBox.Show("Hay un total de " + totalalumnos + "alumnos \n" +
                    menos50 + " alumnos de menos de 50kg \n" +
                    entre50y65 + " alumnos entre 50kg y 65kg \n" +
                    entre65y80 + " alumnos entre 65kg y 80kg \n" +
                    masde80 + " alumnos mas de 80kg \n " +
                    "Los que pesan menos de 50 representan un" + porcentaje1 + " % \n" +
                    "Los que pesan mas de 50 y menos de 65 representan un " + porcentaje2 + " % \n" +
                    "Los que pesan mas de 65 y menos de 80 representan un " + porcentaje3 + " % \n" +
                    "Los que pesan mas de 80 representan un " + porcentaje4 + " % \n" +
                    "La media de peso es " + mediapeso);


        }
    }
}
