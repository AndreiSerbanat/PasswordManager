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
using System.Configuration;

namespace Password
{
    public partial class addPasswordForm : Form
    {
        public addPasswordForm()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PasswordManager;Integrated Security=True"; 
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand("INSERT INTO Pass (Website, Username, Password) VALUES (@Website, @Username, @Password)", connection);
            command.Parameters.AddWithValue("@Website", txt_WebSite.Text);
            command.Parameters.AddWithValue("@Username", txt_Username.Text);
            command.Parameters.AddWithValue("@Password", txt_Password.Text);
            command.ExecuteNonQuery();

            connection.Close();

            MessageBox.Show("Password added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
