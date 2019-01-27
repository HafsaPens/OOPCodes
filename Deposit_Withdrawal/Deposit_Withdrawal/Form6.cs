using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Deposit_Withdrawal
{
    public partial class Form6 : Form
    {
        public Form6(string Password)
        {
            InitializeComponent();
            textBox1.Text = Password;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\dell\Documents\connectcheck.accdb;
Persist Security Info=False;";
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "update custinfo set Pay=Pay-'" + textBox3.Text + "' where Password = '"+textBox1.Text+"'";
                cmd.ExecuteNonQuery();
                textBox1.Enabled = false;
                MessageBox.Show("Withdrawal successful!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3(textBox1.Text);
            f3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
