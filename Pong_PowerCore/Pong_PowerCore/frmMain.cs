using System;
using System.Windows.Forms;

namespace Pong_PowerCore
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAI_Click(object sender, EventArgs e)
        {
            Globals.mode = 2;
            frmGame game = new frmGame();
            game.ShowDialog();
        }

        private void btnPVP_Click(object sender, EventArgs e)
        {
            Globals.mode = 3;
            frmGame game = new frmGame();
            game.ShowDialog();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Globals.mode = 1;
            frmGame game = new frmGame();
            game.ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings sets = new Settings();
            sets.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
