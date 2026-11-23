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
    public partial class jet_type : Form
    {


        string conString =
@"Data Source=.\SQLEXPRESS;
Initial Catalog=MarsColonizationDB;
Integrated Security=True";


        private void LoadJetTypes()
        {
            try
            {
                using (SqlConnection con =
                    new SqlConnection(conString))
                {
                    string query = @"
            SELECT
            TypeID,
            JetID,
            Cost,
            Description
            FROM JetType";

                    SqlDataAdapter da =
                        new SqlDataAdapter(query, con);

                    DataTable dt =
                        new DataTable();

                    da.Fill(dt);

                    dataGridViewjettype.DataSource = null;
                    dataGridViewjettype.DataSource = dt;

                    dataGridViewjettype.AllowUserToAddRows = false;
                    dataGridViewjettype.SelectionMode =
                        DataGridViewSelectionMode.FullRowSelect;

                    dataGridViewjettype.MultiSelect = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public jet_type()
        {
            InitializeComponent();
        }

        private void jet_type_Load(object sender, EventArgs e)
        {
            LoadJetTypes();
        }

        private void buttoninserttype_Click(object sender, EventArgs e)
        {

            decimal cost;

            if (!decimal.TryParse(textcost.Text, out cost))
            {
                MessageBox.Show("Please enter a valid Cost.");
                return;
            }

            if (textjetid.Text == "")
            {
                MessageBox.Show("Please enter Jet ID.");
                return;
            }

            try
            {
                using (SqlConnection con =
                    new SqlConnection(conString))
                {
                    string query = @"
            INSERT INTO JetType
            (
                JetID,
                Cost,
                Description
            )
            VALUES
            (
                @JetID,
                @Cost,
                @Description
            )";

                    SqlCommand cmd =
                        new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue(
                        "@JetID",
                        textjetid.Text);

                    cmd.Parameters.AddWithValue(
                        "@Cost",
                        Convert.ToDecimal(textcost.Text));

                    cmd.Parameters.AddWithValue(
                        "@Description",
                        textDesripition.Text);

                    con.Open();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Jet Type Added");

                    LoadJetTypes();

                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonbacktype_Click(object sender, EventArgs e)
        {
            dashbord dashbord = new dashbord();
            dashbord.Show();
            this.Hide();
        }

        private void buttonupdatetype_Click(object sender, EventArgs e)
        {
            try
            {
                if (texttypeid.Text == "")
                {
                    MessageBox.Show("Select a record first");
                    return;
                }

                using (SqlConnection con =
                    new SqlConnection(conString))
                {
                    string query = @"
            UPDATE JetType
            SET
                JetID=@JetID,
                Cost=@Cost,
                Description=@Description
            WHERE
                TypeID=@TypeID";

                    SqlCommand cmd =
                        new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue(
                        "@TypeID",
                        Convert.ToInt32(texttypeid.Text));

                    cmd.Parameters.AddWithValue(
                        "@JetID",
                        textjetid.Text);

                    cmd.Parameters.AddWithValue(
                        "@Cost",
                        Convert.ToDecimal(textcost.Text));

                    cmd.Parameters.AddWithValue(
                        "@Description",
                        textDesripition.Text);

                    con.Open();

                    int rows =
                        cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Updated Successfully");

                        LoadJetTypes();

                        ClearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttondeletetype_Click(object sender, EventArgs e)
        {
            try
            {
                if (texttypeid.Text == "")
                {
                    MessageBox.Show("Select a record first");
                    return;
                }

                DialogResult result =
                    MessageBox.Show(
                    "Delete this record?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection con =
                        new SqlConnection(conString))
                    {
                        string query =
                        @"DELETE FROM JetType
                  WHERE TypeID=@TypeID";

                        SqlCommand cmd =
                            new SqlCommand(query, con);

                        cmd.Parameters.AddWithValue(
                            "@TypeID",
                            Convert.ToInt32(texttypeid.Text));

                        con.Open();

                        int rows =
                            cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Deleted");

                            LoadJetTypes();

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

        private void btnviewjettype_Click(object sender, EventArgs e)
        {
            if (dataGridViewjettype.CurrentRow != null)
            {
                DataGridViewRow row =
                    dataGridViewjettype.CurrentRow;

                texttypeid.Text =
                    row.Cells[0].Value?.ToString() ?? "";

                textjetid.Text =
                    row.Cells[1].Value?.ToString() ?? "";

                textcost.Text =
                    row.Cells[2].Value?.ToString() ?? "";

                textDesripition.Text =
                    row.Cells[3].Value?.ToString() ?? "";
            }
        }


        private void ClearFields()
        {
            texttypeid.Clear();
            textjetid.Clear();
            textcost.Clear();
            textDesripition.Clear();
        }

        private void btnviewjettype_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewjettype.CurrentRow != null)
            {
                DataGridViewRow row =
                    dataGridViewjettype.CurrentRow;

                texttypeid.Text =
                    row.Cells[0].Value?.ToString() ?? "";

                textjetid.Text =
                    row.Cells[1].Value?.ToString() ?? "";

                textcost.Text =
                    row.Cells[2].Value?.ToString() ?? "";

                textDesripition.Text =
                    row.Cells[3].Value?.ToString() ?? "";
            }
        }
    }
}
