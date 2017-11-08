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
    public partial class Login : Form
    {
        string username;
        string password;
        OracleConnection conn;
        OracleCommand comm;
        public Login()
        {
            InitializeComponent();
        }

        public void connect1()
        {
            String oradb = "DATA SOURCE=DESKTOP-V82IFM3;PERSIST SECURITY INFO=True;USER ID=system;Password=root";
            conn = new OracleConnection(oradb); // C#
            conn.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register frm = new Register();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseMode frm = new ChooseMode();
            frm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            if (textBox1.Text == Register.SetValueForText2 && textBox2.Text == Register.SetValueForText3)
            {
                this.Hide();
                ChooseMode frm1 = new ChooseMode();
                frm1.Show();
            }
            else if(textBox1.Text==Register.SetValueForText2 && textBox2.Text== ForgotPass.SetValueForText4)
            {
                this.Hide();
                ChooseMode frm2 = new ChooseMode();
                frm2.Show();
            }


            else
            {
                MessageBox.Show("Wrong username or password");
            }

            try
            {
                connect1();
                comm = new OracleCommand();
                comm.Connection = conn;
                //MessageBox.Show("conn");
                //comm.CommandText = "execute login(username, password);";
                //MessageBox.Show("conn");
                //int value = (int)comm.ExecuteScalar();
                
                comm.CommandType = CommandType.Text;
                comm.ExecuteNonQuery();
                this.Hide();
                ChooseMode frm = new ChooseMode();
                frm.Show();
                conn.Close();
            }
            catch (Exception ew)
            {
                Console.Write("error" + ew);
            }
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            username = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            password = textBox2.Text;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ForgotPass frm = new ForgotPass();
            frm.Show();
        }
    }
}
