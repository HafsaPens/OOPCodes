using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace MYTODOLIST
{
    public partial class Form5 : Form
    {
        public Form5(string f1,string f2,string f3)
        {
            InitializeComponent();
            this.textBox1.Text = f1;
            this.textBox2.Text = f2;
            this.textBox3 .Text= f3;
        }
        string setAlarm;
        private void Form5_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            SpeechSynthesizer speech = new SpeechSynthesizer();
            speech.SetOutputToDefaultAudioDevice();
            if(setAlarm==DateTime.Now.ToString())
            {
                for(int i=0;i<4;i++)
                {
                    speech.Speak($"It's {dateTimePicker1.Value} and you gotta do {textBox1.Text}");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(dateTimePicker1.Value<DateTime.Now)
            {
                MessageBox.Show("The time you set is improper or less than the time now!!!");
            }
            else
            {
                setAlarm =dateTimePicker1.Value.ToString();
                MessageBox.Show("The alarm has been set successfully!!!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox1.Hide();
            button4.Hide();
            button4.Enabled = false;
            button5.Enabled = false;
            button5.Hide();
            timer1.Enabled = false;
            timer1.Enabled = false;
            dateTimePicker1.Hide();
            button1.Hide();


        }
    }
}
