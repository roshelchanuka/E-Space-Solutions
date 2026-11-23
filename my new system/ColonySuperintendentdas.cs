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
    public partial class ColonySuperintendentdas : Form
    {
        public ColonySuperintendentdas()
        {
            InitializeComponent();
        }

        private void btncolorepo_Click(object sender, EventArgs e)
        {
            colorepo colo = new colorepo();
            colo.Show();
            this.Hide();
        }
    }
}
