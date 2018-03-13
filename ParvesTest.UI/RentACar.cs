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
    public partial class RentACar : Form
    {
        public RentACar()
        {
            InitializeComponent();
        }

        SqlConnection conc = new SqlConnection("Data Source=HP;Initial Catalog=project01;Integrated Security=True");
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select * From CarInfo Where Type='MicroBUS'", conc);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                button1_Click(sender, e);
            }
            else
            {
                // dataGridView1.Rows.Clear();
                dataGridView1.DataSource = null;
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select * From CarInfo Where Type='CAR'", conc);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                button1_Click(sender, e);
            }
            else
            {
                //dataGridView1.Rows.Clear();
                dataGridView1.DataSource = null;
            }
            
        }

        private void RentACar_Load(object sender, EventArgs e)
        {

        }

        private void BackHomeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Clear();
            textBox3.Clear();
            textBox7.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            dateTimePicker1.Value = DateTime.Now;
            

        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox7.Text != "" && textBox4.Text != "")
            {
                SqlConnection con = new SqlConnection(@"Data Source=HP;Initial Catalog=project01;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO CarRentCustomerInfo
                (Customer_ID, Customer_Name, Customer_Contact_No, Car_Name, Car_ID, Rent_Date, Submission_Time, Price)
                VALUES     ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox7.Text + "', '" + textBox4.Text + "','" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "','" + textBox5.Text + "','" + textBox6.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                SqlDataAdapter ad = new SqlDataAdapter("Delete from CarInfo where Car_ID ='" + textBox4.Text + "'", con);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;

                MessageBox.Show("Booking Successfuly...");

            }
            else {
                MessageBox.Show("Fill the all Field.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SqlConnection con = new SqlConnection(@"Data Source=HP;Initial Catalog=project01;Integrated Security=True");

                SqlDataAdapter sda = new SqlDataAdapter(@"Select * from CarRentCustomerInfo WHERE (Customer_ID = '" + textBox1.Text + "')", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                textBox1.Text = dt.Rows[0]["Customer_ID"].ToString();
                textBox2.Text = dt.Rows[0]["Customer_Name"].ToString();
                textBox3.Text = dt.Rows[0]["Customer_Contact_No"].ToString();
                textBox4.Text = dt.Rows[0]["Car_ID"].ToString();
                dateTimePicker1.Text = dt.Rows[0]["Rent_Date"].ToString();
                textBox5.Text = dt.Rows[0]["Submission_Time"].ToString();


            }
        }

        private void TokenPrintButton_Click(object sender, EventArgs e)
        {
            CarToken token = new CarToken(this);
            token.Show();
        }

        public string getCustomerName()
        {
            return textBox2.Text;
        }
        public string getCustomerPhoneNo()
        {
            return textBox3.Text;
        }
        public string getCarName()
        {
            return textBox7.Text;
        }
        public string getCarId()
        {
            return textBox4.Text;
        }
        public string getDateRent()
        {
            return dateTimePicker1.Text;
        }
        public string getPrice()
        {
            return textBox6.Text;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            textBox4.Text = row.Cells[0].Value.ToString();
            textBox7.Text = row.Cells[2].Value.ToString();
            textBox6.Text = row.Cells[6].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SqlConnection con = new SqlConnection(@"Data Source=HP;Initial Catalog=project01;Integrated Security=True");
                SqlDataAdapter _sda = new SqlDataAdapter("Select * from CarInfo where Type='CAR'", con);
                DataTable dt = new DataTable();
                _sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if(checkBox2.Checked)
            {
                SqlConnection con = new SqlConnection(@"Data Source=HP;Initial Catalog=project01;Integrated Security=True");
                SqlDataAdapter _sda = new SqlDataAdapter("Select * from CarInfo where Type='MicroBus'", con);
                DataTable dt = new DataTable();
                _sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {
               // dataGridView1.Rows.Clear();
                dataGridView1.DataSource = null;
            }
           
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox3_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }
    }
}
