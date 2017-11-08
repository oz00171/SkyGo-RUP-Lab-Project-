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
    public partial class ChooseMode : Form
    {
        OracleConnection conn;
        public ChooseMode()
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
            if (radioButton1.Checked == true)
            {
                this.Hide();
                Train frm = new Train();
                frm.Show();
            }
            else if (radioButton2.Checked == true)
            {
                this.Hide();
                Bus frm1 = new Bus();
                frm1.Show();
            }
            else
            {
                this.Hide();
                Flight frm2 = new Flight();
                frm2.Show();
            }

        }

        private void ChooseMode_Load(object sender, EventArgs e)
        {

        }
    }
}
