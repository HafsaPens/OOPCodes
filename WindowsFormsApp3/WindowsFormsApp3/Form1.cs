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

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DateTime[] arr;
        List<DateTime> list = new List<DateTime>();

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string line="";
            StreamReader sr = new StreamReader(@"D:\dell\Documents\hafsa.txt");
            while((line=sr.ReadLine())!=null)
            {
                listBox1.Items.Add(line);
                DateTime dt = Convert.ToDateTime(line);
              list.Add((dt));
            }
            arr = list.ToArray();
            Array.Sort(arr,0,3);
            
            foreach (DateTime dt in arr)
            {
                listBox2.Items.Add(dt);
            }
        }

    }
}
