using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            addPasswordForm addPasswordForm = new addPasswordForm();
            addPasswordForm.Show();
        }

        private void btn_List_Click(object sender, EventArgs e)
        {
            listPasswordsForm listPasswordsForm = new listPasswordsForm();
            listPasswordsForm.Show();
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            GeneratePassword generatePassword = new GeneratePassword();
            generatePassword.Show();
        }
    }
}
