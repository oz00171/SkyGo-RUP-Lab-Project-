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
//using System.Data;

namespace SkyGo
{
    public partial class Register : Form
    {
        string password;
        OracleConnection conn;
        OracleCommand comm;
        string name;
        string email;
        string confirmpass;
        int age;
        string phoneno;
        
        public static string SetValueForText2 = "";
        public static string SetValueForText3 = "";
        

        public Register()
        {
            InitializeComponent();
        }

        public void connect1()
        {
            String oradb = "DATA SOURCE=DESKTOP-V82IFM3;PERSIST SECURITY INFO=True;USER ID=system;Password=root";
            conn = new OracleConnection(oradb); // C#
            conn.Open();
        }
        

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetValueForText2 = textBox2.Text;
            SetValueForText3 = textBox3.Text;
            if (textBox5.Text == " " || textBox6.Text == "")
            {
                MessageBox.Show("Fill in all the details to proceed");
                this.Hide();
                Login frm2 = new Login();
                frm2.Show();
            }
            try
            {
                connect1();
                comm = new OracleCommand();
                comm.Connection = conn;
                //comm.CommandText = "execute register(email, name, password, age, phoneno, security);";
                comm.CommandText = "insert into users values('" + email + "', '" + name + "', '" + password + "', " + age + ", '" + phoneno + "')";
                //comm.CommandText = "login";
                //comm.Parameters.AddWithValue
                //comm.CommandText="if('"+email+"' not in(select email_ID from users ))then insert into users values('"+ email +"', '"+password+"', "+age+", '"+phoneno+"', '" +name+"', '"+ security+"')"; 
                comm.CommandType = CommandType.Text;
                comm.ExecuteNonQuery();
                this.Hide();
                Login frm = new Login();
                frm.Show();
                conn.Close();
            }
            catch (Exception ew)
            {
                Console.Write("error" + ew);
            }
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            name = textBox1.Text;
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            email = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
            password = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
            if (textBox4.Text == password)
            {
                confirmpass = textBox4.Text;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
            age = Convert.ToInt32(textBox5.Text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
            phoneno = textBox6.Text;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
