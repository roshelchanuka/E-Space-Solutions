using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace my_new_system
{
    public partial class job : Form
    {
        string conString =
        @"Data Source=.\SQLEXPRESS;
        Initial Catalog=MarsColonizationDB;
        Integrated Security=True";

        public job()
        {
            InitializeComponent();
            LoadJobs();
        }

        private void LoadJobs()
        {
            try
            {
                using (SqlConnection con =
                    new SqlConnection(conString))
                {
                    string query =
                    @"SELECT JobID,
                             JobName,
                             Description
                      FROM Job";

                    SqlDataAdapter da =
                        new SqlDataAdapter(query, con);

                    DataTable dt =
                        new DataTable();

                    da.Fill(dt);

                    dataGridViewjob.DataSource = null;
                    dataGridViewjob.DataSource = dt;

                    dataGridViewjob.AllowUserToAddRows = false;
                    dataGridViewjob.SelectionMode =
                        DataGridViewSelectionMode.FullRowSelect;

                    dataGridViewjob.MultiSelect = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttoninsertjob_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con =
                    new SqlConnection(conString))
                {
                    string query =
                    @"INSERT INTO Job
                    (
                        JobName,
                        Description
                    )
                    VALUES
                    (
                        @JobName,
                        @Description
                    )";

                    SqlCommand cmd =
                        new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue(
                        "@JobName",
                        texttype.Text);

                    cmd.Parameters.AddWithValue(
                        "@Description",
                        textDescription.Text);

                    con.Open();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Job Added Successfully");

                    LoadJobs();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonupdatejob_Click(object sender, EventArgs e)
        {
            try
            {
                if (textid.Text == "")
                {
                    MessageBox.Show("Please select a record first.");
                    return;
                }

                using (SqlConnection con =
                    new SqlConnection(conString))
                {
                    string query =
                    @"UPDATE Job
                      SET
                        JobName=@JobName,
                        Description=@Description
                      WHERE
                        JobID=@JobID";

                    SqlCommand cmd =
                        new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue(
                        "@JobID",
                        Convert.ToInt32(textid.Text));

                    cmd.Parameters.AddWithValue(
                        "@JobName",
                        texttype.Text);

                    cmd.Parameters.AddWithValue(
                        "@Description",
                        textDescription.Text);

                    con.Open();

                    int rows =
                        cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Job Updated Successfully");

                        LoadJobs();
                        ClearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttondeletejob_Click(object sender, EventArgs e)
        {
            try
            {
                if (textid.Text == "")
                {
                    MessageBox.Show("Please select a record first.");
                    return;
                }

                DialogResult result =
                    MessageBox.Show(
                    "Delete this Job?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection con =
                        new SqlConnection(conString))
                    {
                        string query =
                        @"DELETE FROM Job
                          WHERE JobID=@JobID";

                        SqlCommand cmd =
                            new SqlCommand(query, con);

                        cmd.Parameters.AddWithValue(
                            "@JobID",
                            Convert.ToInt32(textid.Text));

                        con.Open();

                        int rows =
                            cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show(
                                "Job Deleted Successfully");

                            LoadJobs();
                            ClearFields();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnviewjob_Click(object sender, EventArgs e)
        {
            if (dataGridViewjob.CurrentRow != null)
            {
                DataGridViewRow row =
                    dataGridViewjob.CurrentRow;

                textid.Text =
                    row.Cells[0].Value?.ToString() ?? "";

                texttype.Text =
                    row.Cells[1].Value?.ToString() ?? "";

                textDescription.Text =
                    row.Cells[2].Value?.ToString() ?? "";
            }
            else
            {
                MessageBox.Show("Please select a row.");
            }
        }

        private void ClearFields()
        {
            textid.Clear();
            texttype.Clear();
            textDescription.Clear();
        }
    }
}