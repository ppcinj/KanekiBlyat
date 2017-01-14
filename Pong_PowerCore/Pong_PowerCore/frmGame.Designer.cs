namespace Pong_PowerCore
{
    partial class frmGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            this.tmUser1 = new System.Windows.Forms.Timer(this.components);
            this.tmUser2 = new System.Windows.Forms.Timer(this.components);
            this.tmBall = new System.Windows.Forms.Timer(this.components);
            this.btnStartGame = new System.Windows.Forms.Button();
            this.lblScore1 = new System.Windows.Forms.Label();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.tmUpdate = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tmFPS = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tmUser1
            // 
            this.tmUser1.Interval = 5;
            this.tmUser1.Tick += new System.EventHandler(this.tmUser1_Tick);
            // 
            // tmUser2
            // 
            this.tmUser2.Interval = 5;
            this.tmUser2.Tick += new System.EventHandler(this.tmUser2_Tick);
            // 
            // tmBall
            // 
            this.tmBall.Interval = 5;
            this.tmBall.Tick += new System.EventHandler(this.tmBall_Tick);
            // 
            // btnStartGame
            // 
            this.btnStartGame.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartGame.Font = new System.Drawing.Font("Nasalization", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.ForeColor = System.Drawing.Color.White;
            this.btnStartGame.Location = new System.Drawing.Point(0, 568);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(1024, 200);
            this.btnStartGame.TabIndex = 3;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // lblScore1
            // 
            this.lblScore1.AutoSize = true;
            this.lblScore1.BackColor = System.Drawing.Color.Transparent;
            this.lblScore1.Font = new System.Drawing.Font("Nasalization", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore1.ForeColor = System.Drawing.Color.White;
            this.lblScore1.Location = new System.Drawing.Point(40, 9);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(54, 42);
            this.lblScore1.TabIndex = 4;
            this.lblScore1.Text = "0";
            // 
            // lblScore2
            // 
            this.lblScore2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScore2.AutoSize = true;
            this.lblScore2.BackColor = System.Drawing.Color.Transparent;
            this.lblScore2.Font = new System.Drawing.Font("Nasalization", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore2.ForeColor = System.Drawing.Color.White;
            this.lblScore2.Location = new System.Drawing.Point(918, 9);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(54, 42);
            this.lblScore2.TabIndex = 5;
            this.lblScore2.Text = "0";
            // 
            // tmUpdate
            // 
            this.tmUpdate.Enabled = true;
            this.tmUpdate.Interval = 1;
            this.tmUpdate.Tick += new System.EventHandler(this.tmUpdate_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Nasalization", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(412, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "0 Frames/s";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmFPS
            // 
            this.tmFPS.Enabled = true;
            this.tmFPS.Interval = 500;
            this.tmFPS.Tick += new System.EventHandler(this.tmFPS_Tick);
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblScore2);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.lblScore1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmGame_Paint);
            this.Resize += new System.EventHandler(this.frmGame_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmUser1;
        private System.Windows.Forms.Timer tmUser2;
        private System.Windows.Forms.Timer tmBall;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Label lblScore1;
        private System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.Timer tmUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmFPS;
    }
}

