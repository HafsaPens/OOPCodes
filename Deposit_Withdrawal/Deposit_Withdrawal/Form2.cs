using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deposit_Withdrawal
{
    public partial class Form2 : Form
    {
        public Form2(string Password)
        {
            InitializeComponent();
            textBox1.Text = Password;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
       progressBar1.Value = progressBar1.Value+1;
            if(progressBar1.Value>=99)
            {
                this.Hide();
                    
                Form3 f3 = new Form3(textBox1.Text);
                
                f3.Show();
                timer1.Enabled = false;
                progressBar1.Value = progressBar1.Value-1;
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
