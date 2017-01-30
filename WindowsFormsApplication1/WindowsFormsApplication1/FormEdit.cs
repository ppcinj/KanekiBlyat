using System;
using System.Globalization;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormEdit : Form
    { 
        
        public Regdan Save { get; set; }
        public  FormEdit(Regdan spisok)
        {
            InitializeComponent();
            Save = spisok;
            txName2.Text = spisok.Name;
            txFanil2.Text = spisok.Famil;
            txMoney2.Text = spisok.Money.ToString(CultureInfo.InvariantCulture);
            txDays2.Text = spisok.Day.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double m;
            int d;
            
            double.TryParse(txMoney2.Text,out m);
            int.TryParse(txDays2.Text,out  d);
            if (txName2.Text=="" )
            {
                txName2.Clear();
                MessageBox.Show("Веденно некоректное имя", "Ошибка");
            }
            if (txFanil2.Text == "")
            {
                txFanil2.Clear();
                MessageBox.Show("Веденна некоректная фамилия", "Ошибка");
            }
            if (d == 0)
            {
                txDays2.Clear();
                MessageBox.Show("Веденны некоректные дни", "Ошибка");
            }
            if (m == 0)
            {
                txMoney2.Clear();
                MessageBox.Show("Веденна некоректная зарплата", "Ошибка");
            }
            else
            {
                Save.Name = txName2.Text;
                Save.Famil = txFanil2.Text;
                Save.Money = m;
                Save.Day = d;
                this.Close();
            }
            
        }
    }
}
