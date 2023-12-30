using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace new_Doctor_Appointment
{
    public partial class Form1 : Form
    {
        public object PasswordChar { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

            string Username = UserTxt.Text;
            string Password = (paswordTxt.Text);
            string myUser = "ilyaas";
            string myPass = "4747";
            if (Username == myUser && Password == myPass)
            {
                pictureBox2.Visible = true;
                AnswerLbl.Text = "You are correct and Welcome";
                AnswerLbl.BackColor = Color.Green;
                UserTxt.ForeColor = Color.Green;
                paswordTxt.BackColor = Color.Green;
                Home_page home_Page = new Home_page(this);
                home_Page.Show();
                this.Hide();
                button2.Cursor = Cursors.Hand;
       


            }
            else
            {
                MessageBox.Show("Username or Password incorecr!","login Failed",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();


        }
        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string Password = (paswordTxt.Text);
            pictureBox2.Visible = true;
            if (paswordTxt.PasswordChar == '*')
            {
                paswordTxt.PasswordChar = '\0';

            }
            else
            {
                paswordTxt.PasswordChar = '*';
            }
        }



        private void RemoveCharMethod(string Password)
        {
            Password.Remove(paswordTxt.PasswordChar);
        }

        private void paswordTxt_TextChanged(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
        }
    }
}
