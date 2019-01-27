using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MYTODOLIST
{
    public partial class Form2 : Form

    {
        public string[] TOdo = new string[3];
        public Form2(string s1,string s2,string s3)
        {
            InitializeComponent();
            this.textBox4.Text = s1;
           this. textBox5.Text = s2;
            this.textBox6.Text = s3;
         
        }

        private void dateTimePicker2_ValueChanged()
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listBox1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                if (numericUpDown1.Value == 1)
                {
                    TOdo[0] = textBox4.Text;
                }
                if (numericUpDown1.Value == 2)
                {
                    TOdo[1] = textBox4.Text;
                }
                if (numericUpDown1.Value == 3)
                {
                    TOdo[2] = textBox4.Text;
                }
                if (numericUpDown2.Value == 1)
                {
                    TOdo[0] = textBox5.Text;
                }
                if (numericUpDown2.Value == 2)
                {
                    TOdo[1] = textBox5.Text;
                }
                if (numericUpDown2.Value == 3)
                {
                    TOdo[2] = textBox5.Text;
                }
                this.Hide();
                Form3 f3 = new Form3(textBox4.Text,textBox5.Text);
                f3.ShowDialog();
            }
                //listBox1.Show();
                //for (int i = 0; i <= 1; i++)
                //{
                //    listBox1.Items.Add(TOdo[i]);
                //}

                //button1.Hide();
                //dateTimePicker5.Hide();
                //dateTimePicker6.Hide();
                //dateTimePicker7.Hide();
                //textBox4.Hide();
                //textBox5.Hide();
                //textBox6.Hide();
                //numericUpDown1.Hide();
                //numericUpDown2.Hide();
                //numericUpDown3.Hide();
                //label5.Hide();
            
            else
            {
                if (numericUpDown1.Value == 1)
                {
                    TOdo[0] = textBox4.Text;
                }
                if (numericUpDown1.Value == 2)
                {
                    TOdo[1] = textBox4.Text;
                }
                if (numericUpDown1.Value == 3)
                {
                    TOdo[2] = textBox4.Text;
                }
                if (numericUpDown2.Value == 1)
                {
                    TOdo[0] = textBox5.Text;
                }
                if (numericUpDown2.Value == 2)
                {
                    TOdo[1] = textBox5.Text;
                }
                if (numericUpDown2.Value == 3)
                {
                    TOdo[2] = textBox5.Text;
                }
                    if (numericUpDown3.Value == 1)
                {
                    TOdo[0] = textBox6.Text;

                }
                if (numericUpDown3.Value == 2)
                {
                    TOdo[1] = textBox6.Text;
                }
                if (numericUpDown3.Value == 3)
                {
                    TOdo[2] = textBox6.Text;
                }
                this.Hide();
                Form5 f5 = new Form5(textBox4.Text, textBox5.Text, textBox6.Text);
                f5.ShowDialog();



                   
                //listBox1.Show();
                //for (int i = 0; i <= TOdo.Length - 1; i++)
                //{
                //    listBox1.Items.Add(TOdo[i]);
                //}

                //button1.Hide();
                //dateTimePicker5.Hide();
                //dateTimePicker6.Hide();
                //dateTimePicker7.Hide();
                //textBox4.Hide();
                //textBox5.Hide();
                //textBox6.Hide();
                //numericUpDown1.Hide();
                //numericUpDown2.Hide();
                //numericUpDown3.Hide();
                //label5.Hide();

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
    }

