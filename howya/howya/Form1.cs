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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\dell\Documents\connectcheck.accdb;
Persist Security Info=False;";
            try {
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from custinfo";
                cmd.CommandText = "select * from custinfo where Username='" + textBox1.Text + "' and Password = '" + textBox2.Text + "'";
                OleDbDataReader reader = cmd.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                { MessageBox.Show("Username and Passwowrd are correct!!!");
                    con.Close();
                    con.Dispose();
                    this.Hide();
                    Form2 f2 = new Form2();
                    f2.ShowDialog();
                }
                else if (count > 1)
                {
                    MessageBox.Show("Duplicate Username and Password!!!");
                }
                else
                {
                    MessageBox.Show("Username and Password are incorrect!!!");
                }

                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            }
           
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
