using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace calculate_machine
{
    public partial class Form1 : Form
    {
        double a = 0;
        double b = 0;
        bool c = false;
        string d="";
        int k = 0;
        //int equalcount = 0;
        double x = 0;
        public Form1()
        {
            InitializeComponent();

        }
        List<double> num1 = new List<double>();
        List<double> num2 = new List<double>();
        private void button3_Click(object sender, EventArgs e)
        {
            
            if (c == true)
            {
                textBox1.Text = "";
            }
            c = false;
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (c == true)
            {
                textBox1.Text = "";
            }
            c = false;
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (c == true)
            {
                textBox1.Text = "";
            }
            c = false;
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (c == true)
            {
                textBox1.Text = "";
            }
            c = false;
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void dot_Click(object sender, EventArgs e)
        {
            
            if (c == true)
            {
                textBox1.Text = "";
            }
            c = false;
            textBox1.Text += ".";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            
            if (c == true)
            {
                textBox1.Text = "";
            }
            c = false;
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }
            if (d == "/")
            {
                textBox1.Clear();
                MessageBox.Show("除数不能为0，错误");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            if (c == true)
            {
                textBox1.Text = "";
            }
            c = false;
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            if (c == true)
            {
                textBox1.Text = "";
            }
            c = false;
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            if (c == true)
            {
                textBox1.Text = "";
            }
            c = false;
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            if (c == true)
            {
                textBox1.Text = "";
            }
            c = false;
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            if (c == true)
            {
                textBox1.Text = "";
            }
            c = false;
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            c = true;
            b = double.Parse(textBox1.Text);
            double sum1 = 1;
            switch (d)
            {
                case "":num2.Add(b);break;
                case "+": num2.Add(b); break;
                case "-": num2.Add(-b); break;
                case "*":
                    {
                        num1.Add(b);
                        for (int i = 0; i < num1.Count; i++)
                        {
                            sum1 *= num1[i];
                        }
                        num2.Add(sum1);
                        num1.Clear();
                        break;
                    }
                case "/":
                    {
                        num1.Add(1/b);
                        for (int i = 0; i < num1.Count; i++)
                        {
                            sum1 *= num1[i];
                        }
                        num2.Add(sum1);
                        num1.Clear();
                        break;
                    }
            }
            //num1.Add
            d = "+";
            k= 1;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            c = true;
            b = double.Parse(textBox1.Text);
            double sum1 = 1;
            switch (d)
            {
                case "":num2.Add(b);break;
                case "+": num2.Add(b); break;
                case "-": num2.Add(-b); break;
                case "*":
                    {
                        num1.Add(b);
                        for (int i = 0; i < num1.Count; i++)
                        {
                            sum1 *= num1[i];
                        }
                        num2.Add(sum1);
                        num1.Clear();
                        break;
                    }
                case "/":
                    {
                        num1.Add(1 / b);
                        for (int i = 0; i < num1.Count; i++)
                        {
                            sum1 *= num1[i];
                        }
                        num2.Add(sum1);
                        num1.Clear();
                        break;
                    }
            }
            d = "-";
            k = 1;
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            c = true;
            b = double.Parse(textBox1.Text);
            switch (d)
            {
                case "":num1.Add(b);break;
                case "+": num1.Add(b); break;
                case "-": num1.Add(-b); break;
                case "*": num1.Add(b); break;
                case "/": num1.Add(1 / b); break;
            }
            d = "*";
            k = 1;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            c = true;
            b = double.Parse(textBox1.Text);
            switch (d)
            {
                case "":num1.Add(b);break;
                case "+": num1.Add(b); break;
                case "-": num1.Add(-b); break;
                case "*": num1.Add(b); break;
                case "/": num1.Add(1 / b); break;
            }
            d = "/";
            k = 1;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            
            //equalcount++;
            if (k==1)
            {
                double sum1 = 1, sum2 = 0;
                b = double.Parse(textBox1.Text);
                switch (d)
                {
                    case "": a = double.Parse(textBox1.Text); break;
                    case "+":
                        {
                            num2.Add(b);
                            break;
                        }
                    case "-":
                        {
                            num2.Add(-b);
                            break;
                        }
                    case "*":
                        {
                            num1.Add(b);
                            for (int i = 0; i < num1.Count; i++)
                            {
                                sum1 *= num1[i];
                            }
                            num2.Add(sum1);
                            num1.Clear();
                            break;
                        }
                    case "/":
                        {
                            num1.Add(1 / b);
                            for (int i = 0; i < num1.Count; i++)
                            {
                                sum1 *= num1[i];
                            }
                            num2.Add(sum1);
                            num1.Clear();
                            break;
                        }
                }
                for (int j = 0; j < num2.Count; j++)
                {
                    sum2 += num2[j];
                }
                a = sum2;
                x = sum2;
                textBox1.Text = a.ToString();
            }
            if(k==2)
            {
                switch (d)
                {
                    case "+":x =x+b;break;
                    case "-":x = x - b;break;
                    case "*":x = x * b;break;
                    case "/":x = x / b;break;
                }
                a = x;
                textBox1.Text = a.ToString();
            }
            num2.Clear();
            k = 2;
            c = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            c = true;
            textBox1.Text = "";
        }
    }
}
