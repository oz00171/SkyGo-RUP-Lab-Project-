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
    public partial class DetailsAmt : Form
    {
        OracleConnection conn;
        public DetailsAmt()
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

        private void DetailsAmt_Load(object sender, EventArgs e)
        {
            label1.Text = Flight.SetValueForText1;
            label2.Text = Flight.SetValueForText2;
            label3.Text = Flight.SetValueForText3;
            label4.Text = Flight.SetValueForText4;
            label6.Text = Convert.ToString(Flight.SetValueForText5);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
