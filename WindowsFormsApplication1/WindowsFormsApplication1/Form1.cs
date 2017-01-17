using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public void CheckAndSave()
        {
            if (txName1.Text=="" || txFam1.Text=="" || txMoney1.Text=="" || txDay1.Text == "")
            {
                txName1.Clear();
                txFam1.Clear();
                txMoney1.Clear();
                txDay1.Clear();
                MessageBox.Show("Некоректный ввод данных");
            }
            else
            {
                int d;
                double mon;
                string nam = txName1.Text;
                string fam = txFam1.Text;
                double.TryParse(txMoney1.Text, out mon);
                int.TryParse(txDay1.Text, out d);
                if (mon == 0 || d == 0)
                {
                    txName1.Clear();
                    txFam1.Clear();
                    txMoney1.Clear();
                    txDay1.Clear();
                    MessageBox.Show("Некоректный ввод данных");
                    return;
                }
                Regdan Register = new Regdan(nam, fam, mon, d);
                txName1.Clear();
                txFam1.Clear();
                txMoney1.Clear();
                txDay1.Clear();
                spisok.Add(Register);
                //    List<string> NName = spisok.;
                spisok.ForEach(x => listBox1.Items.Add(x));
                
            }
        }
        List<Regdan> spisok = new List<Regdan>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckAndSave();
        
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                var dan = (Regdan)listBox1.SelectedItem;
                label1.Text =$"{dan.Name}  {dan.Famil}";
            }
        }
    }
    public class Regdan
    {
        public string Name { get; set; }
        public string Famil { get; set; }
        public double Money { get; set; }
        public int Day { get; set; }
        public Regdan (string nam,string fam,double mon,int d)
        {
            Name = nam;
            Famil = fam;
            Money = mon;
            Day = d;

        }
        public override string ToString()
        {
            return Name + " " + Famil;
        }
    }
}
