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

    public partial class Patient : Form
    {
        Form1 f = new Form1();
        public Patient(Form1 f)
        {
            InitializeComponent();
            this.f = f;
        }

        public Patient(Home_page home_page)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CreateNewPatient createNewPatient = new CreateNewPatient();
            createNewPatient.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   

        private void button2_Click_1(object sender, EventArgs e)
        {
            Home_page New_pat = new Home_page();
            New_pat.Show();
            this.Hide();

        }

      
    }
}
