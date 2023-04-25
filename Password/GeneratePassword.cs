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
    public partial class GeneratePassword : Form
    {
        public PasswordGenerator passwordGenerator;

        public GeneratePassword()
        {
            InitializeComponent();

            passwordGenerator = new PasswordGenerator();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Decimal.ToInt32(num_Characters.Value));
            Console.WriteLine(box_Numbers.Checked);
            Console.WriteLine(box_Symbols.Checked);


            string password = passwordGenerator.GeneratePassword(Decimal.ToInt32(num_Characters.Value),box_Numbers.Checked,box_Symbols.Checked);
            
            textBox1.Text = password;
        }
    }
}
