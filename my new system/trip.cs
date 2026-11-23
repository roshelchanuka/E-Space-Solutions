using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace my_new_system
{
    public partial class trip : Form
    {
        string conString =
        @"Data Source=.\SQLEXPRESS;
        Initial Catalog=MarsColonizationDB;
        Integrated Security=True";

        public trip()
        {
            InitializeComponent();
            LoadTrips();
        }

        private void LoadTrips()
        {
            try
            {
                using (SqlConnection con =
                    new SqlConnection(conString))
                {
                    string query =
                    @"SELECT
                        TripID,
                        JetCode,
                        LaunchDate,
                        ReturnDate,
                        TripStatus
                      FROM Trip";

                    SqlDataAdapter da =
                        new SqlDataAdapter(query, con);

                    DataTable dt =
                        new DataTable();

                    da.Fill(dt);

                    dataGridViewtrip.DataSource = null;
                    dataGridViewtrip.DataSource = dt;

                    dataGridViewtrip.AllowUserToAddRows = false;
                    dataGridViewtrip.SelectionMode =
                        DataGridViewSelectionMode.FullRowSelect;

                    dataGridViewtrip.MultiSelect = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttoninserttrip_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con =
                    new SqlConnection(conString))
                {
                    string query =
                    @"INSERT INTO Trip
                    (
                        JetCode,
                        LaunchDate,
                        ReturnDate,
                        TripStatus
                    )
                    VALUES
                    (
                        @JetCode,
                        @LaunchDate,
                        @ReturnDate,
                        'Scheduled'
                    )";

                    SqlCommand cmd =
                        new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue(
                        "@JetCode",
                        textcode.Text);

                    cmd.Parameters.AddWithValue(
                        "@LaunchDate",
                        Convert.ToDateTime(textldate.Text));

                    cmd.Parameters.AddWithValue(
                        "@ReturnDate",
                        Convert.ToDateTime(textrdate.Text));

                    con.Open();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Trip Added Successfully");

                    LoadTrips();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonupdatetrip_Click(object sender, EventArgs e)
        {
            try
            {
                if (texttripid.Text == "")
                {
                    MessageBox.Show("Please select a record first.");
                    return;
                }

                using (SqlConnection con =
                    new SqlConnection(conString))
                {
                    string query =
                    @"UPDATE Trip
                      SET
                        JetCode=@JetCode,
                        LaunchDate=@LaunchDate,
                        ReturnDate=@ReturnDate
                      WHERE
                        TripID=@TripID";

                    SqlCommand cmd =
                        new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue(
                        "@TripID",
                        Convert.ToInt32(texttripid.Text));

                    cmd.Parameters.AddWithValue(
                        "@JetCode",
                        textcode.Text);

                    cmd.Parameters.AddWithValue(
                        "@LaunchDate",
                        Convert.ToDateTime(textldate.Text));

                    cmd.Parameters.AddWithValue(
                        "@ReturnDate",
                        Convert.ToDateTime(textrdate.Text));

                    con.Open();

                    int rows =
                        cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Trip Updated Successfully");

                        LoadTrips();
                        ClearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttondeletetrip_Click(object sender, EventArgs e)
        {
            try
            {
                if (texttripid.Text == "")
                {
                    MessageBox.Show("Please select a record first.");
                    return;
                }

                DialogResult result =
                    MessageBox.Show(
                    "Delete this trip?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection con =
                        new SqlConnection(conString))
                    {
                        string query =
                        @"DELETE FROM Trip
                          WHERE TripID=@TripID";

                        SqlCommand cmd =
                            new SqlCommand(query, con);

                        cmd.Parameters.AddWithValue(
                            "@TripID",
                            Convert.ToInt32(texttripid.Text));

                        con.Open();

                        int rows =
                            cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show(
                                "Trip Deleted Successfully");

                            LoadTrips();
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

        private void btnviewtrip_Click(object sender, EventArgs e)
        {
            if (dataGridViewtrip.CurrentRow != null)
            {
                DataGridViewRow row =
                    dataGridViewtrip.CurrentRow;

                texttripid.Text =
                    row.Cells[0].Value?.ToString() ?? "";

                textcode.Text =
                    row.Cells[1].Value?.ToString() ?? "";

                textldate.Text =
                    row.Cells[2].Value?.ToString() ?? "";

                textrdate.Text =
                    row.Cells[3].Value?.ToString() ?? "";
            }
            else
            {
                MessageBox.Show("Please select a row.");
            }
        }

        private void ClearFields()
        {
            texttripid.Clear();
            textcode.Clear();
            textldate.Clear();
            textrdate.Clear();
        }
    }
}