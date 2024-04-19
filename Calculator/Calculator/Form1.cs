using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        StringBuilder sb = new StringBuilder();
        string result1 = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void display()
        {
            input.Text = sb.ToString();
        }

        private void one_Click(object sender, EventArgs e)
        {
            sb.Append("1");
            display();
        }

        private void two_Click(object sender, EventArgs e)
        {
            sb.Append("2");
            display();
        }

        private void Three_Click(object sender, EventArgs e)
        {
            sb.Append("3");
            display();
        }

        private void Four_Click(object sender, EventArgs e)
        {
            sb.Append("4");
            display();
        }

        private void Five_Click(object sender, EventArgs e)
        {
            sb.Append("5");
            display();
        }

        private void Six_Click(object sender, EventArgs e)
        {
            sb.Append("6");
            display();
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            sb.Append("7");
            display();
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            sb.Append("8");
            display();
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            sb.Append("9");
            display();
        }

        private void zero_Click(object sender, EventArgs e)
        {
            sb.Append("0");
            display();
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (!sb.ToString().Contains("."))
            {
                sb.Append(".");
            }
            display();
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (isCotainOperator() == ' ')
            {
                sb.Append('+');
                display();
            }
            else
            {
                calculateResult(isCotainOperator());
                sb.Append('+');
                display();
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (isCotainOperator() == ' ')
            {
                sb.Append('-');
                display();
            }
            else
            {
                calculateResult(isCotainOperator());
                sb.Append('-');
                display();
            }
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            if (isCotainOperator() == ' ')
            {
                sb.Append('*');
                display();
            }
            else
            {
                calculateResult(isCotainOperator());
                sb.Append('*');
                display();
            }
        }

        private void devide_Click(object sender, EventArgs e)
        {
            if (isCotainOperator() == ' ')
            {
                sb.Append('/');
                display();
            }
            else
            {
                calculateResult(isCotainOperator());
                sb.Append('/');
                display();
            }
        }
        private void modulo_Click(object sender, EventArgs e)
        {
            if (isCotainOperator() == ' ')
            {
                sb.Append('%');
                display();
            }
            else
            {
                calculateResult(isCotainOperator());
                sb.Append('%');
                display();
            }
        }

        private void backspase_Click(object sender, EventArgs e)
        {
            if (sb.Length != 0)
            {
                sb.Remove(sb.Length - 1, 1);
                display();
                if(sb.Length == 0) 
                    input.Text = "0";
            }
        }

        private void clearInput_Click(object sender, EventArgs e)
        {
            sb.Clear();
            input.Text = "0";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            sb.Clear();
            input.Text = "0";
        }

        private void Answer_Click(object sender, EventArgs e)
        {
            char op = isCotainOperator();
            calculateResult(op);
        }

        private char isCotainOperator()
        {
            if (sb.ToString().Contains("+"))
            {
                return '+';
            }
            else if (sb.ToString().Contains("-"))
            {
                return '-';
            }
            else if (sb.ToString().Contains("*"))
            {
                return '*';
            }
            else if (sb.ToString().Contains("/"))
            {
                return '/';
            }
            else if (sb.ToString().Contains("%"))
            {
                return '%';
            }
            else if (sb.ToString().Contains('='))
            {
                return '=';
            }
            else
            {
                return ' ';
            }
        }

        private void calculateResult(char op)
        {
            string[] Numbers = sb.ToString().Split(op);
            float num1 = Convert.ToInt64(Numbers[0]);
            float num2 = Convert.ToInt64(Numbers[1]);
            
            switch(op)
            {
                case '+':
                    result1 = Convert.ToString(num1 + num2);
                    break;

                case '-':
                    result1 = Convert.ToString(num1 - num2);
                    break;

                case '*':
                    result1 = Convert.ToString(num1 * num2);
                    break;

                case '/':
                    result1 = Convert.ToString(num1 / num2);
                    break;

                case '%':
                    result1 = Convert.ToString(num1 % num2);
                    break;
                
                case '=':
                    result1 = Convert.ToString(num1 + num2);
                    break;
            }

            input.Text = result1;
            sb.Clear();
            sb.Append(result1);
        }
    }
}
