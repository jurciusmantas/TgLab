using CalculatorUI.CalculatorReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorUI
{
    public partial class Form1 : Form
    {
        double n1, n2;
        int numberPlaceAfterComma;
        bool containsOperationChar;
        bool containsComma;
        CalculatorClient client;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new CalculatorClient();
            containsOperationChar = false;
            containsComma = false;
        }

        private void buttonComma_Click(object sender, EventArgs e)
        {
            if (!containsComma)
            {
                MainTB.Text += ",";
                numberPlaceAfterComma = 1;
                containsComma = true;
            }
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            int number;
            if (sender == button0)
                number = 0;
            else if (sender == button1)
                number = 1;
            else if (sender == button2)
                number = 2;
            else if (sender == button3)
                number = 3;
            else if (sender == button4)
                number = 4;
            else if (sender == button5)
                number = 5;
            else if (sender == button6)
                number = 6;
            else if (sender == button7)
                number = 7;
            else if (sender == button8)
                number = 8;
            else
                number = 9;

            MainTB.Text += number;

            if (!containsOperationChar)
            {
                if (containsComma)
                {
                    n1 += Math.Pow(0.1, numberPlaceAfterComma) * number;
                    numberPlaceAfterComma++;
                }
                else
                    n1 = n1 * 10 + number;
            }
            else
            {
                if (containsComma)
                {
                    n2 += Math.Pow(0.1, numberPlaceAfterComma) * number;
                    numberPlaceAfterComma++;
                }
                else
                    n2 = n2 * 10 + number;
            }

        }

        private void OperationButton_Click(object sender, EventArgs e)
        {
            if (n2 == 0 && containsOperationChar)
            {
                if (containsComma)
                    MainTB.Text = MainTB.Text.Substring(0, MainTB.Text.Length - 4);
                else
                    MainTB.Text = MainTB.Text.Substring(0, MainTB.Text.Length - 3);
            }
            else if (containsOperationChar)
                buttonAts_Click(new Object(), new EventArgs());

            if (sender == buttonAdd)
                MainTB.Text += " + ";

            else if (sender == buttonPow)
                MainTB.Text += " ^ ";

            else if (sender == buttonDivide)
                MainTB.Text += " / ";

            else if (sender == buttonSub)
                MainTB.Text += " - ";

            else if (sender == buttonMul)
                MainTB.Text += " * ";

            containsOperationChar = true;
            containsComma = false;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            MainTB.Text = "";
            n1 = 0;
            n2 = 0;
            containsComma = false;
            containsOperationChar = false;
            numberPlaceAfterComma = 1;
        }

        private void buttonAts_Click(object sender, EventArgs e)
        {
            if (MainTB.Text.Contains("+"))
                n1 = client.Add(n1, n2);

            else if (MainTB.Text.Contains("-"))
                n1 = client.Subtract(n1, n2);

            else if (MainTB.Text.Contains("/"))
                n1 = client.Divide(n1, n2);

            else if (MainTB.Text.Contains("*"))
                n1 = client.Multiply(n1, n2);

            else if (MainTB.Text.Contains("^"))
                n1 = client.Power(n1, n2);


            n2 = 0;
            MainTB.Text = n1.ToString();
            containsOperationChar = false;
            if (n1 % 1 > 0)
                containsComma = true;

        }
    }
}
