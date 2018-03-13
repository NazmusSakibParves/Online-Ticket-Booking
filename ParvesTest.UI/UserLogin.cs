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
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';
            //textBoxPassword.MaxLength = 12;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonSignin_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text != "" && textBoxPassword.Text != "")
            {
                SqlConnection con = new SqlConnection("Data Source=HP;Initial Catalog=project01;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("Select Role from Signup WHERE User_Name ='" + textBoxUserName.Text + "' and Password ='" + textBoxPassword.Text + "' ", con);
                DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();

                    Home home = new Home(dt.Rows[0][0].ToString());
                    home.Show();
                }
                else {
                    MessageBox.Show("UserName or Password is Incorrect");
                }

                textBoxUserName.Clear();
                textBoxPassword.Clear();
            }
            else if (textBoxUserName.Text == "" && textBoxPassword.Text == "")
            {
                label7.Visible = true;
                label8.Visible = true;
            }



        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            System.Windows.Forms.Application.Exit();
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {

        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm signup = new SignUpForm();
            signup.Show();
        }
    }
}
