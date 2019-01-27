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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
                cmd.CommandText= "select * from custinfo where Username = '"+ textBox1.Text+ "' and Password = '"+ textBox2.Text+ "'";
                OleDbDataReader reader = cmd.ExecuteReader();
                int count = 0;
                while(reader.Read())
                {
                    count = count + 1;
                }
                if(count==1)
                {
                    MessageBox.Show("Correct Username and Password!!!");
                    con.Close();
                    con.Dispose();
                    Form2 f2 = new Form2(textBox2.Text);
                    f2.Show();
                }
                else if(count>1)
                {
                    MessageBox.Show("Duplicate Username and Password!!!");
                }
                else
                {
                    MessageBox.Show("Incorrect Username and Password!!!");
                }
               
            }

            catch(Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }

