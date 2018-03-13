using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ParvesTest.UI
{
    public partial class Home : Form
    {
        public Home(string Role)
        {
            InitializeComponent();
            label12.Text = Role;

            timer1.Start();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            if (label12.Text != "Admin")
            {
                //tabPage2.Enabled = false;
                buttonCarAdmin.Enabled = false;
                buttonBusAdmin.Enabled = false;
                labelWelcomeAdmin.Enabled = false;
                buttonAirLineAdmin.Enabled = false;
                buttonTrainAdmin.Enabled = false;
            }
            else {
                labelAccess.Enabled = false;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }


        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormBus bus = new FormBus();
            bus.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            RentACar rentcar = new RentACar();
            rentcar.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.time_label.Text = datetime.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();

        }

        private void buttonCarAdmin_Click(object sender, EventArgs e)
        {
            AdminCarForm admincar = new AdminCarForm();
            admincar.Show();
        }

        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonBusAdmin_Click(object sender, EventArgs e)
        {
            AdminBusForm adminBus = new AdminBusForm();
            adminBus.Show();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
            UserLogin login = new UserLogin();
            login.Show();
        }
    }
}
