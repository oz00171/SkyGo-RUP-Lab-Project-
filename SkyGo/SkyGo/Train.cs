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
    public partial class Train : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;
        string source;
        string dest;
        string date;
        string noofpass;
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public static string SetValueForText3 = "";
        public static string SetValueForText4 = "";
        public static int SetValueForText5;

        public Train()
        {
            InitializeComponent();
        }
        public void connect1()
        {
            String oradb = "DATA SOURCE=DESKTOP-V82IFM3;PERSIST SECURITY INFO=True;USER ID=system;Password=root";
            conn = new OracleConnection(oradb); // C#
            conn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connect1();
                comm = new OracleCommand();
                comm.CommandText = "select * from trains";
                //comm.CommandText = "select * from flights where dept_date = '"+date+"' and source = '"+source+"' and destination = '"+dest+"' order by price;";
                comm.CommandType = CommandType.Text;
                ds = new DataSet();
                da = new OracleDataAdapter(comm.CommandText, conn);
                da.Fill(ds, "trains");
                dt = ds.Tables["trains"];
                int t = dt.Rows.Count;
                //MessageBox.Show(t.ToString());
                dr = dt.Rows[i];
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "trains";
                conn.Close();
            }
            catch(Exception ew)
            {
                Console.Write("error" + ew);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            source = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dest = textBox2.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MMM-yyyy";
            date = dateTimePicker1.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            noofpass = textBox3.Text;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetValueForText1 = textBox1.Text;
            SetValueForText2 = textBox2.Text;
            SetValueForText3 = textBox3.Text;
            SetValueForText4 = textBox4.Text;
            SetValueForText5 = Convert.ToInt32(textBox3.Text) * Convert.ToInt32(textBox5.Text);
            this.Hide();
            DetailsAmtTrains frm = new DetailsAmtTrains();
            frm.Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Train_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseMode frm3 = new ChooseMode();
            frm3.Show();
        }
    }
}
