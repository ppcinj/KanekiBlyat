namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txDay1 = new System.Windows.Forms.TextBox();
            this.lbDay1 = new System.Windows.Forms.Label();
            this.txMoney1 = new System.Windows.Forms.TextBox();
            this.lbMoney1 = new System.Windows.Forms.Label();
            this.txFam1 = new System.Windows.Forms.TextBox();
            this.lbFaml1 = new System.Windows.Forms.Label();
            this.txName1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbName1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txSearch = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txDay1);
            this.groupBox1.Controls.Add(this.lbDay1);
            this.groupBox1.Controls.Add(this.txMoney1);
            this.groupBox1.Controls.Add(this.lbMoney1);
            this.groupBox1.Controls.Add(this.txFam1);
            this.groupBox1.Controls.Add(this.lbFaml1);
            this.groupBox1.Controls.Add(this.txName1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lbName1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 460);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txDay1
            // 
            this.txDay1.Location = new System.Drawing.Point(145, 216);
            this.txDay1.Name = "txDay1";
            this.txDay1.Size = new System.Drawing.Size(111, 20);
            this.txDay1.TabIndex = 8;
            // 
            // lbDay1
            // 
            this.lbDay1.AutoSize = true;
            this.lbDay1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDay1.Location = new System.Drawing.Point(31, 218);
            this.lbDay1.Name = "lbDay1";
            this.lbDay1.Size = new System.Drawing.Size(104, 18);
            this.lbDay1.TabIndex = 7;
            this.lbDay1.Text = "Рабочих дней";
            // 
            // txMoney1
            // 
            this.txMoney1.Location = new System.Drawing.Point(145, 163);
            this.txMoney1.Name = "txMoney1";
            this.txMoney1.Size = new System.Drawing.Size(111, 20);
            this.txMoney1.TabIndex = 6;
            // 
            // lbMoney1
            // 
            this.lbMoney1.AutoSize = true;
            this.lbMoney1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMoney1.Location = new System.Drawing.Point(31, 165);
            this.lbMoney1.Name = "lbMoney1";
            this.lbMoney1.Size = new System.Drawing.Size(74, 18);
            this.lbMoney1.TabIndex = 5;
            this.lbMoney1.Text = "Зарплата";
            // 
            // txFam1
            // 
            this.txFam1.Location = new System.Drawing.Point(145, 111);
            this.txFam1.Name = "txFam1";
            this.txFam1.Size = new System.Drawing.Size(111, 20);
            this.txFam1.TabIndex = 4;
            // 
            // lbFaml1
            // 
            this.lbFaml1.AutoSize = true;
            this.lbFaml1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFaml1.Location = new System.Drawing.Point(31, 113);
            this.lbFaml1.Name = "lbFaml1";
            this.lbFaml1.Size = new System.Drawing.Size(73, 18);
            this.lbFaml1.TabIndex = 3;
            this.lbFaml1.Text = "Фамилия";
            // 
            // txName1
            // 
            this.txName1.Location = new System.Drawing.Point(145, 58);
            this.txName1.Name = "txName1";
            this.txName1.Size = new System.Drawing.Size(111, 20);
            this.txName1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(116, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Регестрировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbName1
            // 
            this.lbName1.AutoSize = true;
            this.lbName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName1.Location = new System.Drawing.Point(31, 60);
            this.lbName1.Name = "lbName1";
            this.lbName1.Size = new System.Drawing.Size(38, 18);
            this.lbName1.TabIndex = 0;
            this.lbName1.Text = "Имя";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(280, 52);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(241, 420);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            // 
            // txSearch
            // 
            this.txSearch.Location = new System.Drawing.Point(280, 26);
            this.txSearch.Name = "txSearch";
            this.txSearch.Size = new System.Drawing.Size(241, 20);
            this.txSearch.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(527, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 460);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(116, 420);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 484);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txSearch);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txSearch;
        private System.Windows.Forms.TextBox txDay1;
        private System.Windows.Forms.Label lbDay1;
        private System.Windows.Forms.TextBox txMoney1;
        private System.Windows.Forms.Label lbMoney1;
        private System.Windows.Forms.TextBox txFam1;
        private System.Windows.Forms.Label lbFaml1;
        private System.Windows.Forms.TextBox txName1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbName1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}

