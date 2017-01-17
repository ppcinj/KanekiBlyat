using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public int id = 0;
        public void ProverkaEnd()
        {
            if(button1.Text=="X" && button2.Text=="X" && button3.Text == "X" || button4.Text=="X" && button5.Text=="X" && button6.Text == "X" || button7.Text == "X" && button8.Text == "X" && button9.Text == "X" || button1.Text == "X" && button5.Text == "X" && button9.Text == "X" || button7.Text == "X" && button5.Text == "X" && button3.Text == "X" || button1.Text == "X" && button4.Text == "X" && button7.Text == "X" || button2.Text == "X" && button5.Text == "X" && button8.Text == "X" || button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("Выиграли Х");
                button1.Text = "";
                button1.Enabled = true;
                button2.Text = "";
                button2.Enabled = true;
                button3.Text = "";
                button3.Enabled = true;
                button4.Text = "";
                button4.Enabled = true;
                button5.Text = "";
                button5.Enabled = true;
                button6.Text = "";
                button6.Enabled = true;
                button7.Text = "";
                button7.Enabled = true;
                button8.Text = "";
                button8.Enabled = true;
                button9.Text = "";
                button9.Enabled = true;
            }
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O" || button4.Text == "O" && button5.Text == "O" && button6.Text == "O" || button7.Text == "O" && button8.Text == "O" && button9.Text == "O" || button1.Text == "O" && button5.Text == "O" && button9.Text == "O" || button7.Text == "O" && button5.Text == "O" && button3.Text == "O" || button1.Text == "O" && button4.Text == "O" && button7.Text == "O" || button2.Text == "O" && button5.Text == "O" && button8.Text == "O" || button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("Выиграли O");
                button1.Text = "";
                button1.Enabled = true;
                button2.Text = "";
                button2.Enabled = true;
                button3.Text = "";
                button3.Enabled = true;
                button4.Text = "";
                button4.Enabled = true;
                button5.Text = "";
                button5.Enabled = true;
                button6.Text = "";
                button6.Enabled = true;
                button7.Text = "";
                button7.Enabled = true;
                button8.Text = "";
                button8.Enabled = true;
                button9.Text = "";
                button9.Enabled = true;
            }
        }
        
           
        

        private void button1_Click(object sender, EventArgs e)
        {
            int ost = id % 2;
            if (ost == 0)
            {
                button1.Text = "X";
            }
            else
            {
                button1.Text = "O";
            }
            ProverkaEnd();
            button1.Enabled = false;
            id++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ost = id % 2;
            if (ost == 0)
            {
                button2.Text = "X";
            }
            else
            {
                button2.Text = "O";
            }
            button2.Enabled = false;
            ProverkaEnd();
            id++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ost = id % 2;
            if (ost == 0)
            {
                button3.Text = "X";
            }
            else
            {
                button3.Text = "O";
            }
            button3.Enabled = false;
            ProverkaEnd();
            id++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int ost = id % 2;
            if (ost == 0)
            {
                button4.Text = "X";
            }
            else
            {
                button4.Text = "O";
            }
            button4.Enabled = false;
            ProverkaEnd();
            id++;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int ost = id % 2;
            if (ost == 0)
            {
                button5.Text = "X";
            }
            else
            {
                button5.Text = "O";
            }
            button5.Enabled = false;
            ProverkaEnd();
            id++;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int ost = id % 2;
            if (ost == 0)
            {
                button6.Text = "X";
            }
            else
            {
                button6.Text = "O";
            }
            button6.Enabled = false;
            ProverkaEnd();
            id++;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int ost = id % 2;
            if (ost == 0)
            {
                button7.Text = "X";
            }
            else
            {
                button7.Text = "O";
            }
            button7.Enabled = false;
            ProverkaEnd();
            id++;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int ost = id % 2;
            if (ost == 0)
            {
                button8.Text = "X";
            }
            else
            {
                button8.Text = "O";
            }
            button8.Enabled = false;
            ProverkaEnd();
            id++;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int ost = id % 2;
            if (ost == 0)
            {
                button9.Text = "X";
            }
            else
            {
                button9.Text = "O";
            }
            button9.Enabled = false;
            ProverkaEnd();
            id++;
        }
    }
}
