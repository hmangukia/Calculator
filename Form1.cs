using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        Double o,result; //variable o is to save the value of the textbox as double
        String s; //stores the operator
        Decimal cv,memory=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = button4.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + button4.Text;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length-1,1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = button7.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + button7.Text;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = button6.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + button6.Text;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = button9.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + button9.Text;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = button8.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + button8.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = button3.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + button3.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = button5.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + button5.Text;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = button10.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + button10.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = button1.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + button1.Text;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button12.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = button11.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + button11.Text;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            o = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            s = "+";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            o = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            s = "-";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            o = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            s = "*";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            o = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            s = "/";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            cv = Decimal.Parse(textBox1.Text);
            cv = cv / 100;
            textBox1.Text = cv.ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            cv = Decimal.Parse(textBox1.Text);
            cv = (decimal)Math.Sqrt((double)cv);
            textBox1.Text = cv.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            memory = memory - Decimal.Parse(textBox1.Text);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            memory = memory + Decimal.Parse(textBox1.Text);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            memory = 0;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = memory.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Double v;
            v = Convert.ToDouble(textBox1.Text);
            if (s == "+")
            {
                result = o + v;
                textBox1.Text = Convert.ToString(result);
                o = result;
            }
            if (s == "-")
            {
                result = o - v;
                textBox1.Text = Convert.ToString(result);
                o = result;
            }
            if (s == "*")
            {
                result = o * v;
                textBox1.Text = Convert.ToString(result);
                o = result;
            }
            if (s == "/")
            {
                if (v == 0)
                {
                    textBox1.Text = "Undefined";
                }
                else
                {
                    result = o / v;
                    textBox1.Text = Convert.ToString(result);
                    o = result;
                }
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            result = 0;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
    }
}
