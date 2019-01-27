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
    public partial class Form4 : Form
    {
        public Form4(string Password)
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
                cmd.CommandText = "select * from custinfo where Password = '" + textBox1.Text + "'";
                OleDbDataReader reader = cmd.ExecuteReader();
                int count = 0;
                while(reader.Read())
                {
                    
                    count = count + 1;
                    textBox2.Text = reader[8].ToString();
                }
                  if(count==1)
                {
                    
                    
                    MessageBox.Show("If you have checked your current balance click ok");
                    
                    textBox2.Clear();
                    textBox1.Enabled = false;
                    con.Close();
                    con.Dispose();
                   
                    textBox1.Focus();
                    
                   
                
                    

                }
                else if(count>1)
                {
                    MessageBox.Show("Duplicate custid!!!");

                    textBox1.Clear();
                    textBox1.Focus();
                   
                   
               }
                else
                { 
                    MessageBox.Show("Entering a wrong custid that doesn't exist in the record!!!");
                    textBox1.Clear();
                    textBox1.Focus();
                    

                }
            
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3(textBox1.Text);
            f3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
