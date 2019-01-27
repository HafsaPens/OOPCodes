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
namespace oledbconnectcheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\dell\Documents\connectcheck.accdb;
Persist Security Info=False;";
                connection.Open();
                checkconnection.Text="Connection Successful!!!";
            
                connection.Close();
        }
            catch(Exception ex)
            {
                MessageBox.Show("Error" +ex);
            }
            }
    }
}
