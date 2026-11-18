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
    public partial class house : Form
    {
        public house()
        {
            InitializeComponent();
        }


        string conString =
                        @"Data Source=.\SQLEXPRESS;
                Initial Catalog=MarsColonizationDB;
                   Integrated Security=True";

        private void LoadHouses()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string query = @"
            SELECT
            LotNumber,
            NoOfRooms,
            SquareFeet,
            Status
            FROM House";

                    SqlDataAdapter da =
                        new SqlDataAdapter(query, con);

                    DataTable dt =
                        new DataTable();

                    da.Fill(dt);

                    dataGridViewhouse.DataSource = null;
                    dataGridViewhouse.DataSource = dt;

                    dataGridViewhouse.AllowUserToAddRows = false;
                    dataGridViewhouse.SelectionMode =
                        DataGridViewSelectionMode.FullRowSelect;

                    dataGridViewhouse.MultiSelect = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void house_Load(object sender, EventArgs e)
        {
            LoadHouses();
        }




        private void buttoninsert_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con =
                    new SqlConnection(conString))
                {
                    string query = @"
            INSERT INTO House
            (
                LotNumber,
                NoOfRooms,
                SquareFeet,
                Status
            )
            VALUES
            (
                @LotNumber,
                @NoOfRooms,
                @SquareFeet,
                'Available'
            )";

                    SqlCommand cmd =
                        new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue(
                        "@LotNumber",
                        textBoxlot.Text);

                    cmd.Parameters.AddWithValue(
                        "@NoOfRooms",
                        Convert.ToInt32(textBoxmembers.Text));

                    cmd.Parameters.AddWithValue(
                        "@SquareFeet",
                        Convert.ToDecimal(textBoxfeet.Text));

                    con.Open();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("House Added Successfully");

                    LoadHouses();

                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonup_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxlot.Text == "")
                {
                    MessageBox.Show("Please select a record first.");
                    return;
                }

                using (SqlConnection con =
                    new SqlConnection(conString))
                {
                    string query = @"
            UPDATE House
            SET
                NoOfRooms = @NoOfRooms,
                SquareFeet = @SquareFeet
            WHERE
                LotNumber = @LotNumber";

                    SqlCommand cmd =
                        new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue(
                        "@LotNumber",
                        textBoxlot.Text);

                    cmd.Parameters.AddWithValue(
                        "@NoOfRooms",
                        Convert.ToInt32(textBoxmembers.Text));

                    cmd.Parameters.AddWithValue(
                        "@SquareFeet",
                        Convert.ToDecimal(textBoxfeet.Text));

                    con.Open();

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("House Updated Successfully");

                        LoadHouses();

                        ClearFields();
                    }
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
                if (textBoxlot.Text == "")
                {
                    MessageBox.Show("Please select a record first.");
                    return;
                }

                DialogResult result =
                    MessageBox.Show(
                    "Are you sure?",
                    "Delete House",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection con =
                        new SqlConnection(conString))
                    {
                        string query =
                        @"DELETE FROM House
                  WHERE LotNumber=@LotNumber";

                        SqlCommand cmd =
                            new SqlCommand(query, con);

                        cmd.Parameters.AddWithValue(
                            "@LotNumber",
                            textBoxlot.Text);

                        con.Open();

                        int rows =
                            cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("House Deleted");

                            LoadHouses();

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

        private void btnviewhouse_Click(object sender, EventArgs e)
        {
            if (dataGridViewhouse.CurrentRow != null)
            {
                DataGridViewRow row =
                    dataGridViewhouse.CurrentRow;

                textBoxlot.Text =
                    row.Cells[0].Value?.ToString() ?? "";

                textBoxmembers.Text =
                    row.Cells[1].Value?.ToString() ?? "";

                textBoxfeet.Text =
                    row.Cells[2].Value?.ToString() ?? "";
            }
            else
            {
                MessageBox.Show("Please select a row.");
            }
        }


        private void ClearFields()
        {
            textBoxlot.Clear();
            textBoxmembers.Clear();
            textBoxfeet.Clear();
        }
    }
}
