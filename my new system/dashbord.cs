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
    public partial class dashbord : Form
    {
        public dashbord()
        {
            InitializeComponent();
        }

        private void buttondasback_Click(object sender, EventArgs e)
        {
            homepage homepage = new homepage();
            homepage.Show();

            this.Close();
        }

        private void buttoncolo_Click(object sender, EventArgs e)
        {
            colo colo = new colo();
            colo.Show();

            this.Close();

          
        }

        private void buttonejet_Click(object sender, EventArgs e)
        {
            ejet ejet = new ejet();
            ejet.Show();    

            this.Close();
        }

        private void buttontrip_Click(object sender, EventArgs e)
        {
            trip trip = new trip();
            trip.Show();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            jet_type jet_Type = new jet_type();
            jet_Type.Show();

            this.Close();
        }

        private void buttonpilot_Click(object sender, EventArgs e)
        {
            pilot pilot = new pilot();  
            pilot.Show();

            this.Close();
        }

        private void buttondep_Click(object sender, EventArgs e)
        {
            dependent dependent = new dependent();
            dependent.Show();

            this.Close();
        }

        private void buttonhouse_Click(object sender, EventArgs e)
        {
            house house = new house();
            house.Show();

            this.Close();
        }

        private void buttonjob_Click(object sender, EventArgs e)
        {
            job job = new job();
            job.Show();

            this.Close();
        }
    }
}
