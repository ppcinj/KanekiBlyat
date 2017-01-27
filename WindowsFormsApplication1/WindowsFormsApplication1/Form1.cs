using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
   
    public partial class Form1 : Form
    {
        public List<Regdan> Spisok = new List<Regdan>();
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
                var nam = txName1.Text;
                var fam = txFam1.Text;
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
                var register = new Regdan(nam, fam, mon, d);
                txName1.Clear();
                txFam1.Clear();
                txMoney1.Clear();
                txDay1.Clear();
                Spisok.Add(register);
                //    List<string> NName = spisok.;
                listBox1.Items.Clear();
                Spisok.ForEach(x => listBox1.Items.Add(x));
                
            }
        }
        
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
            var regId = (Regdan)listBox1.SelectedItem;
            var newform = new FormEdit((Regdan)listBox1.SelectedItem);
            newform.FormClosed += delegate
            {
                  Spisok.RemoveAll(x => x.Id == regId.Id);
                  Spisok.Add(newform.Save);
              };
            newform.ShowDialog();
            listBox1.Items.Clear();
            Spisok.ForEach(x => listBox1.Items.Add(x));



        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            var dan = (Regdan)listBox1.SelectedItem;
            lbName.Text =$"{dan.Name}";
            lbFam.Text =$" {dan.Famil}";
            lbMoney.Text =$"{dan.Money}";
            lbDays.Text = $"{dan.Day}";
        }

        private void txSearch_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Spisok.Where(x => x.ToString().ToLower().Contains(txSearch.Text.ToLower())).OrderBy(x => x.ToString()).
                ToList().ForEach(x => listBox1.Items.Add(x));

            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    public class Regdan
    {
        public Guid Id { get; set; }
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
            Id = Guid.NewGuid();
                
        }
        public override string ToString()
        {
            return Name + " " + Famil;
        }
    }
}
