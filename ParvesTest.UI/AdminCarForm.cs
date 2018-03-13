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
    public partial class AdminCarForm : Form
    {
        public AdminCarForm()
        {
            InitializeComponent();
        }

        private void AdminCarForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=HP;Initial Catalog=project01;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO CarInfo
                (Type, Name, Model, Colour, Available, Rent)
                VALUES     ('" + comboBox1.Text + "','" + textBox5.Text + "','" + textBox2.Text + "','" + textBox3.Text + "', '" + comboBox2.Text + "', '" + textBox4.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Insrt Successfuly by Admin...");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=HP;Initial Catalog=project01;Integrated Security=True");
            SqlDataAdapter _sda = new SqlDataAdapter("select * from CarInfo",con);
            DataTable dt = new DataTable();
            _sda.Fill(dt);
            dataGridView1.DataSource = dt;

            this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            textBox1.Text = row.Cells[0].Value.ToString();
            comboBox1.Text = row.Cells[1].Value.ToString();
            textBox5.Text = row.Cells[2].Value.ToString();
            textBox2.Text = row.Cells[3].Value.ToString();
            textBox3.Text = row.Cells[4].Value.ToString();
            comboBox2.Text = row.Cells[5].Value.ToString();
            textBox4.Text = row.Cells[6].Value.ToString();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=HP;Initial Catalog=project01;Integrated Security=True");
            SqlDataAdapter _sda = new SqlDataAdapter("UPDATE CarInfo SET Type='"+ comboBox1.Text+"',Name='"+textBox5.Text+"',Model='"+textBox2.Text+"',Colour='"+textBox3.Text+"',Available='"+comboBox2.Text+"',Rent='"+textBox4.Text+"' where Car_ID='"+textBox1.Text+"'",con);
            DataTable dt = new DataTable();
            _sda.Fill(dt);
            dataGridView1.DataSource = dt;

            MessageBox.Show("Update Successfuly by Admin...!");

            button1_Click(sender,e);

            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=HP;Initial Catalog=project01;Integrated Security=True");
            SqlDataAdapter _sda = new SqlDataAdapter("DELETE  from CarInfo where Car_ID ='"+textBox1.Text+"'", con);
            DataTable dt = new DataTable();
            _sda.Fill(dt);
            dataGridView1.DataSource = dt;

            MessageBox.Show("Delete Successfuly by Admin...!");

            button1_Click(sender, e);

            
        }

        private void te(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            comboBox1.Text = "";
            textBox5.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox2.Text = "";
            textBox4.Text = "";
        }

        private void buttonRe_Click(object sender, EventArgs e)
        {
            button1_Click(sender,e);
        }

        private void buttonBackAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
