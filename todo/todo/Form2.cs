using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace todo
{
    public partial class Form2 : Form
    {
        public Form2(string s1,string s2,string s3,string s4)
        {
            InitializeComponent();
            textBox1.Text = s1;
            textBox2.Text = s2;textBox3.Text = s3;textBox4.Text = s4;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked&&checkBox2.Checked&&checkBox3.Checked&&checkBox4.Checked)
            {
                this.Hide();
                Form3 f3 = new Form3();
                f3.ShowDialog();
               
            

            }
            else
            {
                label1.Text = "You still haven't completed tour TO-DO List!!!";
            }
            
            
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
             
                label1.Text = "You have done " + textBox1.Text + "  from the TO-DO List!!! ";
                //textBox1.Hide();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
              
                label1.Text = "You have done " + textBox2.Text + "  from the TO-DO List!!! ";
                //textBox2.Hide();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox3.Checked)
            {
               
                label1.Text = "You have done " + textBox3.Text + "  from the TO-DO List!!! ";
               // textBox3.Hide();
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
               
                label1.Text = "You have done " + textBox4.Text + "  from the TO-DO List!!! ";
               // textBox4.Hide();
            }
        }
    }
    }

