using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ASM2.DB
{
    public partial class Login : Form
    {
        SqlConnection conn;
        public Login()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=LibraryManagement1;Integrated Security=True;");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to exit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string query = "select * from Accounts where username =@username and user_password =@password";

            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", SqlDbType.VarChar);
            cmd.Parameters["@username"].Value = username;
            cmd.Parameters.AddWithValue("@password", SqlDbType.VarChar);
            cmd.Parameters["@password"].Value = password;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string role = reader["user_role"].ToString();
                MessageBox.Show(this, "Login successful!", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Hide();
                AdminDashboard adminDashboard = new AdminDashboard(role);
                adminDashboard.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show(this, "Wrong username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
