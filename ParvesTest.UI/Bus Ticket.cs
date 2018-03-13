using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParvesTest.UI
{
    public partial class Bus_Ticket : Form
    {
        FormBus bus;
        public Bus_Ticket(FormBus bus)
        {
            this.bus = bus;
            InitializeComponent();
        }

        private void Bus_Ticket_Load(object sender, EventArgs e)
        {
            this.label10.Text = bus.getBusName();
            this.label11.Text = bus.getCustomerName();
            this.label12.Text = bus.getContactNumber();
            this.label13.Text = bus.getSeatNo();
            this.label14.Text = bus.getFrom();
            this.label15.Text = bus.getTo();
            this.label19.Text = bus.getTravelDate();
            this.label16.Text = bus.getPrice();
            this.label17.Text = bus.getBusType();
            this.label18.Text = bus.getPayment();

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
