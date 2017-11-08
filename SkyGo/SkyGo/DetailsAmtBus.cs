using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace SkyGo
{
    public partial class DetailsAmtBus : Form
    {
        OracleConnection conn;
        public DetailsAmtBus()
        {
            InitializeComponent();
        }

        public void connect1()
        {
            String oradb = "DATA SOURCE=DESKTOP-V82IFM3;PERSIST SECURITYINFO=True;USER ID=system;Password=root";
            conn = new OracleConnection(oradb); // C#
            conn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Modeofpayment frm = new Modeofpayment();
            frm.Show();
        }

        private void DetailsAmtBus_Load(object sender, EventArgs e)
        {
            label1.Text = Bus.SetValueForText1;
            label2.Text = Bus.SetValueForText2;
            label3.Text = Bus.SetValueForText3;
            label4.Text = Bus.SetValueForText4;
            label6.Text = Convert.ToString(Bus.SetValueForText5);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Modeofpayment frm1= new Modeofpayment();
            frm1.Show();
        }
    }
}
