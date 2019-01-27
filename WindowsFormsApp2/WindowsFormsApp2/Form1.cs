using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using System.Collections;
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string[] todo;
       public List<DateTime> list = new List<DateTime>();
        public DateTime[] arr;
       
        

        private void button1_Click(object sender, EventArgs e)
        {

            StreamWriter sw = new StreamWriter(@"D:\dell\Documents\hafsa.txt");
            sw.WriteLine(textBox1.Text +" "+ dateTimePicker1.Value + " " + dateTimePicker2.Value);
            sw.Close();
        }
        public void Read()
        {
            int count_row = 0;
            string line = "";
           
            StreamReader sr = new StreamReader(@"D:\dell\Documents\hafsa.txt");
            while((line=sr.ReadLine())!=null)
            {
                count_row++;
               
            }
            sr.Close();

            todo = new string[count_row];
            int i = 0;
            StreamReader sr1 = new StreamReader(@"D:\dell\Documents\hafsa.txt");
            while((line=sr1.ReadLine())!=null)
            {
                listBox1.Items.Add(line);
                DateTime dt = Convert.ToDateTime(line);
                list.Add(dt);
                
                
            }
            sr1.Close();
            arr = list.ToArray();
            Array.Sort(arr);
            foreach(DateTime dt in arr)
            {
                listBox2.Items.Add(dt);
            }
      
            

        
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {


            //listBox1.Hide();
            //button2.Hide();
            //button1.Hide();
            //textBox1.Hide();
            //dateTimePicker1.Hide();
            //dateTimePicker2.Hide();
            //listBox1.Enabled = true;
          
            //button2.Enabled = false;
            //button1.Enabled = false;
            //textBox1.Enabled = false;
            //dateTimePicker1.Enabled = false;
            //dateTimePicker2.Enabled = false;
            //listBox2.Enabled = true;
            //listBox2.Show();
            //arr = list.ToArray();
            //Array.Sort(arr);
           
            ////for (int j = 0; j < listBox1.Items.Count; j++)
            //foreach( DateTime dt in arr)
            //{

            //    listBox2.Items.Add(dt);
            //}


        }















    }
    }

