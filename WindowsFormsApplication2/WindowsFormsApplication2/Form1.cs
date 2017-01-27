using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        private int _id;

        public Form1()
        {
            InitializeComponent();
            foreach (var button in Controls.OfType<Button>())
            {
                button.Click += delegate(object sender, EventArgs args)
                {
                    var clickedButton = (Button) sender;
                    var ost = _id % 2;
                    clickedButton.Text = (ost == 0 ? "X" : "O");
                    clickedButton.Enabled = false;
                    ProverkaEnd();
                    _id++;
                };
            }
        }
        public void ProverkaEnd()
        {
            if(button1.Text=="X" && button2.Text=="X" && button3.Text == "X" || button4.Text=="X" && button5.Text=="X" && button6.Text == "X" || button7.Text == "X" && button8.Text == "X" && button9.Text == "X" || button1.Text == "X" && button5.Text == "X" && button9.Text == "X" || button7.Text == "X" && button5.Text == "X" && button3.Text == "X" || button1.Text == "X" && button4.Text == "X" && button7.Text == "X" || button2.Text == "X" && button5.Text == "X" && button8.Text == "X" || button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("Выиграли Х");
                ResetField();
            }
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O" || button4.Text == "O" && button5.Text == "O" && button6.Text == "O" || button7.Text == "O" && button8.Text == "O" && button9.Text == "O" || button1.Text == "O" && button5.Text == "O" && button9.Text == "O" || button7.Text == "O" && button5.Text == "O" && button3.Text == "O" || button1.Text == "O" && button4.Text == "O" && button7.Text == "O" || button2.Text == "O" && button5.Text == "O" && button8.Text == "O" || button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("Выиграли O");
                ResetField();
            }
        }

        private void ResetField()
        {
            foreach (var button in Controls.OfType<Button>())
            {
                button.Text = "";
                button.Enabled = true;
            }
        }
    }
}
