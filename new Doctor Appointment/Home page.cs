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
    public partial class Home_page : Form
    {
        Form1 f = new Form1();
        public Home_page(Form1 f)

        {

            InitializeComponent();
            this.f = f;
        }

        public Home_page()
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }
        private void button7_Click( object sender, EventArgs e)
        {
        }

        private void Home_page_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.ShowDialog();
 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Apointment apointment = new Apointment();
            apointment.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Doctors doctors = new Doctors();
            doctors.ShowDialog();
        }
    }
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();

        }

        static class Program
        {
            [STAThread]
            static void main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Home_page());
            }
        }
    }
}