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
    public partial class CarToken : Form
    {
        RentACar car;
        public CarToken(RentACar car)
        {
            this.car = car;
            InitializeComponent();
        }

        private void CarToken_Load(object sender, EventArgs e)
        {
            this.label8.Text = car.getCustomerName();
            this.label9.Text = car.getCustomerPhoneNo();           
            this.label11.Text = car.getCarName();
            this.label12.Text = car.getCarId();
            this.label13.Text = car.getDateRent();
            this.label14.Text = car.getPrice();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
