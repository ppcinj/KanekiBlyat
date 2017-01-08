namespace _2048
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.scoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsScore = new System.Windows.Forms.ToolStripMenuItem();
            this.highscoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsHighscore = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiddenHotkeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dOWNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lEFTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rIGHTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appendRandomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.num4x4y = new System.Windows.Forms.Label();
            this.num3x4y = new System.Windows.Forms.Label();
            this.num2x4y = new System.Windows.Forms.Label();
            this.num1x4y = new System.Windows.Forms.Label();
            this.num4x3y = new System.Windows.Forms.Label();
            this.num3x3y = new System.Windows.Forms.Label();
            this.num2x3y = new System.Windows.Forms.Label();
            this.num1x3y = new System.Windows.Forms.Label();
            this.num4x2y = new System.Windows.Forms.Label();
            this.num3x2y = new System.Windows.Forms.Label();
            this.num2x2y = new System.Windows.Forms.Label();
            this.num1x2y = new System.Windows.Forms.Label();
            this.num4x1y = new System.Windows.Forms.Label();
            this.num3x1y = new System.Windows.Forms.Label();
            this.num2x1y = new System.Windows.Forms.Label();
            this.num1x1y = new System.Windows.Forms.Label();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scoreToolStripMenuItem,
            this.tsScore,
            this.highscoreToolStripMenuItem,
            this.tsHighscore,
            this.settingsToolStripMenuItem,
            this.hiddenHotkeysToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(488, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // scoreToolStripMenuItem
            // 
            this.scoreToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.scoreToolStripMenuItem.Name = "scoreToolStripMenuItem";
            this.scoreToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.scoreToolStripMenuItem.Text = "Score:";
            // 
            // tsScore
            // 
            this.tsScore.BackColor = System.Drawing.Color.Silver;
            this.tsScore.Name = "tsScore";
            this.tsScore.Size = new System.Drawing.Size(25, 20);
            this.tsScore.Text = "0";
            // 
            // highscoreToolStripMenuItem
            // 
            this.highscoreToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.highscoreToolStripMenuItem.Name = "highscoreToolStripMenuItem";
            this.highscoreToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.highscoreToolStripMenuItem.Text = "Highscore:";
            // 
            // tsHighscore
            // 
            this.tsHighscore.BackColor = System.Drawing.Color.Silver;
            this.tsHighscore.Name = "tsHighscore";
            this.tsHighscore.Size = new System.Drawing.Size(25, 20);
            this.tsHighscore.Text = "0";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // hiddenHotkeysToolStripMenuItem
            // 
            this.hiddenHotkeysToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.hiddenHotkeysToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uPToolStripMenuItem,
            this.dOWNToolStripMenuItem,
            this.lEFTToolStripMenuItem,
            this.rIGHTToolStripMenuItem,
            this.appendRandomToolStripMenuItem});
            this.hiddenHotkeysToolStripMenuItem.Name = "hiddenHotkeysToolStripMenuItem";
            this.hiddenHotkeysToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.hiddenHotkeysToolStripMenuItem.Text = "Hidden Hotkeys";
            this.hiddenHotkeysToolStripMenuItem.Visible = false;
            // 
            // uPToolStripMenuItem
            // 
            this.uPToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.uPToolStripMenuItem.Name = "uPToolStripMenuItem";
            this.uPToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.uPToolStripMenuItem.Text = "UP";
            // 
            // dOWNToolStripMenuItem
            // 
            this.dOWNToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.dOWNToolStripMenuItem.Name = "dOWNToolStripMenuItem";
            this.dOWNToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.dOWNToolStripMenuItem.Text = "DOWN";
            // 
            // lEFTToolStripMenuItem
            // 
            this.lEFTToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.lEFTToolStripMenuItem.Name = "lEFTToolStripMenuItem";
            this.lEFTToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.lEFTToolStripMenuItem.Text = "LEFT";
            // 
            // rIGHTToolStripMenuItem
            // 
            this.rIGHTToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.rIGHTToolStripMenuItem.Name = "rIGHTToolStripMenuItem";
            this.rIGHTToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.rIGHTToolStripMenuItem.Text = "RIGHT";
            // 
            // appendRandomToolStripMenuItem
            // 
            this.appendRandomToolStripMenuItem.Name = "appendRandomToolStripMenuItem";
            this.appendRandomToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.N)));
            this.appendRandomToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.appendRandomToolStripMenuItem.Text = "Append Random";
            this.appendRandomToolStripMenuItem.Click += new System.EventHandler(this.appendRandomToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Silver;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.num4x4y, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.num3x4y, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.num2x4y, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.num1x4y, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.num4x3y, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.num3x3y, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.num2x3y, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.num1x3y, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.num4x2y, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.num3x2y, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.num2x2y, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.num1x2y, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.num4x1y, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.num3x1y, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.num2x1y, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.num1x1y, 0, 0);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.No;
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(488, 452);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.MouseEnter += new System.EventHandler(this.tableLayoutPanel1_MouseEnter);
            this.tableLayoutPanel1.MouseLeave += new System.EventHandler(this.tableLayoutPanel1_MouseLeave);
            // 
            // num4x4y
            // 
            this.num4x4y.BackColor = System.Drawing.Color.Silver;
            this.num4x4y.Cursor = System.Windows.Forms.Cursors.No;
            this.num4x4y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num4x4y.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num4x4y.Location = new System.Drawing.Point(368, 341);
            this.num4x4y.Margin = new System.Windows.Forms.Padding(3);
            this.num4x4y.Name = "num4x4y";
            this.num4x4y.Size = new System.Drawing.Size(115, 106);
            this.num4x4y.TabIndex = 15;
            this.num4x4y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.num4x4y.MouseEnter += new System.EventHandler(this.MouseEnter_Event);
            this.num4x4y.MouseLeave += new System.EventHandler(this.num1x1y_MouseLeave);
            // 
            // num3x4y
            // 
            this.num3x4y.BackColor = System.Drawing.Color.Silver;
            this.num3x4y.Cursor = System.Windows.Forms.Cursors.No;
            this.num3x4y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num3x4y.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num3x4y.Location = new System.Drawing.Point(247, 341);
            this.num3x4y.Margin = new System.Windows.Forms.Padding(3);
            this.num3x4y.Name = "num3x4y";
            this.num3x4y.Size = new System.Drawing.Size(113, 106);
            this.num3x4y.TabIndex = 14;
            this.num3x4y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.num3x4y.MouseEnter += new System.EventHandler(this.MouseEnter_Event);
            this.num3x4y.MouseLeave += new System.EventHandler(this.num1x1y_MouseLeave);
            // 
            // num2x4y
            // 
            this.num2x4y.BackColor = System.Drawing.Color.Silver;
            this.num2x4y.Cursor = System.Windows.Forms.Cursors.No;
            this.num2x4y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num2x4y.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num2x4y.Location = new System.Drawing.Point(126, 341);
            this.num2x4y.Margin = new System.Windows.Forms.Padding(3);
            this.num2x4y.Name = "num2x4y";
            this.num2x4y.Size = new System.Drawing.Size(113, 106);
            this.num2x4y.TabIndex = 13;
            this.num2x4y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.num2x4y.MouseEnter += new System.EventHandler(this.MouseEnter_Event);
            this.num2x4y.MouseLeave += new System.EventHandler(this.num1x1y_MouseLeave);
            // 
            // num1x4y
            // 
            this.num1x4y.BackColor = System.Drawing.Color.Silver;
            this.num1x4y.Cursor = System.Windows.Forms.Cursors.No;
            this.num1x4y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num1x4y.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num1x4y.Location = new System.Drawing.Point(5, 341);
            this.num1x4y.Margin = new System.Windows.Forms.Padding(3);
            this.num1x4y.Name = "num1x4y";
            this.num1x4y.Size = new System.Drawing.Size(113, 106);
            this.num1x4y.TabIndex = 12;
            this.num1x4y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.num1x4y.MouseEnter += new System.EventHandler(this.MouseEnter_Event);
            this.num1x4y.MouseLeave += new System.EventHandler(this.num1x1y_MouseLeave);
            // 
            // num4x3y
            // 
            this.num4x3y.BackColor = System.Drawing.Color.Silver;
            this.num4x3y.Cursor = System.Windows.Forms.Cursors.No;
            this.num4x3y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num4x3y.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num4x3y.Location = new System.Drawing.Point(368, 229);
            this.num4x3y.Margin = new System.Windows.Forms.Padding(3);
            this.num4x3y.Name = "num4x3y";
            this.num4x3y.Size = new System.Drawing.Size(115, 104);
            this.num4x3y.TabIndex = 11;
            this.num4x3y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.num4x3y.MouseEnter += new System.EventHandler(this.MouseEnter_Event);
            this.num4x3y.MouseLeave += new System.EventHandler(this.num1x1y_MouseLeave);
            // 
            // num3x3y
            // 
            this.num3x3y.BackColor = System.Drawing.Color.Silver;
            this.num3x3y.Cursor = System.Windows.Forms.Cursors.No;
            this.num3x3y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num3x3y.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num3x3y.Location = new System.Drawing.Point(247, 229);
            this.num3x3y.Margin = new System.Windows.Forms.Padding(3);
            this.num3x3y.Name = "num3x3y";
            this.num3x3y.Size = new System.Drawing.Size(113, 104);
            this.num3x3y.TabIndex = 10;
            this.num3x3y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.num3x3y.MouseEnter += new System.EventHandler(this.MouseEnter_Event);
            this.num3x3y.MouseLeave += new System.EventHandler(this.num1x1y_MouseLeave);
            // 
            // num2x3y
            // 
            this.num2x3y.BackColor = System.Drawing.Color.Silver;
            this.num2x3y.Cursor = System.Windows.Forms.Cursors.No;
            this.num2x3y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num2x3y.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num2x3y.Location = new System.Drawing.Point(126, 229);
            this.num2x3y.Margin = new System.Windows.Forms.Padding(3);
            this.num2x3y.Name = "num2x3y";
            this.num2x3y.Size = new System.Drawing.Size(113, 104);
            this.num2x3y.TabIndex = 9;
            this.num2x3y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.num2x3y.MouseEnter += new System.EventHandler(this.MouseEnter_Event);
            this.num2x3y.MouseLeave += new System.EventHandler(this.num1x1y_MouseLeave);
            // 
            // num1x3y
            // 
            this.num1x3y.BackColor = System.Drawing.Color.Silver;
            this.num1x3y.Cursor = System.Windows.Forms.Cursors.No;
            this.num1x3y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num1x3y.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num1x3y.Location = new System.Drawing.Point(5, 229);
            this.num1x3y.Margin = new System.Windows.Forms.Padding(3);
            this.num1x3y.Name = "num1x3y";
            this.num1x3y.Size = new System.Drawing.Size(113, 104);
            this.num1x3y.TabIndex = 8;
            this.num1x3y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.num1x3y.MouseEnter += new System.EventHandler(this.MouseEnter_Event);
            this.num1x3y.MouseLeave += new System.EventHandler(this.num1x1y_MouseLeave);
            // 
            // num4x2y
            // 
            this.num4x2y.BackColor = System.Drawing.Color.Silver;
            this.num4x2y.Cursor = System.Windows.Forms.Cursors.No;
            this.num4x2y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num4x2y.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num4x2y.Location = new System.Drawing.Point(368, 117);
            this.num4x2y.Margin = new System.Windows.Forms.Padding(3);
            this.num4x2y.Name = "num4x2y";
            this.num4x2y.Size = new System.Drawing.Size(115, 104);
            this.num4x2y.TabIndex = 7;
            this.num4x2y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.num4x2y.MouseEnter += new System.EventHandler(this.MouseEnter_Event);
            this.num4x2y.MouseLeave += new System.EventHandler(this.num1x1y_MouseLeave);
            // 
            // num3x2y
            // 
            this.num3x2y.BackColor = System.Drawing.Color.Silver;
            this.num3x2y.Cursor = System.Windows.Forms.Cursors.No;
            this.num3x2y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num3x2y.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num3x2y.Location = new System.Drawing.Point(247, 117);
            this.num3x2y.Margin = new System.Windows.Forms.Padding(3);
            this.num3x2y.Name = "num3x2y";
            this.num3x2y.Size = new System.Drawing.Size(113, 104);
            this.num3x2y.TabIndex = 6;
            this.num3x2y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.num3x2y.MouseEnter += new System.EventHandler(this.MouseEnter_Event);
            this.num3x2y.MouseLeave += new System.EventHandler(this.num1x1y_MouseLeave);
            // 
            // num2x2y
            // 
            this.num2x2y.BackColor = System.Drawing.Color.Silver;
            this.num2x2y.Cursor = System.Windows.Forms.Cursors.No;
            this.num2x2y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num2x2y.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num2x2y.Location = new System.Drawing.Point(126, 117);
            this.num2x2y.Margin = new System.Windows.Forms.Padding(3);
            this.num2x2y.Name = "num2x2y";
            this.num2x2y.Size = new System.Drawing.Size(113, 104);
            this.num2x2y.TabIndex = 5;
            this.num2x2y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.num2x2y.MouseEnter += new System.EventHandler(this.MouseEnter_Event);
            this.num2x2y.MouseLeave += new System.EventHandler(this.num1x1y_MouseLeave);
            // 
            // num1x2y
            // 
            this.num1x2y.BackColor = System.Drawing.Color.Silver;
            this.num1x2y.Cursor = System.Windows.Forms.Cursors.No;
            this.num1x2y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num1x2y.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num1x2y.Location = new System.Drawing.Point(5, 117);
            this.num1x2y.Margin = new System.Windows.Forms.Padding(3);
            this.num1x2y.Name = "num1x2y";
            this.num1x2y.Size = new System.Drawing.Size(113, 104);
            this.num1x2y.TabIndex = 4;
            this.num1x2y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.num1x2y.MouseEnter += new System.EventHandler(this.MouseEnter_Event);
            this.num1x2y.MouseLeave += new System.EventHandler(this.num1x1y_MouseLeave);
            // 
            // num4x1y
            // 
            this.num4x1y.BackColor = System.Drawing.Color.Silver;
            this.num4x1y.Cursor = System.Windows.Forms.Cursors.No;
            this.num4x1y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num4x1y.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num4x1y.Location = new System.Drawing.Point(368, 5);
            this.num4x1y.Margin = new System.Windows.Forms.Padding(3);
            this.num4x1y.Name = "num4x1y";
            this.num4x1y.Size = new System.Drawing.Size(115, 104);
            this.num4x1y.TabIndex = 3;
            this.num4x1y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.num4x1y.MouseEnter += new System.EventHandler(this.MouseEnter_Event);
            this.num4x1y.MouseLeave += new System.EventHandler(this.num1x1y_MouseLeave);
            // 
            // num3x1y
            // 
            this.num3x1y.BackColor = System.Drawing.Color.Silver;
            this.num3x1y.Cursor = System.Windows.Forms.Cursors.No;
            this.num3x1y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num3x1y.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num3x1y.Location = new System.Drawing.Point(247, 5);
            this.num3x1y.Margin = new System.Windows.Forms.Padding(3);
            this.num3x1y.Name = "num3x1y";
            this.num3x1y.Size = new System.Drawing.Size(113, 104);
            this.num3x1y.TabIndex = 2;
            this.num3x1y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.num3x1y.MouseEnter += new System.EventHandler(this.MouseEnter_Event);
            this.num3x1y.MouseLeave += new System.EventHandler(this.num1x1y_MouseLeave);
            // 
            // num2x1y
            // 
            this.num2x1y.BackColor = System.Drawing.Color.Silver;
            this.num2x1y.Cursor = System.Windows.Forms.Cursors.No;
            this.num2x1y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num2x1y.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num2x1y.Location = new System.Drawing.Point(126, 5);
            this.num2x1y.Margin = new System.Windows.Forms.Padding(3);
            this.num2x1y.Name = "num2x1y";
            this.num2x1y.Size = new System.Drawing.Size(113, 104);
            this.num2x1y.TabIndex = 1;
            this.num2x1y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.num2x1y.MouseEnter += new System.EventHandler(this.MouseEnter_Event);
            this.num2x1y.MouseLeave += new System.EventHandler(this.num1x1y_MouseLeave);
            // 
            // num1x1y
            // 
            this.num1x1y.BackColor = System.Drawing.Color.Silver;
            this.num1x1y.Cursor = System.Windows.Forms.Cursors.No;
            this.num1x1y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num1x1y.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num1x1y.Location = new System.Drawing.Point(5, 5);
            this.num1x1y.Margin = new System.Windows.Forms.Padding(3);
            this.num1x1y.Name = "num1x1y";
            this.num1x1y.Size = new System.Drawing.Size(113, 104);
            this.num1x1y.TabIndex = 0;
            this.num1x1y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.num1x1y.MouseEnter += new System.EventHandler(this.MouseEnter_Event);
            this.num1x1y.MouseLeave += new System.EventHandler(this.num1x1y_MouseLeave);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 476);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2048";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem scoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsScore;
        private System.Windows.Forms.ToolStripMenuItem highscoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsHighscore;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem hiddenHotkeysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dOWNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lEFTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rIGHTToolStripMenuItem;
        private System.Windows.Forms.Label num4x4y;
        private System.Windows.Forms.Label num3x4y;
        private System.Windows.Forms.Label num2x4y;
        private System.Windows.Forms.Label num1x4y;
        private System.Windows.Forms.Label num4x3y;
        private System.Windows.Forms.Label num3x3y;
        private System.Windows.Forms.Label num2x3y;
        private System.Windows.Forms.Label num1x3y;
        private System.Windows.Forms.Label num4x2y;
        private System.Windows.Forms.Label num3x2y;
        private System.Windows.Forms.Label num2x2y;
        private System.Windows.Forms.Label num1x2y;
        private System.Windows.Forms.Label num4x1y;
        private System.Windows.Forms.Label num3x1y;
        private System.Windows.Forms.Label num2x1y;
        private System.Windows.Forms.Label num1x1y;
        private System.Windows.Forms.ToolStripMenuItem appendRandomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
    }
}

