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
    public partial class FormBus : Form
    {
        public FormBus()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=HP;Initial Catalog=project01;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void FormBus_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * From AvailableSeat Where Time='8:00 am'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * From AvailableSeat Where Time='2:00 pm'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * From AvailableSeat Where Time='7:00 pm'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * From AvailableSeat Where Time='10:00 pm'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            
            textBox3.Text = row.Cells[1].Value.ToString();
            textBox5.Text = row.Cells[2].Value.ToString();
            textBox4.Text = row.Cells[3].Value.ToString();
            textBox6.Text = row.Cells[4].Value.ToString();

        }

        private void buttonBackHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bus_Ticket bustk = new Bus_Ticket(this);
            bustk.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "Enter a City";
            comboBox2.Text = "Enter a City";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            comboBox3.Text = "Search Buses";
            textBox1.Text = "";
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            comboBox4.Text = "";
            
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text != "" && textBox1.Text != "" && textBox2.Text != "" && comboBox1.Text != "" && comboBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && comboBox4.Text != "" && textBox6.Text != "")
            {
                SqlConnection con = new SqlConnection(@"Data Source=HP;Initial Catalog=project01;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO BusCustomerInfo
                (Bus_Name, Customer_Name, Contact_Number, Source, Destination, Seat, Price, Time, Payment, Type, Journey_Date, Return_Date)
                VALUES     ('" + comboBox3.Text + "','" + textBox1.Text + "','" + textBox2.Text + "',  '" + comboBox1.Text + "', '" + comboBox2.Text + "','" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + comboBox4.Text + "', '" + textBox6.Text + "', '" + dateTimePicker1.Value.ToString("MM-dd-yyyy") + "', '" + dateTimePicker1.Value.ToString("MM-dd-yyyy") + "')", con);
               // cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Booking Successfuly...");

            }
            else {
                MessageBox.Show("Fill the all Field.","Message",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        


        public string getBusName() {

            return comboBox3.Text;
        }

        public string getCustomerName() {
            return textBox1.Text;
        }

        public string getContactNumber() {
            return textBox2.Text;
        }

        public string getSeatNo() {
            return textBox3.Text;
        }

        public string getFrom() {
            return comboBox1.Text;
        }

        public string getTo() {
            return comboBox2.Text;
        }

        public string getTravelDate() {
            return dateTimePicker1.Text;
        }
        public string getPrice() {
            return textBox4.Text;
        }
        public string getBusType() {
            return textBox6.Text;
        }
        public string getPayment() {
            return comboBox4.Text;
        }

private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {

                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {

                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
