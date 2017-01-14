using System;
using System.Windows.Forms;

namespace Pong_PowerCore
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.AllowedAiDifference = Convert.ToInt32(tbAiDiff.Text);
                Properties.Settings.Default.AllowedPPCSpeed = Convert.ToInt32(tbUsrSpeed.Text);
                Properties.Settings.Default.CircleHeight = Convert.ToInt32(tbCircleHeight.Text);
                Properties.Settings.Default.CircleWidth = Convert.ToInt32(tbCircleWidth.Text);
                Properties.Settings.Default.UserHeight = Convert.ToInt32(tbUserHeight.Text);
                Properties.Settings.Default.UserWidth = Convert.ToInt32(tbUserWidth.Text);
                Properties.Settings.Default.DrunkBall = cbDrunkBall.Checked;
                Properties.Settings.Default.RainbowMode = cbRainbowMode.Checked;
                Properties.Settings.Default.colorR = Convert.ToByte(tbColorR.Text);
                Properties.Settings.Default.colorG = Convert.ToByte(tbColorG.Text);
                Properties.Settings.Default.colorB = Convert.ToByte(tbColorB.Text);
                Properties.Settings.Default.Save();
            }
            catch (Exception)
            {
                MessageBox.Show("An Error has Occured. However, you can go on playing, but the Settings haven't been saved.",
                    "Pong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            tbAiDiff.Text = Properties.Settings.Default.AllowedAiDifference.ToString();
            tbCircleHeight.Text = Properties.Settings.Default.CircleHeight.ToString();
            tbCircleWidth.Text = Properties.Settings.Default.CircleWidth.ToString();
            tbUserHeight.Text = Properties.Settings.Default.UserHeight.ToString();
            tbUserWidth.Text = Properties.Settings.Default.UserWidth.ToString();
            tbUsrSpeed.Text = Properties.Settings.Default.AllowedPPCSpeed.ToString();
            tbColorR.Text = Properties.Settings.Default.colorR.ToString();
            tbColorG.Text = Properties.Settings.Default.colorG.ToString();
            tbColorB.Text = Properties.Settings.Default.colorB.ToString();
            cbDrunkBall.Checked = Properties.Settings.Default.DrunkBall;
            cbRainbowMode.Checked = Properties.Settings.Default.RainbowMode;
        }
    }
}
