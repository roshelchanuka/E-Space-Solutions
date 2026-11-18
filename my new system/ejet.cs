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
    public partial class ejet : Form
    {

        string conString =
@"Data Source=.\SQLEXPRESS;
Initial Catalog=MarsColonizationDB;
Integrated Security=True";

        public ejet()
        {
            InitializeComponent();
            LoadJets();
        }


        private void LoadJets()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string query = @"
            SELECT
            JetCode,
            PassengerSeats,
            NuclearPower,
            MadeYear,
            Weight,
            PowerSource
            FROM EJet";

                    SqlDataAdapter da =
                        new SqlDataAdapter(query, con);

                    DataTable dt =
                        new DataTable();

                    da.Fill(dt);

                    dataGridViewejet.DataSource = null;
                    dataGridViewejet.DataSource = dt;

                    dataGridViewejet.AllowUserToAddRows = false;
                    dataGridViewejet.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                    dataGridViewejet.MultiSelect = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void labelEnginpower_Click(object sender, EventArgs e)
        {

        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxjetid.Text == "")
                {
                    MessageBox.Show("Please select a record first.");
                    return;
                }

                using (SqlConnection con =
                    new SqlConnection(conString))
                {
                    string query = @"
            UPDATE EJet
            SET
                PassengerSeats=@PassengerSeats,
                NuclearPower=@NuclearPower,
                MadeYear=@MadeYear,
                Weight=@Weight,
                PowerSource=@PowerSource
            WHERE
                JetCode=@JetCode";

                    SqlCommand cmd =
                        new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue(
                        "@JetCode",
                        textBoxjetid.Text);

                    cmd.Parameters.AddWithValue(
                        "@PassengerSeats",
                        Convert.ToInt32(textSeats.Text));

                    cmd.Parameters.AddWithValue(
                        "@NuclearPower",
                        Convert.ToDecimal(textEnginpower.Text));

                    cmd.Parameters.AddWithValue(
                        "@MadeYear",
                        Convert.ToInt32(textYear.Text));

                    cmd.Parameters.AddWithValue(
                        "@Weight",
                        Convert.ToDecimal(textWeight.Text));

                    cmd.Parameters.AddWithValue(
                        "@PowerSource",
                        textPower.Text);

                    con.Open();

                    int rows =
                        cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("E-Jet Updated Successfully");

                        LoadJets();

                        ClearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttoninsert_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con =
                    new SqlConnection(conString))
                {
                    string query = @"
            INSERT INTO EJet
            (
                JetCode,
                PassengerSeats,
                NuclearPower,
                MadeYear,
                Weight,
                PowerSource,
                JetType
            )
            VALUES
            (
                @JetCode,
                @PassengerSeats,
                @NuclearPower,
                @MadeYear,
                @Weight,
                @PowerSource,
                'Nuclear'
            )";

                    SqlCommand cmd =
                        new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue(
                        "@JetCode",
                        textBoxjetid.Text);

                    cmd.Parameters.AddWithValue(
                        "@PassengerSeats",
                        Convert.ToInt32(textSeats.Text));

                    cmd.Parameters.AddWithValue(
                        "@NuclearPower",
                        Convert.ToDecimal(textEnginpower.Text));

                    cmd.Parameters.AddWithValue(
                        "@MadeYear",
                        Convert.ToInt32(textYear.Text));

                    cmd.Parameters.AddWithValue(
                        "@Weight",
                        Convert.ToDecimal(textWeight.Text));

                    cmd.Parameters.AddWithValue(
                        "@PowerSource",
                        textPower.Text);

                    con.Open();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("E-Jet Added Successfully");

                    LoadJets();

                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxjetid.Text == "")
                {
                    MessageBox.Show("Please select a record first.");
                    return;
                }

                DialogResult result =
                    MessageBox.Show(
                    "Are you sure?",
                    "Delete EJet",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection con =
                        new SqlConnection(conString))
                    {
                        string query =
                        @"DELETE FROM EJet
                  WHERE JetCode=@JetCode";

                        SqlCommand cmd =
                            new SqlCommand(query, con);

                        cmd.Parameters.AddWithValue(
                            "@JetCode",
                            textBoxjetid.Text);

                        con.Open();

                        int rows =
                            cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("E-Jet Deleted");

                            LoadJets();

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

        private void btnviewejet_Click(object sender, EventArgs e)
        {
            if (dataGridViewejet.CurrentRow != null)
            {
                DataGridViewRow row =
                    dataGridViewejet.CurrentRow;

                textBoxjetid.Text =
                    row.Cells[0].Value?.ToString() ?? "";

                textSeats.Text =
                    row.Cells[1].Value?.ToString() ?? "";

                textEnginpower.Text =
                    row.Cells[2].Value?.ToString() ?? "";

                textYear.Text =
                    row.Cells[3].Value?.ToString() ?? "";

                textWeight.Text =
                    row.Cells[4].Value?.ToString() ?? "";

                textPower.Text =
                    row.Cells[5].Value?.ToString() ?? "";
            }
            else
            {
                MessageBox.Show("Please select a row.");
            }
        }

        private void ClearFields()
        {
            textBoxjetid.Clear();
            textPower.Clear();
            textSeats.Clear();
            textEnginpower.Clear();
            textYear.Clear();
            textWeight.Clear();
        }
    }
}
