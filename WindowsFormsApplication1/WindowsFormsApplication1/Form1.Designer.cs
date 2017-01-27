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
            this.lbDays = new System.Windows.Forms.Label();
            this.lbMoney = new System.Windows.Forms.Label();
            this.lbFam = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
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
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            // 
            // txSearch
            // 
            this.txSearch.Location = new System.Drawing.Point(280, 26);
            this.txSearch.Name = "txSearch";
            this.txSearch.Size = new System.Drawing.Size(241, 20);
            this.txSearch.TabIndex = 2;
            this.txSearch.TextChanged += new System.EventHandler(this.txSearch_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbDays);
            this.groupBox2.Controls.Add(this.lbMoney);
            this.groupBox2.Controls.Add(this.lbFam);
            this.groupBox2.Controls.Add(this.lbName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(527, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 460);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // lbDays
            // 
            this.lbDays.AutoSize = true;
            this.lbDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDays.Location = new System.Drawing.Point(145, 218);
            this.lbDays.Name = "lbDays";
            this.lbDays.Size = new System.Drawing.Size(0, 18);
            this.lbDays.TabIndex = 10;
            // 
            // lbMoney
            // 
            this.lbMoney.AutoSize = true;
            this.lbMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMoney.Location = new System.Drawing.Point(145, 161);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(0, 18);
            this.lbMoney.TabIndex = 9;
            // 
            // lbFam
            // 
            this.lbFam.AutoSize = true;
            this.lbFam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFam.Location = new System.Drawing.Point(144, 113);
            this.lbFam.Name = "lbFam";
            this.lbFam.Size = new System.Drawing.Size(0, 18);
            this.lbFam.TabIndex = 8;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.Location = new System.Drawing.Point(145, 78);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(0, 18);
            this.lbName.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(34, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Рабочие дни";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(34, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Зарплата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(33, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(34, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbName1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbDays;
        private System.Windows.Forms.Label lbMoney;
        private System.Windows.Forms.Label lbFam;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txName1;
    }
}

