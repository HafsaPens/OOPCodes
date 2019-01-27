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

namespace AutomateTellerMachine
{
    public partial class Form1 : Form

    {

        OleDbConnection con = new OleDbConnection();
        public Form1()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\dell\Documents\atmpin.accdb;
Persist Security Info=False;";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblpin_Click(object sender, EventArgs e)
        {

        }

        private void lblbalance_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lblpin.Text = lblpin.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lblpin.Text = lblpin.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lblpin.Text = lblpin.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lblpin.Text = lblpin.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lblpin.Text = lblpin.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lblpin.Text = lblpin.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lblpin.Text = lblpin.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lblpin.Text = lblpin.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lblpin.Text = lblpin.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            lblpin.Text = lblpin.Text + "0";
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            DialogResult iexit;
            iexit = MessageBox.Show("Want to exit", "ATM System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iexit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {

            lblpin.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblpin.Text = "Please provide the correct PIN and Press Enter!!!";
            textBox1.Visible = false;
            lblbalance.Visible = false;
            lblwithdrawal.Visible = false;
            lbldeposit.Visible = false;
            lblloan.Visible = false;
            btnbalance.Enabled = false;
            btnloan.Enabled = false;
            btndeposit.Enabled = false;
            btnwithdrawal.Enabled = false;
        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = lblpin.Text;
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from custinfo where Pin = " + lblpin.Text + "";
                OleDbDataReader reader = cmd.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    lblpin.Text = "";
                    lblbalance.Visible = true;
                    lblwithdrawal.Visible = true;
                    lbldeposit.Visible = true;
                    lblloan.Visible = true;
                    btnbalance.Enabled = true;
                    btnloan.Enabled = true;
                    btndeposit.Enabled = true;
                    btnwithdrawal.Enabled = true;
                    con.Close();

                }
                else if (count > 1)
                {
                    MessageBox.Show("Duplicate Pin Code!!!");
                }
                else
                {
                    MessageBox.Show("Invalid Pin Code!!!");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
                con.Close();
            }
        }

        private void btnbalance_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from custinfo where Pin =" + textBox1.Text + "";
                OleDbDataReader reader = cmd.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    lblpin.Text = "";

                    lblpin.Text = reader[1].ToString();
                    count = count + 1;

                }
                if (count == 1)
                {
                    DialogResult iexit;
                    iexit = MessageBox.Show("Want to hide,press yes", "Balance Enquiry", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (iexit == DialogResult.Yes)
                    {

                        lblpin.Text = "";
                        lbldeposit.Visible = false;
                        lblwithdrawal.Visible = false;
                        lblloan.Visible = false;
                        lblbalance.Visible = false;
                        btndeposit.Enabled = false;
                        btnwithdrawal.Enabled = false;
                        btnloan.Enabled = false;
                        btnbalance.Enabled = false;
                        lblpin.Text = "Please provide the correct PIN and Press Enter!!!";

                    }

                }
                else if (count > 1)
                {
                    MessageBox.Show("Duplicate Pin Code!!!");
                    lblpin.Text = "";
                }
                else
                {
                    MessageBox.Show("Invalid Pin Code!!!");
                    lblpin.Text = "";
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void btnwithdrawal_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = @"update custinfo set Balance=Balance-"+lblpin.Text+" where Pin ="+ textBox1.Text+ "";
                cmd.ExecuteNonQuery();
                lblpin.Text = "Withdrawal Successful!!!";
                MessageBox.Show("Hide?" +
                    "Press OK!");
                lblpin.Text = "";
                lbldeposit.Visible = false;
                lblwithdrawal.Visible = false;
                lblloan.Visible = false;
                lblbalance.Visible = false;
                btndeposit.Enabled = false;
                btnwithdrawal.Enabled = false;
                btnloan.Enabled = false;
                btnbalance.Enabled = false;
                lblpin.Text = "Please enter the correct PIN and Press Enter!!!";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lbldeposit_Click(object sender, EventArgs e)
        {

        }

        private void btndeposit_Click_1(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = @"update custinfo set Balance=Balance+" + lblpin.Text + " where Pin =" + textBox1.Text + "";
                cmd.ExecuteNonQuery();
                lblpin.Text = "Deposit Successful!!!";
                MessageBox.Show("Hide?" +
                    "Press OK!");
                lblpin.Text = "";
                lbldeposit.Visible = false;
                lblwithdrawal.Visible = false;
                lblloan.Visible = false;
                lblbalance.Visible = false;
                btndeposit.Enabled = false;
                btnwithdrawal.Enabled = false;
                btnloan.Enabled = false;
                btnbalance.Enabled = false;
                lblpin.Text = "Please enter the correct PIN and Press Enter!!!";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
