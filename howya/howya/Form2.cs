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

namespace howya
{
    public partial class Form2 : Form
    {
      
        public Form2()
        {
            InitializeComponent();

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
                cmd.CommandText = "insert into custinfo (Firstname,Lastname,Pay) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3 .Text+ "')";

                cmd.ExecuteNonQuery();
                MessageBox.Show("Your data has been saved!!!");
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\dell\Documents\connectcheck.accdb;
Persist Security Info=False;";
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con; 
                
             string query=   "update custinfo set Firstname = '" + textBox1.Text + "' , Lastname = '" + textBox2.Text + "' , Pay = '" + textBox3.Text + "' where custid = " + textBox4.Text + "";
                MessageBox.Show(query);
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data edit successful!!!");
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\dell\Documents\connectcheck.accdb;
Persist Security Info=False;";
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                string query = "delete from custinfo where custid = "+textBox4.Text+"";
                MessageBox.Show(query);
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data deleted!!!");
                con.Close();
              
               // cmd.CommandText = "delete from custinfo where custid = "+ textBox4.Text + "";
               // cmd.ExecuteNonQuery();
                //MessageBox.Show("Data deleted!!!");
                //con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
    }
}
