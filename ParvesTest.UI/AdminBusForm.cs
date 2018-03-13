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
    public partial class AdminBusForm : Form
    {
        public AdminBusForm()
        {
            InitializeComponent();
        }

        private void AdminBusForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonBackAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=HP;Initial Catalog=project01;Integrated Security=True");
            SqlDataAdapter _sda = new SqlDataAdapter("select * from AvailableSeat", con);
            DataTable dt = new DataTable();
            _sda.Fill(dt);
            dataGridView1.DataSource = dt;

            this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=HP;Initial Catalog=project01;Integrated Security=True");
            SqlDataAdapter _sda = new SqlDataAdapter("DELETE  from AvailableSeat where SeatId ='" + textBox1.Text + "'", con);
            DataTable dt = new DataTable();
            _sda.Fill(dt);
            dataGridView1.DataSource = dt;

            MessageBox.Show("Delete Successfuly by Admin...!");
            buttonShow_Click(sender, e);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            textBox3.Text = "";
            comboBox2.Text = "";
            
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            buttonShow_Click(sender,e);
        }

    private void buttonInsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=HP;Initial Catalog=project01;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO AvailableSeat
                (SeatNo, Time, Ticket_Price, Type)
                VALUES     ('" + textBox2.Text + "','" + comboBox1.Text + "','" + textBox3.Text + "', '" + comboBox2.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Insrt Successfuly by Admin...");
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=HP;Initial Catalog=project01;Integrated Security=True");
            SqlDataAdapter _sda = new SqlDataAdapter("UPDATE AvailableSeat SET SeatNo ='" + textBox2.Text + "', Time ='" + comboBox1.Text + "', Ticket_Price ='" + textBox3.Text + "',Type ='" + comboBox2.Text + "' where SeatId='" + textBox1.Text + "'", con);
            DataTable dt = new DataTable();
            _sda.Fill(dt);
            dataGridView1.DataSource = dt;

            MessageBox.Show("Update Successfuly by Admin...!");
            buttonShow_Click(sender, e);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            comboBox1.Text = row.Cells[2].Value.ToString();
            textBox3.Text = row.Cells[3].Value.ToString();
            comboBox2.Text = row.Cells[4].Value.ToString();
        }
    }
}
