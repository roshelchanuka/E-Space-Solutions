using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_new_system
{
    public partial class pilot : Form
    {

        string conString =
@"Data Source=.\SQLEXPRESS;
Initial Catalog=MarsColonizationDB;
Integrated Security=True";

        private void LoadPilots()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string query = @"
            SELECT
            PilotID,
            FirstName,
            SpaceHours
            FROM Pilot";

                    SqlDataAdapter da =
                        new SqlDataAdapter(query, con);

                    DataTable dt =
                        new DataTable();

                    da.Fill(dt);

                    dataGridViewpilot.DataSource = null;
                    dataGridViewpilot.DataSource = dt;

                    dataGridViewpilot.AllowUserToAddRows = false;
                    dataGridViewpilot.SelectionMode =
                        DataGridViewSelectionMode.FullRowSelect;

                    dataGridViewpilot.MultiSelect = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pilot_Load(object sender, EventArgs e)
        {
            LoadPilots();
        }


        public pilot()
        {
            InitializeComponent();
        }

        private void buttonupdatepilot_Click(object sender, EventArgs e)
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
                    string query = @"
            UPDATE Pilot
            SET
                FirstName = @FirstName,
                SpaceHours = @SpaceHours
            WHERE PilotID = @PilotID";

                    SqlCommand cmd =
                        new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue(
                        "@PilotID",
                        Convert.ToInt32(textid.Text));

                    cmd.Parameters.AddWithValue(
                        "@FirstName",
                        textname.Text);

                    cmd.Parameters.AddWithValue(
                        "@SpaceHours",
                        Convert.ToInt32(texthours.Text));

                    con.Open();

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Pilot Updated Successfully");

                        LoadPilots();

                        ClearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            if (dataGridViewpilot.CurrentRow != null)
            {
                DataGridViewRow row =
                    dataGridViewpilot.CurrentRow;

                textid.Text =
                    row.Cells[0].Value?.ToString() ?? "";

                textname.Text =
                    row.Cells[1].Value?.ToString() ?? "";

                texthours.Text =
                    row.Cells[2].Value?.ToString() ?? "";
            }
            else
            {
                MessageBox.Show("Please select a row.");
            }
        }

        private void buttoninsertpilot_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con =
                    new SqlConnection(conString))
                {
                    string query = @"
            INSERT INTO Pilot
            (
                FirstName,
                LastName,
                Designation,
                SpaceHours,
                ContactNo
            )
            VALUES
            (
                @FirstName,
                '',
                '',
                @SpaceHours,
                ''
            )";

                    SqlCommand cmd =
                        new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue(
                        "@FirstName",
                        textname.Text);

                    cmd.Parameters.AddWithValue(
                        "@SpaceHours",
                        Convert.ToInt32(texthours.Text));

                    con.Open();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Pilot Added Successfully");

                    LoadPilots();

                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttondeletepilot_Click(object sender, EventArgs e)
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
                    "Are you sure?",
                    "Delete Pilot",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection con =
                        new SqlConnection(conString))
                    {
                        string query =
                        @"DELETE FROM Pilot
                  WHERE PilotID=@PilotID";

                        SqlCommand cmd =
                            new SqlCommand(query, con);

                        cmd.Parameters.AddWithValue(
                            "@PilotID",
                            Convert.ToInt32(textid.Text));

                        con.Open();

                        int rows =
                            cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Pilot Deleted");

                            LoadPilots();

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

        private void ClearFields()
        {
            textid.Clear();
            textname.Clear();
            texthours.Clear();
        }

        private void buttonbackpilot_Click(object sender, EventArgs e)
        {
            dashbord dash = new dashbord();
            dash.Show();
            this.Hide();
        }
    }
}
