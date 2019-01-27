using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace todo
{
    public partial class Form1 : Form
    { 
           
    
        public Form1()
        {
            InitializeComponent();
        }

       

    

  

    

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2(textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text);
            f2.ShowDialog();
               

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

    
    }
    }


