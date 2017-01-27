namespace WindowsFormsApplication1
{
    partial class FormEdit
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
            this.txName2 = new System.Windows.Forms.TextBox();
            this.txFanil2 = new System.Windows.Forms.TextBox();
            this.txMoney2 = new System.Windows.Forms.TextBox();
            this.txDays2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txName2
            // 
            this.txName2.Location = new System.Drawing.Point(120, 51);
            this.txName2.Name = "txName2";
            this.txName2.Size = new System.Drawing.Size(100, 20);
            this.txName2.TabIndex = 0;
            // 
            // txFanil2
            // 
            this.txFanil2.Location = new System.Drawing.Point(120, 95);
            this.txFanil2.Name = "txFanil2";
            this.txFanil2.Size = new System.Drawing.Size(100, 20);
            this.txFanil2.TabIndex = 1;
            // 
            // txMoney2
            // 
            this.txMoney2.Location = new System.Drawing.Point(120, 146);
            this.txMoney2.Name = "txMoney2";
            this.txMoney2.Size = new System.Drawing.Size(100, 20);
            this.txMoney2.TabIndex = 2;
            // 
            // txDays2
            // 
            this.txDays2.Location = new System.Drawing.Point(120, 191);
            this.txDays2.Name = "txDays2";
            this.txDays2.Size = new System.Drawing.Size(100, 20);
            this.txDays2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 296);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txDays2);
            this.Controls.Add(this.txMoney2);
            this.Controls.Add(this.txFanil2);
            this.Controls.Add(this.txName2);
            this.Name = "FormEdit";
            this.Text = "FormEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txName2;
        private System.Windows.Forms.TextBox txFanil2;
        private System.Windows.Forms.TextBox txMoney2;
        private System.Windows.Forms.TextBox txDays2;
        private System.Windows.Forms.Button button1;
    }
}