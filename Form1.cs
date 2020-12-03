using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string input = string.Empty;        //String storing user input
        string operand1 = string.Empty;     //String storing first operand
        string operand2 = string.Empty;     //String storing second operand
        char operation;                     //Char for operation
        double result = 0.0;                //Calculated result
        public Form1()
        {
            InitializeComponent();
        }

        private void zero_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text += input;
        }

        private void point_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += ".";
            this.textBox1.Text += input;
        }

        private void clear_Click(object sender, EventArgs e)//Clear event handler
        {
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;

        }

        private void one_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text += input;
        }

        private void two_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;
        }

        private void three_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += input;
        }

        private void four_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;
        }

        private void five_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += input;
        }

        private void six_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;

        }

        private void plus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;

        }

        private void times_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;

        }

        private void divide_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;

        }

        private void equals_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if(operation == '+')
            {
                result = num1 + num2;
                textBox1.Text = result.ToString();
            }else if(operation == '-')
            {
                result = num1 - num2;
                textBox1.Text = result.ToString();
            }else if(operation == '*')
            {
                result = num1 * num2;
                textBox1.Text = result.ToString();
            }else if(operation == '/')
            {
                if(num2 != 0)
                {
                    result = num1 / num2;
                    textBox1.Text = result.ToString();
                }
                else
                {
                    textBox1.Text = "DIV/Zero!";
                }
            }

        }
    }
}
