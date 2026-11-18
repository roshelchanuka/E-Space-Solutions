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
    public partial class adminoremp : Form
    {
        public adminoremp()
        {
            InitializeComponent();
        }

        private void buttonlogifadmin_Click(object sender, EventArgs e)
        {
            login login = new login();

            login.Show();
            this.Hide();
        }

        private void buttonlogifemp_Click(object sender, EventArgs e)
        {
            emplog emplog = new emplog();

            emplog.Show();
            this.Hide();
        }

        private void buttonlogback_Click(object sender, EventArgs e)
        {
            homepage homepage = new homepage();
            homepage.Show();

            this.Hide();
        }
    }
}
