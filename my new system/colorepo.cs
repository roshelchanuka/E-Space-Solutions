using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace my_new_system
{
    public partial class colorepo : Form
    {
        string conString =
        @"Data Source=.\SQLEXPRESS;
        Initial Catalog=MarsColonizationDB;
        Integrated Security=True";

        public colorepo()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnviewcolorepo_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con =
                    new SqlConnection(conString))
                {
                    string query =
                    @"SELECT
                        ColonistID,
                        FirstName,
                        MiddleName,
                        Surname,
                        DOB,
                        Gender,
                        Qualification,
                        ContactNo,
                        CivilStatus
                      FROM Colonist";

                    SqlDataAdapter da =
                        new SqlDataAdapter(query, con);

                    DataTable dt =
                        new DataTable();

                    da.Fill(dt);

                    dataGridViewcolorepo.DataSource = null;
                    dataGridViewcolorepo.DataSource = dt;

                    dataGridViewcolorepo.AllowUserToAddRows = false;
                    dataGridViewcolorepo.SelectionMode =
                        DataGridViewSelectionMode.FullRowSelect;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnexpocolorepo_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewcolorepo.Rows.Count == 0)
                {
                    MessageBox.Show("No data available to export.");
                    return;
                }

                SaveFileDialog sfd =
                    new SaveFileDialog();

                sfd.Filter = "CSV File (*.csv)|*.csv";
                sfd.FileName = "ColonistReport.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw =
                        new StreamWriter(sfd.FileName))
                    {
                        for (int i = 0; i < dataGridViewcolorepo.Columns.Count; i++)
                        {
                            sw.Write(dataGridViewcolorepo.Columns[i].HeaderText);

                            if (i < dataGridViewcolorepo.Columns.Count - 1)
                            {
                                sw.Write(",");
                            }
                        }

                        sw.WriteLine();

                        foreach (DataGridViewRow row in dataGridViewcolorepo.Rows)
                        {
                            for (int i = 0; i < dataGridViewcolorepo.Columns.Count; i++)
                            {
                                sw.Write(row.Cells[i].Value);

                                if (i < dataGridViewcolorepo.Columns.Count - 1)
                                {
                                    sw.Write(",");
                                }
                            }

                            sw.WriteLine();
                        }
                    }

                    MessageBox.Show(
                        "Colonist Report Exported Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}