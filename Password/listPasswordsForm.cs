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

namespace Password
{
    public partial class listPasswordsForm : Form
    {
        public listPasswordsForm()
        {
            InitializeComponent();
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PasswordManager;Integrated Security=True";
            string query = "SELECT * FROM Pass";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader.GetString(1)); // Username
                            item.SubItems.Add(reader.GetString(2)); // Password
                            item.SubItems.Add(reader.GetString(3)); // Website
                            listView1.Items.Add(item);
                        }
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
