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
    public partial class colo : Form
    {
        public colo()
        {
            InitializeComponent();
            LoadColonists();
        }

        string conString =
     
                                @"Data Source=.\SQLEXPRESS;
                                    Initial Catalog=MarsColonizationDB;
                                        Integrated Security=True";


        private void LoadColonists()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();

                    string query = "SELECT * FROM Colonist";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dataGridViewcolo.Columns.Clear(); // IMPORTANT

                    dataGridViewcolo.DataSource = null;
                    dataGridViewcolo.DataSource = dt;

                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void colo_Load(object sender, EventArgs e)
        {
            dataGridViewcolo.AllowUserToAddRows = false;
            dataGridViewcolo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewcolo.MultiSelect = false;
        }


        private void buttondasback_Click(object sender, EventArgs e)
        {
            homepage homepage = new homepage();
            homepage.Show();

            this.Close();


        }

        private void buttoninsert_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string query =
                    @"INSERT INTO Colonist
                    (
                        FirstName,
                        MiddleName,
                        Surname,
                        DOB,
                        Gender,
                        Qualification,
                        ContactNo,
                        CivilStatus
                    )
                    VALUES
                    (
                        @FirstName,
                        @MiddleName,
                        @Surname,
                        @DOB,
                        @Gender,
                        @Qualification,
                        @ContactNo,
                        @CivilStatus
                    )";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@FirstName", textfname.Text);
                    cmd.Parameters.AddWithValue("@MiddleName", textBoxname.Text);
                    cmd.Parameters.AddWithValue("@Surname", textsname.Text);
                    cmd.Parameters.AddWithValue("@DOB", Convert.ToDateTime(textBoxbirth.Text));
                    cmd.Parameters.AddWithValue("@Gender", textgen.Text);
                    cmd.Parameters.AddWithValue("@Qualification", textBoxqulification.Text);
                    cmd.Parameters.AddWithValue("@ContactNo", textBoxnumber.Text);
                    cmd.Parameters.AddWithValue("@CivilStatus", textBoxcivil.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Colonist Added Successfully");

                    LoadColonists();

                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewcolo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonview_Click(object sender, EventArgs e)
        {
            if (dataGridViewcolo.CurrentRow != null)
            {
                DataGridViewRow row = dataGridViewcolo.CurrentRow;

                textBoxid.Text = row.Cells[0].Value?.ToString() ?? "";
                textfname.Text = row.Cells[1].Value?.ToString() ?? "";
                textBoxname.Text = row.Cells[2].Value?.ToString() ?? "";
                textsname.Text = row.Cells[3].Value?.ToString() ?? "";
                textBoxbirth.Text = row.Cells[4].Value?.ToString() ?? "";
                textgen.Text = row.Cells[5].Value?.ToString() ?? "";
                textBoxqulification.Text = row.Cells[6].Value?.ToString() ?? "";
                textBoxnumber.Text = row.Cells[8].Value?.ToString() ?? "";
                textBoxcivil.Text = row.Cells[9].Value?.ToString() ?? "";

                if (row.Cells[4].Value != null)
                {
                    DateTime dob = Convert.ToDateTime(row.Cells[4].Value);

                    int age = DateTime.Now.Year - dob.Year;

                    if (DateTime.Now.DayOfYear < dob.DayOfYear)
                        age--;

                    textBoxage.Text = age.ToString();
                }
            }
        }


        private void ClearFields()
        {
            textBoxid.Clear();
            textfname.Clear();
            textBoxname.Clear();
            textsname.Clear();
            textBoxbirth.Clear();
            textBoxage.Clear();
            textgen.Clear();
            textBoxnumber.Clear();
            textBoxqulification.Clear();
            textBoxcivil.Clear();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxid.Text == "")
                {
                    MessageBox.Show("Please select a record first.");
                    return;
                }

                using (SqlConnection con = new SqlConnection(conString))
                {
                    string query = @"
            UPDATE Colonist
            SET
                FirstName = @FirstName,
                MiddleName = @MiddleName,
                Surname = @Surname,
                DOB = @DOB,
                Gender = @Gender,
                Qualification = @Qualification,
                ContactNo = @ContactNo,
                CivilStatus = @CivilStatus
            WHERE ColonistID = @ColonistID";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@ColonistID", Convert.ToInt32(textBoxid.Text));
                    cmd.Parameters.AddWithValue("@FirstName", textfname.Text);
                    cmd.Parameters.AddWithValue("@MiddleName", textBoxname.Text);
                    cmd.Parameters.AddWithValue("@Surname", textsname.Text);
                    cmd.Parameters.AddWithValue("@DOB", Convert.ToDateTime(textBoxbirth.Text));
                    cmd.Parameters.AddWithValue("@Gender", textgen.Text);
                    cmd.Parameters.AddWithValue("@Qualification", textBoxqulification.Text);
                    cmd.Parameters.AddWithValue("@ContactNo", textBoxnumber.Text);
                    cmd.Parameters.AddWithValue("@CivilStatus", textBoxcivil.Text);

                    con.Open();

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Record Updated Successfully");

                        LoadColonists();
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Update Failed");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxid.Text == "")
                {
                    MessageBox.Show("Please select a record first.");
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this Colonist?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection con =
                        new SqlConnection(conString))
                    {
                        con.Open();

                        string deleteDependents =
                        @"DELETE FROM Dependent
                  WHERE ColonistID = @ColonistID";

                        SqlCommand cmdDep =
                            new SqlCommand(deleteDependents, con);

                        cmdDep.Parameters.AddWithValue(
                            "@ColonistID",
                            Convert.ToInt32(textBoxid.Text));

                        cmdDep.ExecuteNonQuery();

                        string deleteColonist =
                        @"DELETE FROM Colonist
                  WHERE ColonistID = @ColonistID";

                        SqlCommand cmd =
                            new SqlCommand(deleteColonist, con);

                        cmd.Parameters.AddWithValue(
                            "@ColonistID",
                            Convert.ToInt32(textBoxid.Text));

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Colonist Deleted Successfully");

                            LoadColonists();

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
    }
    }
            
        
    


        

