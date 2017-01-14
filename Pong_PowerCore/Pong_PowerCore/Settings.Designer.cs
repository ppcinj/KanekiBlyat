namespace Pong_PowerCore
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAiDiff = new System.Windows.Forms.TextBox();
            this.tbUsrSpeed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCircleWidth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCircleHeight = new System.Windows.Forms.TextBox();
            this.tbUserHeight = new System.Windows.Forms.TextBox();
            this.tbUserWidth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbDrunkBall = new System.Windows.Forms.CheckBox();
            this.tbColorR = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbColorG = new System.Windows.Forms.TextBox();
            this.tbColorB = new System.Windows.Forms.TextBox();
            this.cbRainbowMode = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Nasalization", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(0, 516);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(800, 84);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Nasalization", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "AI Difficluty:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbAiDiff
            // 
            this.tbAiDiff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAiDiff.BackColor = System.Drawing.Color.Black;
            this.tbAiDiff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAiDiff.Font = new System.Drawing.Font("Nasalization", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAiDiff.ForeColor = System.Drawing.Color.White;
            this.tbAiDiff.Location = new System.Drawing.Point(374, 9);
            this.tbAiDiff.Name = "tbAiDiff";
            this.tbAiDiff.Size = new System.Drawing.Size(414, 34);
            this.tbAiDiff.TabIndex = 2;
            this.tbAiDiff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbUsrSpeed
            // 
            this.tbUsrSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUsrSpeed.BackColor = System.Drawing.Color.Black;
            this.tbUsrSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUsrSpeed.Font = new System.Drawing.Font("Nasalization", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsrSpeed.ForeColor = System.Drawing.Color.White;
            this.tbUsrSpeed.Location = new System.Drawing.Point(374, 75);
            this.tbUsrSpeed.Name = "tbUsrSpeed";
            this.tbUsrSpeed.Size = new System.Drawing.Size(414, 34);
            this.tbUsrSpeed.TabIndex = 4;
            this.tbUsrSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Nasalization", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "User Speed:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbCircleWidth
            // 
            this.tbCircleWidth.BackColor = System.Drawing.Color.Black;
            this.tbCircleWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCircleWidth.Font = new System.Drawing.Font("Nasalization", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCircleWidth.ForeColor = System.Drawing.Color.White;
            this.tbCircleWidth.Location = new System.Drawing.Point(374, 147);
            this.tbCircleWidth.Name = "tbCircleWidth";
            this.tbCircleWidth.Size = new System.Drawing.Size(180, 34);
            this.tbCircleWidth.TabIndex = 6;
            this.tbCircleWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Nasalization", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(356, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Circle Width/Height:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbCircleHeight
            // 
            this.tbCircleHeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCircleHeight.BackColor = System.Drawing.Color.Black;
            this.tbCircleHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCircleHeight.Font = new System.Drawing.Font("Nasalization", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCircleHeight.ForeColor = System.Drawing.Color.White;
            this.tbCircleHeight.Location = new System.Drawing.Point(608, 147);
            this.tbCircleHeight.Name = "tbCircleHeight";
            this.tbCircleHeight.Size = new System.Drawing.Size(180, 34);
            this.tbCircleHeight.TabIndex = 7;
            this.tbCircleHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbUserHeight
            // 
            this.tbUserHeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUserHeight.BackColor = System.Drawing.Color.Black;
            this.tbUserHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUserHeight.Font = new System.Drawing.Font("Nasalization", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserHeight.ForeColor = System.Drawing.Color.White;
            this.tbUserHeight.Location = new System.Drawing.Point(608, 210);
            this.tbUserHeight.Name = "tbUserHeight";
            this.tbUserHeight.Size = new System.Drawing.Size(180, 34);
            this.tbUserHeight.TabIndex = 10;
            this.tbUserHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbUserWidth
            // 
            this.tbUserWidth.BackColor = System.Drawing.Color.Black;
            this.tbUserWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUserWidth.Font = new System.Drawing.Font("Nasalization", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserWidth.ForeColor = System.Drawing.Color.White;
            this.tbUserWidth.Location = new System.Drawing.Point(374, 210);
            this.tbUserWidth.Name = "tbUserWidth";
            this.tbUserWidth.Size = new System.Drawing.Size(180, 34);
            this.tbUserWidth.TabIndex = 9;
            this.tbUserWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Nasalization", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(356, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "User Width/Height:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbDrunkBall
            // 
            this.cbDrunkBall.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbDrunkBall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cbDrunkBall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDrunkBall.Font = new System.Drawing.Font("Nasalization", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDrunkBall.Location = new System.Drawing.Point(12, 289);
            this.cbDrunkBall.Name = "cbDrunkBall";
            this.cbDrunkBall.Size = new System.Drawing.Size(776, 43);
            this.cbDrunkBall.TabIndex = 11;
            this.cbDrunkBall.Text = "Drunk Ball";
            this.cbDrunkBall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbDrunkBall.UseVisualStyleBackColor = true;
            // 
            // tbColorR
            // 
            this.tbColorR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbColorR.BackColor = System.Drawing.Color.Black;
            this.tbColorR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbColorR.Font = new System.Drawing.Font("Nasalization", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbColorR.ForeColor = System.Drawing.Color.White;
            this.tbColorR.Location = new System.Drawing.Point(374, 376);
            this.tbColorR.Name = "tbColorR";
            this.tbColorR.Size = new System.Drawing.Size(130, 34);
            this.tbColorR.TabIndex = 13;
            this.tbColorR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Nasalization", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(356, 31);
            this.label5.TabIndex = 12;
            this.label5.Text = "Game Color (RGB):";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbColorG
            // 
            this.tbColorG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbColorG.BackColor = System.Drawing.Color.Black;
            this.tbColorG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbColorG.Font = new System.Drawing.Font("Nasalization", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbColorG.ForeColor = System.Drawing.Color.White;
            this.tbColorG.Location = new System.Drawing.Point(517, 376);
            this.tbColorG.Name = "tbColorG";
            this.tbColorG.Size = new System.Drawing.Size(130, 34);
            this.tbColorG.TabIndex = 14;
            this.tbColorG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbColorB
            // 
            this.tbColorB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbColorB.BackColor = System.Drawing.Color.Black;
            this.tbColorB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbColorB.Font = new System.Drawing.Font("Nasalization", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbColorB.ForeColor = System.Drawing.Color.White;
            this.tbColorB.Location = new System.Drawing.Point(658, 376);
            this.tbColorB.Name = "tbColorB";
            this.tbColorB.Size = new System.Drawing.Size(130, 34);
            this.tbColorB.TabIndex = 15;
            this.tbColorB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbRainbowMode
            // 
            this.cbRainbowMode.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbRainbowMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cbRainbowMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRainbowMode.Font = new System.Drawing.Font("Nasalization", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRainbowMode.Location = new System.Drawing.Point(12, 440);
            this.cbRainbowMode.Name = "cbRainbowMode";
            this.cbRainbowMode.Size = new System.Drawing.Size(776, 43);
            this.cbRainbowMode.TabIndex = 16;
            this.cbRainbowMode.Text = "Rainbow Mode";
            this.cbRainbowMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbRainbowMode.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.cbRainbowMode);
            this.Controls.Add(this.tbColorB);
            this.Controls.Add(this.tbColorG);
            this.Controls.Add(this.tbColorR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbDrunkBall);
            this.Controls.Add(this.tbUserHeight);
            this.Controls.Add(this.tbUserWidth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCircleHeight);
            this.Controls.Add(this.tbCircleWidth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbUsrSpeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAiDiff);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings - Pong";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAiDiff;
        private System.Windows.Forms.TextBox tbUsrSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCircleWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCircleHeight;
        private System.Windows.Forms.TextBox tbUserHeight;
        private System.Windows.Forms.TextBox tbUserWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbDrunkBall;
        private System.Windows.Forms.TextBox tbColorR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbColorG;
        private System.Windows.Forms.TextBox tbColorB;
        private System.Windows.Forms.CheckBox cbRainbowMode;
    }
}