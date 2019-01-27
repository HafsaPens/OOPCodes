using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listoftodo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string[] s = new string[3];

            Enqueue que = new Enqueue(textBox1.Text);
           
            textBox2.Text = s[0];
            textBox3.Text = s[1];
    }



}  }
    

