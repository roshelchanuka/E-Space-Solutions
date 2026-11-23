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
    public partial class admindashcs : Form
    {
        public admindashcs()
        {
            InitializeComponent();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Are you sure you want to log out?",
        "Logout",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                homepage homepage = new homepage();
                homepage.Show();

                this.Hide(); // Current form hide 
            }
        }

        private void btnreporadmin_Click(object sender, EventArgs e)
        {
            report report = new report();
            report.Show();

            this.Hide();
        }

        private void dataGridViewadmindas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
