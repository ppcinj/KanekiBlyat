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
            Save.Name = txName2.Text;
            Save.Famil = txFanil2.Text;
            Save.Money = Convert.ToDouble( txMoney2.Text);
            Save.Day =Convert.ToInt16 (txDays2.Text);
        }
    }
}
