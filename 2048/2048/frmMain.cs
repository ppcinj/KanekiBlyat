using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace _2048
{
    public partial class frmMain : Form
    {
        public pointData[,] fields = new pointData[4, 4];
        int score = 0;

        public frmMain()
        {
            InitializeComponent();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    fields[i, j] = new pointData();
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    MoveUp();
                    break;
                case Keys.Down:
                    MoveDown();
                    break;
                case Keys.Left:
                    MoveLeft();
                    break;
                case Keys.Right:
                    MoveRight();
                    break;
            }
        }

        private void MoveUp()
        {
            int amountMoved = 0;
            for (int x = 0; x < 4; x++)
            {
                List<pointData> lst = new List<pointData>();

                for (int it = 0; it < 4; it++)
                {
                    lst.Add(new pointData());
                }

                int place = 0;
                for (int y = 0; y < 4; y++)
                {
                    if (fields[x, y].value != 0)
                    {
                        lst[place].value = fields[x, y].value;
                        amountMoved++;
                        place++;
                    }
                }

                int count = 0;
                foreach (pointData pd in lst)
                {
                    fields[x, count] = pd;
                    count++;
                }
            }

            bool merged = MergeUp();

            if (!merged)
            {
                if (amountMoved != 0)
                    AppendRandomNumber();
            }
            else
                MoveUp();
        }

        private bool MergeUp()
        {
            for (int x = 0; x < 4; x++)
            {
                for (int y = 1; y < 4; y++)
                {
                    if ((fields[x, y].value == fields[x, y - 1].value) & fields[x, y].value != 0)
                    {
                        fields[x, y - 1].value *= 2;
                        score += (int)fields[x, y - 1].value;
                        fields[x, y].value = 0;
                        return true;
                    }
                }
            }
            return false;
        }

        private void MoveDown()
        {
            int amountMoved = 0;
            for (int x = 0; x < 4; x++)
            {
                List<pointData> lst = new List<pointData>();

                for (int it = 0; it < 4; it++)
                {
                    lst.Add(new pointData());
                }

                int place = 0;
                for (int y = 3; y >= 0; y--)
                {
                    if (fields[x, y].value != 0)
                    {
                        lst[place].value = fields[x, y].value;
                        amountMoved++;
                        place++;
                    }
                }

                int count = 3;
                foreach (pointData pd in lst)
                {
                    fields[x, count] = pd;
                    count--;
                }
            }

            bool merged = MergeDown();

            if (!merged)
            {
                if (amountMoved != 0)
                    AppendRandomNumber();
            }
            else
                MoveDown();
        }

        private bool MergeDown()
        {
            for (int x = 0; x < 4; x++)
            {
                for (int y = 2; y >= 0; y--)
                {
                    if ((fields[x, y].value == fields[x, y + 1].value) & fields[x, y].value != 0)
                    {
                        fields[x, y + 1].value *= 2;
                        score += (int)fields[x, y + 1].value;
                        fields[x, y].value = 0;
                        return true;
                    }
                }
            }
            return false;
        }

        private void MoveLeft()
        {
            int amountMoved = 0;
            for (int y = 0; y < 4; y++)
            {
                List<pointData> lst = new List<pointData>();

                for (int it = 0; it < 4; it++)
                {
                    lst.Add(new pointData());
                }

                int place = 0;
                for (int x = 0; x < 4; x++)
                {
                    if (fields[x, y].value != 0)
                    {
                        lst[place].value = fields[x, y].value;
                        amountMoved++;
                        place++;
                    }
                }

                int count = 0;
                foreach (pointData pd in lst)
                {
                    fields[count, y] = pd;
                    count++;
                }
            }

            bool merged = MergeLeft();

            if (!merged)
            {
                if (amountMoved != 0)
                    AppendRandomNumber();
            }
            else
                MoveLeft();
        }

        private bool MergeLeft()
        {
            for (int y = 0; y < 4; y++)
            {
                for (int x = 1; x < 4; x++)
                {
                    if ((fields[x, y].value == fields[x - 1, y].value) & fields[x, y].value != 0)
                    {
                        fields[x - 1, y].value *= 2;
                        score += (int)fields[x - 1, y].value;
                        fields[x, y].value = 0;
                        return true;
                    }
                }
            }
            return false;
        }

        private void MoveRight()
        {
            int amountMoved = 0;
            for (int y = 0; y < 4; y++)
            {
                List<pointData> lst = new List<pointData>();

                for (int it = 0; it < 4; it++)
                {
                    lst.Add(new pointData());
                }

                int place = 0;
                for (int x = 3; x >= 0; x--)
                {
                    if (fields[x, y].value != 0)
                    {
                        lst[place].value = fields[x, y].value;
                        amountMoved++;
                        place++;
                    }
                }

                int count = 3;
                foreach (pointData pd in lst)
                {
                    fields[count, y] = pd;
                    count--;
                }
            }

            bool merged = MergeRight();

            if (!merged)
            {
                if (amountMoved != 0)
                    AppendRandomNumber();
            }
            else
                MoveRight();
        }

        private bool MergeRight()
        {
            for (int y = 0; y < 4; y++)
            {
                for (int x = 2; x >= 0; x--)
                {
                    if ((fields[x, y].value == fields[x + 1, y].value) & fields[x, y].value != 0)
                    {
                        fields[x + 1, y].value *= 2;
                        score += (int)fields[x + 1, y].value;
                        fields[x, y].value = 0;
                        return true;
                    }
                }
            }
            return false;
        }

        private void AppendRandomNumber()
        {
            List<Point> lst = new List<Point>();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (fields[i, j].value == 0)
                    {
                        lst.Add(new Point(i, j));
                    }
                }
            }

            if (lst.Count == 0)
            {
                MessageBox.Show("You lost!!!");
                return;
            }

            int rndNum = new Random().Next(0, lst.Count - 1);

            int percentage = new Random().Next(0, 100);

            int valueToAdd = 2;

            if (percentage >= 80)
                valueToAdd = 4;

            fields[lst[rndNum].X, lst[rndNum].Y].value = valueToAdd;

            RedrawField();
        }

        private void RedrawField()
        {
            num1x1y.BackColor = fields[0, 0].color;
            num1x1y.Text = fields[0, 0].value.ToString();
            num1x2y.BackColor = fields[0, 1].color;
            num1x2y.Text = fields[0, 1].value.ToString();
            num1x3y.BackColor = fields[0, 2].color;
            num1x3y.Text = fields[0, 2].value.ToString();
            num1x4y.BackColor = fields[0, 3].color;
            num1x4y.Text = fields[0, 3].value.ToString();
            num2x1y.BackColor = fields[1, 0].color;
            num2x1y.Text = fields[1, 0].value.ToString();
            num2x2y.BackColor = fields[1, 1].color;
            num2x2y.Text = fields[1, 1].value.ToString();
            num2x3y.BackColor = fields[1, 2].color;
            num2x3y.Text = fields[1, 2].value.ToString();
            num2x4y.BackColor = fields[1, 3].color;
            num2x4y.Text = fields[1, 3].value.ToString();
            num3x1y.BackColor = fields[2, 0].color;
            num3x1y.Text = fields[2, 0].value.ToString();
            num3x2y.BackColor = fields[2, 1].color;
            num3x2y.Text = fields[2, 1].value.ToString();
            num3x3y.BackColor = fields[2, 2].color;
            num3x3y.Text = fields[2, 2].value.ToString();
            num3x4y.BackColor = fields[2, 3].color;
            num3x4y.Text = fields[2, 3].value.ToString();
            num4x1y.BackColor = fields[3, 0].color;
            num4x1y.Text = fields[3, 0].value.ToString();
            num4x2y.BackColor = fields[3, 1].color;
            num4x2y.Text = fields[3, 1].value.ToString();
            num4x3y.BackColor = fields[3, 2].color;
            num4x3y.Text = fields[3, 2].value.ToString();
            num4x4y.BackColor = fields[3, 3].color;
            num4x4y.Text = fields[3, 3].value.ToString();

            tsScore.Text = score.ToString();

            if (score > Properties.Settings.Default.highscore)
            {
                Properties.Settings.Default.highscore = score;
                Properties.Settings.Default.Save();
            }

            tsHighscore.Text = Properties.Settings.Default.highscore.ToString();

            foreach (Control lbl in this.Controls)
            {
                if (lbl is Label)
                {
                    if (lbl.Text == "0")
                    {
                        lbl.Text = "";
                        lbl.BackColor = Color.Silver;
                    }
                }
            }
        }

        private void appendRandomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppendRandomNumber();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            tsHighscore.Text = Properties.Settings.Default.highscore.ToString();
            AppendRandomNumber();
        }

        private void tableLayoutPanel1_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Hide();
        }

        private void tableLayoutPanel1_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Show();
        }

        private void MouseEnter_Event(object sender, EventArgs e)
        {
            Cursor.Hide();
        }

        private void num1x1y_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Show();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to reset the field?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        fields[i, j] = new pointData();
                    }
                }
            }
            else
            {
                return;
            }

            score = 0;
            AppendRandomNumber();
            RedrawField();
        }
    }

    public class pointData
    {
        public int value { get; set; }
        public Color color
        {
            get
            {
                switch (value)
                {
                    case 2:
                        return Color.FromArgb(22, 37, 117);
                    case 4:
                        return Color.FromArgb(50, 66, 191);
                    case 8:
                        return Color.FromArgb(31, 54, 224);
                    case 16:
                        return Color.FromArgb(19, 151, 158);
                    case 32:
                        return Color.FromArgb(20, 195, 204);
                    case 64:
                        return Color.FromArgb(0, 237, 250);
                    case 128:
                        return Color.FromArgb(168, 166, 39);
                    case 256:
                        return Color.FromArgb(199, 196, 32);
                    case 512:
                        return Color.FromArgb(255, 251, 10);
                    default:
                        return Color.Silver;
                }
            }
        }

        public pointData()
        {
            this.value = 0;
        }
    }
}
