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
using System.IO;

namespace my_new_system
{
    public partial class report : Form
    {


        string conString =
@"Data Source=.\SQLEXPRESS;
Initial Catalog=MarsColonizationDB;
Integrated Security=True";


        public report()
        {
            InitializeComponent();
        }


        private void report_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Colonist Report");
            comboBox1.Items.Add("Dependent Report");
            comboBox1.Items.Add("House Report");
            comboBox1.Items.Add("Pilot Report");
            comboBox1.Items.Add("E-Jet Report");
            comboBox1.Items.Add("Trip Report");
            comboBox1.Items.Add("Job Report");
        }

        private void btnadminrepo_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "";

                switch (comboBox1.Text)
                {
                    case "Colonist Report":
                        query = @"SELECT * FROM Colonist";
                        break;

                    case "Dependent Report":
                        query = @"SELECT * FROM Dependent";
                        break;

                    case "House Report":
                        query = @"SELECT * FROM House";
                        break;

                    case "Pilot Report":
                        query = @"SELECT * FROM Pilot";
                        break;

                    case "E-Jet Report":
                        query = @"SELECT * FROM EJet";
                        break;

                    case "Trip Report":
                        query = @"SELECT * FROM Trip";
                        break;

                    case "Job Report":
                        query = @"SELECT * FROM Job";
                        break;

                    default:
                        MessageBox.Show("Please select a report.");
                        return;
                }

                using (SqlConnection con =
                    new SqlConnection(conString))
                {
                    SqlDataAdapter da =
                        new SqlDataAdapter(query, con);

                    DataTable dt =
                        new DataTable();

                    da.Fill(dt);

                    dataGridViewreport.DataSource = null;
                    dataGridViewreport.DataSource = dt;

                    dataGridViewreport.AllowUserToAddRows = false;
                    dataGridViewreport.SelectionMode =
                        DataGridViewSelectionMode.FullRowSelect;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnexporepo_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewreport.Rows.Count == 0)
                {
                    MessageBox.Show("No data available.");
                    return;
                }

                SaveFileDialog sfd =
                    new SaveFileDialog();

                sfd.Filter =
                    "CSV File (*.csv)|*.csv";

                sfd.FileName =
                    comboBox1.Text.Replace(" ", "_") + ".csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw =
                        new StreamWriter(sfd.FileName))
                    {
                        // Column Headers
                        for (int i = 0;
                             i < dataGridViewreport.Columns.Count;
                             i++)
                        {
                            sw.Write(
                                dataGridViewreport.Columns[i].HeaderText);

                            if (i <
                                dataGridViewreport.Columns.Count - 1)
                            {
                                sw.Write(",");
                            }
                        }

                        sw.WriteLine();

                        // Data Rows
                        foreach (DataGridViewRow row
                                 in dataGridViewreport.Rows)
                        {
                            for (int i = 0;
                                 i < dataGridViewreport.Columns.Count;
                                 i++)
                            {
                                sw.Write(row.Cells[i].Value);

                                if (i <
                                    dataGridViewreport.Columns.Count - 1)
                                {
                                    sw.Write(",");
                                }
                            }

                            sw.WriteLine();
                        }
                    }

                    MessageBox.Show(
                        "Report Exported Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnbarepo_Click(object sender, EventArgs e)
        {
            admindashcs admindashcs = new admindashcs(); 
            admindashcs.Show();

            this.Hide();
        }
    }
}
