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
    
    public partial class ForgotPass : Form
    {
        
        string newpass;
        OracleConnection conn;
        OracleCommand comm;
        public static string SetValueForText4 = "";


        public ForgotPass()
        {
            InitializeComponent();
        }
        public void connect1()
        {
            String oradb = "DATA SOURCE=DESKTOP-V82IFM3;PERSIST SECURITYINFO=True;USER ID=system;Password=root";
            conn = new OracleConnection(oradb); // C#
            conn.Open();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            newpass = textBox4.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetValueForText4 = textBox4.Text;
            if (textBox1.Text == newpass)
            {
                this.Hide();
                Login frm = new Login();
                frm.Show();

            }
            try
            {
                connect1();
                comm = new OracleCommand();
                comm.Connection = conn;
                //comm.CommandText = "update users set password= '"+newpass+"';";
                comm.CommandType = CommandType.Text;
                comm.ExecuteNonQuery();
                conn.Close();
                
                
            }
            catch (Exception ew)
            {
                Console.Write("error" + ew);
            }
            
        }

        private void ForgotPass_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
