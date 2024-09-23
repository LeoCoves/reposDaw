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

namespace Ejercicio08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> numbersWinner = new List<int>();
        List<int> numbersUser = new List<int>();

        void calcNumbersWinner(List<int> primitiveList)
        {
            int num;
            Random numRandom = new Random();

            while (numbersWinner.Count < 6)
            {
                num = numRandom.Next(0,50);
                if(!numbersWinner.Contains(num))
                {
                    numbersWinner.Add(num);
                }
            }
        }

        void readMyLottery(List<int> numbersUser)
        {
            int num;

            while(numbersUser.Count < 6)
            {
                num = int.Parse(Interaction.InputBox("Enter a number"));
                if(num > 0 && num < 50)
                {
                    if (!numbersUser.Contains(num))
                    {
                        numbersUser.Add(num);
                    }
                    else
                    {
                        MessageBox.Show("Enter a non-repeated number");
                    }
                }
                else
                {
                    MessageBox.Show("Enter a number between 1 and 49");
                }
            }
        }

        int checkWinner(List<int> numbersWinner, List<int> numbersUser)
        {
            int numAcerted = 0;
            int i = 0;

            while(i < 6)
            {
                int j = 0;
                while(j < 6)
                {
                    if (numbersWinner[i] == numbersUser[j])
                    {
                        numAcerted++;
                    }
                    j++;
                }
                i++;
            }
            return numAcerted;
        }

        string showList(List<int> list)
        {
            string text = "The lottery numbers is: ";

            foreach (int num in list)
            {
                text += num + ", ";
            }
            return text;
        }

        private void ReadRandomLottery_Click(object sender, EventArgs e)
        {
            calcNumbersWinner(numbersWinner);
        }

        private void ReadMyLottery_Click(object sender, EventArgs e)
        {
            numbersUser.Clear();
            readMyLottery(numbersUser);
            MessageBox.Show(showList(numbersUser));
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            switch (checkWinner(numbersWinner, numbersUser))
            {
                case 0:
                    MessageBox.Show("You dont have any number winner");
                    break;
                case 1:
                    MessageBox.Show("You have one number winner");
                    break;
                case 2:
                    MessageBox.Show("You have two numbers winner");
                    break;
                case 3:
                    MessageBox.Show("You have three numbers winner");
                    break;
                case 4:
                    MessageBox.Show("You have four numbers winner");
                    break;
                case 5:
                    MessageBox.Show("You have five numbers winner");
                    break;
                case 6:
                    MessageBox.Show("You are the winner!!!");
                    break;
            }
            MessageBox.Show("The winner list is: \n" + showList(numbersWinner) + 
                            "and your lottery is: \n" + showList(numbersUser));
        }
    }
}
