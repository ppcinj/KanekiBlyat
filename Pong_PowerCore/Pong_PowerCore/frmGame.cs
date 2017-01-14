using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pong_PowerCore
{
    public partial class frmGame : Form
    {
        /// <summary>
        /// 1 = right, 0 = left
        /// </summary>
        byte direction = 1;
        /// <summary>
        /// saves speeds for x and y movement
        /// </summary>
        int[] speed = new int[2];
        /// <summary>
        /// the two spped increasers
        /// </summary>
        int addSpeedRight = 0;
        int addSpeedLeft = 0;
        /// <summary>
        /// scores
        /// </summary>
        int score1 = 0;
        int score2 = 0;
        /// <summary>
        /// current position of the gdi circle
        /// </summary>
        int gdicirclex;
        int gdicircley;
        int gdicirclewidth;
        int gdicircleheight;
        /// <summary>
        /// current position of user 1
        /// </summary>
        int gdiuser1x;
        int gdiuser1y;
        int gdiuser1width;
        int gdiuser1height;
        /// <summary>
        /// current position of user 2
        /// </summary>
        int gdiuser2x;
        int gdiuser2y;
        int gdiuser2width;
        int gdiuser2height;
        /// <summary>
        /// After 30 Times the Speeds should change
        /// </summary>
        int DrunkBallCounter = 0;
        /// <summary>
        /// used to calculate the FPS
        /// </summary>
        long frames;
        /// <summary>
        /// entry point of game
        /// </summary>
        public frmGame()
        {
            Random rand = new Random();
            InitializeComponent();
            direction = 1;
            ResetCircle();
            ResetBars();
            GetNewSpeeds(direction);
            if (Globals.mode == 2)
                tmUser2.Interval = Properties.Settings.Default.AIdifficulty;
            if (Globals.mode == 1)
            {
                tmUser1.Interval = Properties.Settings.Default.AIdifficulty;
                tmUser2.Interval = Properties.Settings.Default.AIdifficulty;
            }
            gdicircleheight = Properties.Settings.Default.CircleHeight;
            gdicirclewidth = Properties.Settings.Default.CircleWidth;
        }

        /// <summary>
        /// Listens to User 1 input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmUser1_Tick(object sender, EventArgs e)
        {
            // Checks if test mode activated
            if (!(Globals.mode == 1))
            {
                // Checks for S_key
                if (PInvoke.GetAsyncKeyState(Keys.S) == short.MinValue || PInvoke.GetAsyncKeyState(Keys.S) == 1)
                {
                    // OBSOLETE:    Point currloc = new System.Drawing.Point(User1.Location.X, User1.Location.Y);
                    //              User1.Location = new System.Drawing.Point(currloc.X, currloc.Y + Properties.Settings.Default.AllowedPPCSpeed);
                    gdiuser1y += Properties.Settings.Default.AllowedPPCSpeed;
                    if (gdiuser1y > (this.Size.Height - gdiuser1height))
                    {
                        // OBSOLETE:    User1.Location = new System.Drawing.Point(User1.Location.X, this.Size.Height - User1.Size.Height);
                        gdiuser1y = this.Size.Height - gdiuser1height;
                    }
                }
                // Checks for W_key
                if (PInvoke.GetAsyncKeyState(Keys.W) == short.MinValue || PInvoke.GetAsyncKeyState(Keys.W) == 1)
                {
                    // OBSOLETE:    Point currloc = new System.Drawing.Point(User1.Location.X, User1.Location.Y);
                    //              User1.Location = new System.Drawing.Point(currloc.X, currloc.Y - Properties.Settings.Default.AllowedPPCSpeed);
                    gdiuser1y -= Properties.Settings.Default.AllowedPPCSpeed;
                    if (gdiuser1y < 0)
                    {
                        // OBSOLETE:    User1.Location = new System.Drawing.Point(User1.Location.X, 0);
                        gdiuser1y = 0;
                    }
                }
                tmUser1.Stop();
                tmUser1.Start();
                // TODO: Esc
                if (PInvoke.GetAsyncKeyState(Keys.Escape) == short.MinValue || PInvoke.GetAsyncKeyState(Keys.Escape) == 1)
                {

                }
            }
            else if (Globals.mode == 1)
            {
                // Bot Test mode
                int difference = gdicircley - gdiuser1height / 2 - gdiuser1y;
                if (difference < 0)
                    difference = -1 * Properties.Settings.Default.AllowedAiDifference;
                if (difference > 0)
                    difference = Properties.Settings.Default.AllowedAiDifference;
                if (!((gdiuser1y + gdiuser1height) > this.Size.Height) & difference > 0 || !((gdiuser1y) < 0) & difference < 0)
                    // OBSOLETE:    User1.Location = new Point(0, User1.Location.Y + difference);
                    gdiuser1y += difference;
                // OBSOLETE/MERGED:     if (!((gdiuser1y) < 0) & difference < 0)
                //                      User1.Location = new Point(0, User1.Location.Y + difference);
                //                      gdiuser1y += difference;
            }
        }

        /// <summary>
        /// Listens to user 2 input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmUser2_Tick(object sender, EventArgs e)
        {
            // Checks if Test or AI mode enabled
            if (!(Globals.mode == 1) & !(Globals.mode == 2))
            {
                // Checks if down key pressed
                if (PInvoke.GetAsyncKeyState(Keys.Down) == short.MinValue || PInvoke.GetAsyncKeyState(Keys.Down) == 1)
                {
                    // OBSOLETE:    Point currloc = new System.Drawing.Point(User2.Location.X, User2.Location.Y);
                    //              User2.Location = new System.Drawing.Point(currloc.X, currloc.Y + Properties.Settings.Default.AllowedPPCSpeed);
                    gdiuser2y += Properties.Settings.Default.AllowedPPCSpeed;
                    if (gdiuser2y > (this.Size.Height - gdiuser2height))
                    {
                        // OBSOLETE:    User2.Location = new System.Drawing.Point(User2.Location.X, this.Size.Height - User2.Size.Height);
                        gdiuser2y = this.Size.Height - gdiuser2height;
                    }
                }
                // Checks if up key pressed
                if (PInvoke.GetAsyncKeyState(Keys.Up) == short.MinValue || PInvoke.GetAsyncKeyState(Keys.Up) == 1)
                {
                    // OBSOLETE:    Point currloc = new System.Drawing.Point(User2.Location.X, User2.Location.Y);
                    //              User2.Location = new System.Drawing.Point(currloc.X, currloc.Y - Properties.Settings.Default.AllowedPPCSpeed);
                    gdiuser2y -= Properties.Settings.Default.AllowedPPCSpeed;
                    if (gdiuser2y < 0)
                    {
                        // OBSOLETE:    User2.Location = new System.Drawing.Point(User2.Location.X, 0);
                        gdiuser2y = 0;
                    }
                }
                tmUser2.Stop();
                tmUser2.Start();
            }
            else if (Globals.mode == 1)
            {
                // Bot Test Mode
                int difference = gdicircley - gdiuser2height / 2 - gdiuser2y;
                if (difference < 0)
                    difference = -1 * Properties.Settings.Default.AllowedAiDifference;
                if (difference > 0)
                    difference = Properties.Settings.Default.AllowedAiDifference;
                if (!((gdiuser2y + gdiuser2height) > this.Size.Height) & difference > 0 || !((gdiuser2y) < 0) & difference < 0)
                    // OBSOLETE:    User2.Location = new Point(this.Size.Width - User2.Size.Width, User2.Location.Y + difference);
                    gdiuser2y += difference;
                // OBSOLETE/MERGED:     if (!((gdiuser2y) < 0) & difference < 0)
                //                      User2.Location = new Point(this.Size.Width - User2.Size.Width, User2.Location.Y + difference);
                //                      gdiuser2y += difference;
            }
            else if (Globals.mode == 2)
            {
                // AI Mode (Bot has average difficulty)
                int difference = gdicircley - gdiuser2height / 2 - gdiuser2y;
                if (difference < 0)
                    difference = -1 * Properties.Settings.Default.AllowedAiDifference;
                if (difference > 0)
                    difference = Properties.Settings.Default.AllowedAiDifference;
                if (!((gdiuser2y + gdiuser2height) > this.Size.Height) & difference > 0 || !((gdiuser2y) < 0) & difference < 0)
                    // OBSOLETE:    User2.Location = new Point(this.Size.Width - User2.Size.Width, User2.Location.Y + difference);
                    gdiuser2y += difference;
                // OBSOLETE/MERGED:     if (!((gdiuser2y) < 0) & difference < 0)
                //                      User2.Location = new Point(this.Size.Width - User2.Size.Width, User2.Location.Y + difference);
                //                      gdiuser2y += difference;
            }
        }

        // Resets the Ball to the middle
        internal void ResetCircle()
        {
            // OBSOLETE:    pbCircle.Location = new Point(this.Size.Width / 2 - 25, this.Size.Height / 2 - 25);
            gdicirclex = this.Size.Width / 2 - gdicirclewidth / 2;
            gdicircley = this.Size.Height / 2 - gdicircleheight / 2;
        }

        // Resets bars to the middle
        internal void ResetBars()
        {
            // OBSOLETE:    User1.Location = new Point(0, this.Size.Height / 2 - User1.Size.Height / 2);
            //              User2.Location = new Point(this.Size.Width - User2.Size.Width, this.Size.Height / 2 - User1.Size.Height / 2);
            gdiuser1y = this.Size.Height / 2 - gdiuser1height / 2;
            gdiuser2y = this.Size.Height / 2 - gdiuser2height / 2;
        }

        // Start Button is clicked
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            btnStartGame.Hide();
            tmUser1.Start();
            tmUser2.Start();
            tmBall.Start();
        }

        // Ball must be updated
        private void tmBall_Tick(object sender, EventArgs e)
        {
                // checks if it goes to the right
                if (direction == 1)
                {
                    // OBSOLETE:    pbCircle.Location = new Point(currloc.X + speed[0] + addSpeedRight, currloc.Y + speed[1]);
                    gdicirclex = gdicirclex + speed[0] + addSpeedRight;
                    gdicircley = gdicircley + speed[1];
                }
                else
                {
                    // ball goes to left
                    // OBSOLETE:    pbCircle.Location = new Point(currloc.X + speed[0] - addSpeedLeft, currloc.Y + speed[1]);
                    gdicirclex = gdicirclex + speed[0] - addSpeedLeft;
                    gdicircley = gdicircley + speed[1];
                }
            if (direction == 1)
            {
                // right direction
                // checks if lower bound is reached
                // OBSOLETE:        if (pbCircle.Location.Y + pbCircle.Size.Height + speed[1] > this.Size.Height)
                //                      speed[1] = speed[1] - (speed[1] * 2);
                if (gdicircley + gdicircleheight + speed[1] > this.Size.Height)
                    speed[1] = speed[1] - speed[1] * 2;
                // checks if upper bound reached
                // OBSOLETE:        if (pbCircle.Location.Y + speed[1] < 0)
                //                      speed[1] = speed[1] + (-1 * (speed[1] * 2));
                if (gdicircley + speed[1] < 0)
                    speed[1] = speed[1] + (-1 * (speed[1] * 2));
            }
            else
            {
                // left direction
                // checks if lower bound is reached
                // OBSOLETE:        if (pbCircle.Location.Y + pbCircle.Size.Height + speed[1] > this.Size.Height)
                //                      speed[1] = speed[1] - (speed[1] * 2);
                if (gdicircley + gdicircleheight + speed[1] > this.Size.Height)
                    speed[1] = speed[1] - speed[1] * 2;
                // checks if upper bound reached
                // OBSOLETE: if (pbCircle.Location.Y + speed[1] < 0)
                //    speed[1] = speed[1] + (-1 * (speed[1] * 2));
                if (gdicircley + speed[1] < 0)
                    speed[1] = speed[1] + (-1 * (speed[1] * 2));
            }
            // checks if user 2 has made a point
            if (gdicirclex < gdiuser1width)
            {
                // checks if bar disabled point and returns ball
                if (gdicircley + gdicirclewidth / 2 >= gdiuser1y & gdicircley + gdicirclewidth / 2 <= gdiuser1y + gdiuser1height)
                {
                    addSpeedRight++;
                    direction = 1;
                    // NOT WORKING:     if (speed[1] > 0)
                    //                      speed[1] -= speed[1] * 2;
                    //                  else
                    //                      speed[1] += -1 * speed[1] * 2;
                    if (PInvoke.GetAsyncKeyState(Keys.S) == short.MinValue || PInvoke.GetAsyncKeyState(Keys.S) == 1)
                    {
                        speed[1] += 3;
                    }
                    if (PInvoke.GetAsyncKeyState(Keys.W) == short.MinValue || PInvoke.GetAsyncKeyState(Keys.W) == 1)
                    {
                        speed[1] -= 3;
                    }
                    if (speed[1] > 10)
                        speed[1] = 10;
                    if (speed[1] < -10)
                        speed[1] = -10;
                    speed[0] = speed[0] * -1;
                }
                else
                {
                    // user 2 pointed
                    score2++;
                    lblScore2.Text = score2.ToString();
                    stopGame();
                }
            }
            // checks if user 1 has made a point
            if (gdicirclex + gdicirclewidth > this.Size.Width - gdiuser2width)
            {
                // checks if bar disabled point and returns ball
                if (gdicircley + gdicircleheight / 2 >= gdiuser2y & gdicircley + gdicircleheight / 2 <= gdiuser2y + gdiuser2height)
                {
                    addSpeedLeft++;
                    direction = 0;
                    // NOT WORKING:     if (speed[1] > 0)
                    //                      speed[1] -= speed[1] * 2;
                    //                  else
                    //                      speed[1] += -1 * speed[1] * 2;
                    if (PInvoke.GetAsyncKeyState(Keys.Down) == short.MinValue || PInvoke.GetAsyncKeyState(Keys.Down) == 1)
                    {
                        speed[1] += 3;
                    }
                    if (PInvoke.GetAsyncKeyState(Keys.Up) == short.MinValue || PInvoke.GetAsyncKeyState(Keys.Up) == 1)
                    {
                        speed[1] -= 3;
                    }
                    if (speed[1] > 10)
                        speed[1] = 10;
                    if (speed[1] < -10)
                        speed[1] = -10;
                    speed[0] = speed[0] * -1;
                }
                else
                {
                    // user 1 pointed
                    score1++;
                    lblScore1.Text = score1.ToString();
                    stopGame();
                }
            }
            // Drunk Ball produces unpredictable Paths
            if (Properties.Settings.Default.DrunkBall)
            {
                if (DrunkBallCounter == 30)
                {
                    GetNewSpeeds(direction);
                    DrunkBallCounter = 0;
                }
                else
                    DrunkBallCounter++;
            }
        }

        /// <summary>
        /// Gets new angles and speeds for the ball
        /// </summary>
        /// <param name="dir">direction</param>
        internal void GetNewSpeeds(byte dir)
        {
            Random rand = new Random();
            switch (dir)
            {
                case 0:
                    speed[0] = rand.Next(-10, -8);
                    speed[1] = rand.Next(-8, 8);
                    if (speed[1] == 0)
                        speed[1] = rand.Next(4, 8);
                    if (speed[1] < 0 & speed[1] > -4)
                        speed[1] = rand.Next(-8, -4);
                    if (speed[1] > 0 & speed[1] < 4)
                        speed[1] = rand.Next(4, 8);
                    break;
                case 1:
                    speed[0] = rand.Next(8, 10);
                    speed[1] = rand.Next(-8, 8);
                    if (speed[1] == 0)
                        speed[1] = rand.Next(4, 8);
                    if (speed[1] < 0 & speed[1] > -4)
                        speed[1] = rand.Next(-8, -4);
                    if (speed[1] > 0 & speed[1] < 4)
                        speed[1] = rand.Next(4, 8);
                    break;
            }
        }

        // stops the game and returns to enden game screen.
        internal void stopGame()
        {
            ResetCircle();
            tmBall.Stop();
            btnStartGame.Show();
            tmUser1.Stop();
            tmUser2.Stop();
            ResetBars();
            addSpeedRight = 0;
            addSpeedLeft = 0;
            GetNewSpeeds(direction);
            // Free RAM
            GC.Collect();
        }

        private void frmGame_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Color col;
            if (Properties.Settings.Default.RainbowMode)
            {
                Random rand = new Random();
                byte red, green, blue;
                red = (byte)rand.Next(0, 255);
                green = (byte)rand.Next(0, 255);
                blue = (byte)rand.Next(0, 255);
                col = Color.FromArgb(red, green, blue);
            }
            else
            {
                col = Color.FromArgb(Properties.Settings.Default.colorR, Properties.Settings.Default.colorG, Properties.Settings.Default.colorB);
            }
            SolidBrush pen = new SolidBrush(col);
            g.FillEllipse(pen, gdicirclex, gdicircley, gdicirclewidth, gdicircleheight);
            g.FillRectangle(pen, gdiuser1x, gdiuser1y, gdiuser1width, gdiuser1height);
            g.FillRectangle(pen, gdiuser2x, gdiuser2y, gdiuser2width, gdiuser2height);
            PInvoke.LockWindowUpdate(IntPtr.Zero);
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            gdicircley = this.Size.Height / 2 - gdicircleheight / 2;
            gdicirclex = this.Size.Width / 2 - gdicirclewidth / 2;
            // OBSOLETE:    User1.Size = new Size(Properties.Settings.Default.UserWidth, Properties.Settings.Default.UserHeight);
            //              User2.Size = new Size(Properties.Settings.Default.UserWidth, Properties.Settings.Default.UserHeight);
            gdiuser1width = Properties.Settings.Default.UserWidth;
            gdiuser1height = Properties.Settings.Default.UserHeight;
            gdiuser2width = Properties.Settings.Default.UserWidth;
            gdiuser2height = Properties.Settings.Default.UserHeight;
            gdiuser1x = 0;
            gdiuser2x = this.Size.Width - gdiuser2width;
            ResetBars();
        }

        private void tmUpdate_Tick(object sender, EventArgs e)
        {
            Invalidate();
            // Not known if needed:
            // Update();
            frames++;
            PInvoke.LockWindowUpdate(this.Handle);
        }

        private void tmFPS_Tick(object sender, EventArgs e)
        {
            label1.Text = (frames * 2).ToString() + " Frames/s";
            frames = 0;
        }

        private void frmGame_Resize(object sender, EventArgs e)
        {
            // Size of Form might have changed.
            gdiuser2x = this.Size.Width - gdiuser2width;
        }
    }
}
