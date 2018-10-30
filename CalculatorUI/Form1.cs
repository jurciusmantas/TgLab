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
        bool containsOperationChar;
        CalculatorClient client;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new CalculatorClient();
            containsOperationChar = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainTB.Text += 1;
            if (containsOperationChar)
                n2 = n2 * 10 + 1;
            else
                n1 = n1 * 10 + 1;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (containsOperationChar)
            {
                if (n2 != 0)
                    MainTB.Text += 0;
                n2 = n2 * 10;
            }

            else
            {
                if (n1 != 0)
                    MainTB.Text += 0;
                n1 = n1 * 10;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainTB.Text += 2;
            if (containsOperationChar)
                n2 = n2 * 10 + 2;
            else
                n1 = n1 * 10 + 2;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            MainTB.Text += " + ";
            containsOperationChar = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainTB.Text += 3;
            if (containsOperationChar)
                n2 = n2 * 10 + 3;
            else
                n1 = n1 * 10 + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainTB.Text += 4;
            if (containsOperationChar)
                n2 = n2 * 10 + 4;
            else
                n1 = n1 * 10 + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainTB.Text += 5;
            if (containsOperationChar)
                n2 = n2 * 10 + 5;
            else
                n1 = n1 * 10 + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MainTB.Text += 6;
            if (containsOperationChar)
                n2 = n2 * 10 + 6;
            else
                n1 = n1 * 10 + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MainTB.Text += 7;
            if (containsOperationChar)
                n2 = n2 * 10 + 7;
            else
                n1 = n1 * 10 + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MainTB.Text += 8;
            if (containsOperationChar)
                n2 = n2 * 10 + 8;
            else
                n1 = n1 * 10 + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MainTB.Text += 9;
            if (containsOperationChar)
                n2 = n2 * 10 + 9;
            else
                n1 = n1 * 10 + 9;
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


            n2 = 0;
            MainTB.Text = n1.ToString();
            containsOperationChar = false;
        }
    }
}
