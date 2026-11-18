using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_new_system
{
    public partial class emplog : Form
    {
        public emplog()
        {
            InitializeComponent();
        }

        private void buttonlogemp_Click(object sender, EventArgs e)
        {
            string username = textusernameemp.Text.Trim();
            string password = textpassemp.Text.Trim();


            if (username == "employee" && password == "abcd")
            {

                this.Hide();

                dashbord dashbord = new dashbord();
                dashbord.Show();
            }
            else
            {

                MessageBox.Show("Error: Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonlogbackemp_Click(object sender, EventArgs e)
        {
            homepage homepage = new homepage();
            homepage.Show();

            this.Close();
        }
    }
}

        