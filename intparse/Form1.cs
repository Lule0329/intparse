using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intparse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total = 0;

            // Kör loopen för varje bokstav för att kolla om det är en siffra eller bokstav
            // genom att kolla ASCII värdet på talet. 
            for(int i = 0; i < textBox1.Text.Length; i++)
            {
                total *= 10;
                total += textBox1.Text[i] - 48;
            }

            label1.Text = total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string inputString = textBox1.Text;
            int numericValue = 0;

            // Kör loopen för varje bokstav för att kolla om det är en siffra eller bokstav
            // genom att kolla ASCII värdet av talet. Fast tar inte med bokstäver i output.
            for (int i = 0; i < inputString.Length; i++)
            {
                if (char.IsDigit(inputString[i]))
                {
                    numericValue = numericValue * 10 + (inputString[i] - '0');
                }
            }
            label1.Text = numericValue.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string inputString = textBox1.Text;
            int numericValue = 0;

            // Kör loopen för varje bokstav för att kolla om det är en siffra eller bokstav
            // genom att kolla ASCII värdet av talet. Fast den slutar om det är en bokstav i talet.
            // T.ex 12ab34, blir 12.
            for (int i = 0; i < inputString.Length; i++)
            {
                if (char.IsDigit(inputString[i]))
                {
                    numericValue = numericValue * 10 + (inputString[i] - '0');
                }
                else // Så fort det kommer en bokstav så avslutas loopen
                {
                    break;
                }
            }
            label1.Text = numericValue.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string inputString = textBox1.Text;
            int numericValue = 0;
            bool containsLetter = false;

            // Kör loopen för varje bokstav för att kolla om det är en siffra eller bokstav
            // genom att kolla ASCII värdet av talet. Fast om det är en bokstav i talet så sätter den output till 0.
            for (int i = 0; i < inputString.Length; i++)
            {
                if (char.IsDigit(inputString[i]))
                {
                    numericValue = numericValue * 10 + (inputString[i] - '0');
                }
                else // om det finns bokstäver så avbryter den
                {
                    containsLetter = true;
                    break;
                }
            }
            
            
            if (containsLetter)
            {
                // om containsLetter är sant så sätter den output till '0'.
                numericValue = 0;
            }

            label1.Text = numericValue.ToString();
        }
    }
}
