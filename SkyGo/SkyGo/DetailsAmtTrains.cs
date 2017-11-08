using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyGo
{
    public partial class DetailsAmtTrains : Form
    {
        public DetailsAmtTrains()
        {
            InitializeComponent();
        }

        private void DetailsAmtTrains_Load(object sender, EventArgs e)
        {
            label1.Text = Train.SetValueForText1;
            label2.Text = Train.SetValueForText2;
            label3.Text = Train.SetValueForText3;
            label4.Text = Train.SetValueForText4;
            label6.Text = Convert.ToString(Train.SetValueForText5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Modeofpayment frm1 = new Modeofpayment();
            frm1.Show();
        }
    }
}
