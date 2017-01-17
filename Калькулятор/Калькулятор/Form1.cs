using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калькулятор
{
    public partial class Form1 : Form
    {
        double num1 { get; set; }
        double num2 { get; set; }
        string id;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void buttonDrob_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
            buttonDrob.Enabled = false;
        }

        private void buttonNeg_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

            }
            else if (textBox1.Text.First() == '-')
            {
                textBox1.Text = textBox1.Text.Substring(1);
            }
            
            else
            {
                textBox1.Text = '-' + textBox1.Text;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            buttonDrob.Enabled = true;
            Proverka();
                id = "+";
            
        }

        private void buttonDif_Click(object sender, EventArgs e)
        {
            buttonDrob.Enabled = true;  
            Proverka();
            id = ":";

        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            buttonDrob.Enabled = true;
            Proverka();
            id = "*";

        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            buttonDrob.Enabled = true;
           
            Proverka();
            id = "-";

        }

        private void buttonOtv_Click(object sender, EventArgs e)
        {
            buttonDrob.Enabled = true;
            double otvet=0;
            if(textBox1.Text == "")
            {

            }
            else
            {
                num2 = double.Parse(textBox1.Text);
                textBox1.Text = "";
                switch (id)
                {
                    case "+":
                        otvet = num1 + num2;
                        break;
                    case "-":
                        otvet = num1 - num2;
                        break;
                    case ":":
                        otvet = num1 / num2;
                        break;
                    case "*":
                        otvet = num1 * num2;
                        break;
                }
                textBox1.Text = otvet.ToString("N3");
                System.IO.File.AppendAllLines("C:\\Users\\Дмитрий\\Documents\\Visual Studio 2015\\Projects\\разбор форм\\разбор форм\\history.txt",new[] {otvet.ToString() });
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            buttonDrob.Enabled = true;
        }
        void Proverka()
        {
            if (textBox1.Text == "")
            {

            }
            else
            {
                num1 = double.Parse(textBox1.Text);
                textBox1.Text = "";
            }
        } 
    }

}
