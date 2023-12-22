using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Models;
using Controllers;
namespace Project_Management_System
{
    public partial class LoginPage : Form
    {
        
        public LoginPage()
        {
            InitializeComponent();
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            //this.Close();
            this.Hide();
            RegisterPage signUp = new RegisterPage();
            signUp.Show();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            txt_username.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home hm = new Home();
            hm.Show();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            AuthenticationProcedure ap = new AuthenticationProcedure();
            if (string.IsNullOrEmpty(txt_username.Text)|| string.IsNullOrEmpty(txt_password.Text) )
            
                {

                MessageBox.Show(" Please Enter Username and Password");

                }
            else if(txt_username.Text == "admin" && txt_password.Text == "admin" )
                {
                

                this.Hide();
                AdminDashboard rg = new AdminDashboard();
                rg.Show();



            }

            else if (txt_username.Text == "faculty" && txt_password.Text == "faculty")
            {

                this.Hide();
                FacultyDashboard rg = new FacultyDashboard();
                rg.Show();


            }

            else if(ap.authenticationCheck(txt_username.Text,txt_password.Text))
            {

                

                this.Hide();
                StudentDeshBoard sdb = new StudentDeshBoard(txt_username.Text);
                sdb.Show();

                /*
                

                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\repos\PMSDB.mdf;Integrated Security=True;Connect Timeout=30");
                int rows = 0;
                string uName = txt_username.Text;
                string uPassword = txt_password.Text;
                conn.Open();
                string querry = "select * from authenticate where username ='" + uName + "' and password = '" + uPassword + "'";
                SqlCommand cmd = new SqlCommand(querry, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                conn.Close();
                rows = dt.Rows.Count;
                if (rows > 0)
                {
                    this.Hide();
                    StudentDeshBoard rg = new StudentDeshBoard();
                    rg.Show();
                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_username.Clear();
                    txt_password.Clear();
                    txt_username.Focus();
                }*/





            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
