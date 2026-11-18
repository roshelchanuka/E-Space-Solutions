using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace my_new_system
{
    public partial class dependent : Form
    {
        string conString =
        @"Data Source=.\SQLEXPRESS;
        Initial Catalog=MarsColonizationDB;
        Integrated Security=True";

        public dependent()
        {
            InitializeComponent();
            LoadDependents();
        }

        private void dependent_Load(object sender, EventArgs e)
        {
            LoadDependents();
        }

        private void LoadDependents()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string query = "SELECT * FROM Dependent";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                

                    dataGridViewdep.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttoninsertdep_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con =
                    new SqlConnection(conString))
                {
                    string query = @"
                    INSERT INTO Dependent
                    (
                        ColonistID,
                        FullName,
                        DOB,
                        Gender,
                        Relationship
                    )
                    VALUES
                    (
                        @ColonistID,
                        @FullName,
                        @DOB,
                        @Gender,
                        @Relationship
                    )";

                    SqlCommand cmd =
                        new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue(
                        "@ColonistID",
                        Convert.ToInt32(textBoxColonistID.Text));

                    cmd.Parameters.AddWithValue(
                        "@FullName",
                        textBoxName.Text);

                    cmd.Parameters.AddWithValue(
                        "@DOB",
                        DateTime.Now.AddYears(
                        -Convert.ToInt32(textBoxAge.Text)));

                    cmd.Parameters.AddWithValue(
                        "@Gender",
                        textBoxGender.Text);

                    cmd.Parameters.AddWithValue(
                        "@Relationship",
                        textBoxRelationship.Text);

                    con.Open();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Dependent Added Successfully");

                    LoadDependents();

                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            if (dataGridViewdep.CurrentRow != null)
            {
                DataGridViewRow row =
                    dataGridViewdep.CurrentRow;

                textBoxDependentID.Text =
                    row.Cells[0].Value?.ToString() ?? "";

                textBoxColonistID.Text =
                    row.Cells[1].Value?.ToString() ?? "";

                textBoxName.Text =
                    row.Cells[2].Value?.ToString() ?? "";

                textBoxGender.Text =
                    row.Cells[4].Value?.ToString() ?? "";

                textBoxRelationship.Text =
                    row.Cells[5].Value?.ToString() ?? "";

                if (row.Cells[3].Value != null)
                {
                    DateTime dob =
                        Convert.ToDateTime(row.Cells[3].Value);

                    int age =
                        DateTime.Now.Year - dob.Year;

                    if (DateTime.Now.DayOfYear <
                        dob.DayOfYear)
                    {
                        age--;
                    }

                    textBoxAge.Text =
                        age.ToString();
                }
            }
            else
            {
                MessageBox.Show("Please select a row.");
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxDependentID.Text == "")
                {
                    MessageBox.Show(
                        "Select a record first.");
                    return;
                }

                using (SqlConnection con =
                    new SqlConnection(conString))
                {
                    string query = @"
                    UPDATE Dependent
                    SET
                        ColonistID = @ColonistID,
                        FullName = @FullName,
                        DOB = @DOB,
                        Gender = @Gender,
                        Relationship = @Relationship
                    WHERE
                        DependentID = @DependentID";

                    SqlCommand cmd =
                        new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue(
                        "@DependentID",
                        Convert.ToInt32(
                        textBoxDependentID.Text));

                    cmd.Parameters.AddWithValue(
                        "@ColonistID",
                        Convert.ToInt32(
                        textBoxColonistID.Text));

                    cmd.Parameters.AddWithValue(
                        "@FullName",
                        textBoxName.Text);

                    cmd.Parameters.AddWithValue(
                        "@DOB",
                        DateTime.Now.AddYears(
                        -Convert.ToInt32(
                        textBoxAge.Text)));

                    cmd.Parameters.AddWithValue(
                        "@Gender",
                        textBoxGender.Text);

                    cmd.Parameters.AddWithValue(
                        "@Relationship",
                        textBoxRelationship.Text);

                    con.Open();

                    int rows =
                        cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show(
                            "Updated Successfully");

                        LoadDependents();

                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Update Failed");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonbackdep_Click(object sender, EventArgs e)
        {
            dashbord d = new dashbord();
            d.Show();
            this.Close();
        }

        private void ClearFields()
        {
            textBoxDependentID.Clear();
            textBoxColonistID.Clear();
            textBoxName.Clear();
            textBoxAge.Clear();
            textBoxGender.Clear();
            textBoxRelationship.Clear();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxDependentID.Text == "")
                {
                    MessageBox.Show("Please select a record first.");
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this record?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection con =
                        new SqlConnection(conString))
                    {
                        string query =
                        @"DELETE FROM Dependent
                  WHERE DependentID = @DependentID";

                        SqlCommand cmd =
                            new SqlCommand(query, con);

                        cmd.Parameters.AddWithValue(
                            "@DependentID",
                            Convert.ToInt32(textBoxDependentID.Text));

                        con.Open();

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Record Deleted Successfully");

                            LoadDependents();

                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Delete Failed");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}