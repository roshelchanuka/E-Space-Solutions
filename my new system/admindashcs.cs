using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace my_new_system
{
    public partial class admindashcs : Form
    {

        string conString =
@"Data Source=.\SQLEXPRESS;
Initial Catalog=MarsColonizationDB;
Integrated Security=True";


        private void LoadSummary()
        {
            try
            {
                DataTable dt = new DataTable();

                dt.Columns.Add("Category");
                dt.Columns.Add("Count");

                using (SqlConnection con =
                    new SqlConnection(conString))
                {
                    con.Open();

                    dt.Rows.Add("Total Colonists",
                        new SqlCommand(
                        "SELECT COUNT(*) FROM Colonist",
                        con).ExecuteScalar());

                    dt.Rows.Add("Total Dependents",
                        new SqlCommand(
                        "SELECT COUNT(*) FROM Dependent",
                        con).ExecuteScalar());

                    dt.Rows.Add("Total Houses",
                        new SqlCommand(
                        "SELECT COUNT(*) FROM House",
                        con).ExecuteScalar());

                    dt.Rows.Add("Total Pilots",
                        new SqlCommand(
                        "SELECT COUNT(*) FROM Pilot",
                        con).ExecuteScalar());

                    dt.Rows.Add("Total EJets",
                        new SqlCommand(
                        "SELECT COUNT(*) FROM EJet",
                        con).ExecuteScalar());

                    dt.Rows.Add("Total Trips",
                        new SqlCommand(
                        "SELECT COUNT(*) FROM Trip",
                        con).ExecuteScalar());

                    dt.Rows.Add("Total Jobs",
                        new SqlCommand(
                        "SELECT COUNT(*) FROM Job",
                        con).ExecuteScalar());
                }

                

                dataGridViewadmindas.AutoGenerateColumns = true;
                dataGridViewadmindas.Columns.Clear();
                dataGridViewadmindas.DataSource = null;
                dataGridViewadmindas.DataSource = dt;

                dataGridViewadmindas.AllowUserToAddRows = false;
                dataGridViewadmindas.ReadOnly = true;
            }
            catch (Exception ex)
            {
                
            }
        }

    
        public admindashcs()
        {
            InitializeComponent();
            LoadSummary();
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
