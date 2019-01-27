using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 namespace ToDoList
{
    public partial class Form1 : Form
    {

        DateTime[] date = new DateTime [100];
        string[] todo = new string[100];
        int i = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
              
              date[i]=  dateTimePicker1.Value;
            todo[i] = textBox1.Text;
              i++;
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < date.Length - 1; i++)
            {
                listBox1.Items.Add(date[i]);
               
            }
        }
    }
}
