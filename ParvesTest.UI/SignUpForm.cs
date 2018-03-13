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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        SqlConnection conc = new SqlConnection("Data Source=HP;Initial Catalog=project01;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            //this.Close();

            textBox7.Clear();
            textBox1.Clear();
            textBox8.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            comboBox1.Text = "              Select a type";
            comboBox2.Text = "              Select";
        }

        private void buttonRigester_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=HP;Initial Catalog=project01;Integrated Security=True");
            con.Open();
            SqlCommand scmd = new SqlCommand(@"INSERT INTO Signup
                (First_Name, Last_Name, User_Name, Password, Email, Contact_No, National_ID, Address, Role, Gender)
                VALUES       ('" + textBox7.Text + "','" + textBox1.Text + "', '" + textBox8.Text + "', '" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "')", con);
            scmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Regitration Successfuly Done...!");

        }

        private void buttonbackhome_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

     
       private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) {

                e.Handled = true;
            }
            if((e.KeyChar=='.') && ((sender as TextBox).Text.IndexOf('.') > -1)){
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
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
