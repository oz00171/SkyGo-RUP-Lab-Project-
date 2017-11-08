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
   
    public partial class Paymentportal : Form
    {
        String x;
        String y;
        OracleConnection conn;
        public Paymentportal()
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
             
            MessageBox.Show("Amount: " + y + " has been credited from bank account number: " + x);
            
            this.Hide();
            Confirmed frm = new Confirmed();
            frm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            x = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            y = textBox2.Text;
        }
    }
}
