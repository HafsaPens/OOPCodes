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
    public partial class Form3 : Form
    {
        public Form3(string Password)
        {
            InitializeComponent();
            textBox2.Text = Password;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
             
                this.Hide();
                Form4 f4 = new Form4(textBox2.Text);
                f4.Show();

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5(textBox2.Text);
            f5.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f6 = new Form6(textBox2.Text);
            f6.Show();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
