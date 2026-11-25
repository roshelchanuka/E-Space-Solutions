using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace my_new_system
{
    public partial class registeruser : Form
    {
        string conString =
        @"Data Source=.\SQLEXPRESS;
        Initial Catalog=MarsColonizationDB;
        Integrated Security=True";

        public registeruser()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            try
            {
                using (SqlConnection con =
                    new SqlConnection(conString))
                {
                    string query =
                    @"SELECT
                        UserID,
                        Username,
                        RoleID,
                        Status,
                        FailedAttempts,
                        CreatedDate,
                        LastLogin
                      FROM UserAccount";

                    SqlDataAdapter da =
                        new SqlDataAdapter(query, con);

                    DataTable dt =
                        new DataTable();

                    da.Fill(dt);

                    dataGridViewusrman.DataSource = null;
                    dataGridViewusrman.DataSource = dt;

                    dataGridViewusrman.AllowUserToAddRows = false;
                    dataGridViewusrman.SelectionMode =
                        DataGridViewSelectionMode.FullRowSelect;

                    dataGridViewusrman.AutoSizeColumnsMode =
                        DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewusrman_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dataGridViewusrman.Rows[e.RowIndex];

                textid.Text =
                    row.Cells["UserID"].Value.ToString();

                textusrname.Text =
                    row.Cells["Username"].Value.ToString();

                textroleid.Text =
                    row.Cells["RoleID"].Value.ToString();
            }
        }

        private void buttoninsertuser_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (textpass.Text !=
                    textconfigpass.Text)
                {
                    MessageBox.Show(
                        "Passwords do not match.");
                    return;
                }

                string hash =
                    BCrypt.Net.BCrypt.HashPassword(
                    textpass.Text);

                using (SqlConnection con =
                    new SqlConnection(conString))
                {
                    string query =
                    @"INSERT INTO UserAccount
                    (
                        Username,
                        PasswordHash,
                        RoleID,
                        Status,
                        FailedAttempts,
                        CreatedDate
                    )
                    VALUES
                    (
                        @Username,
                        @PasswordHash,
                        @RoleID,
                        'Active',
                        0,
                        GETDATE()
                    )";

                    SqlCommand cmd =
                        new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue(
                        "@Username",
                        textusrname.Text);

                    cmd.Parameters.AddWithValue(
                        "@PasswordHash",
                        hash);

                    cmd.Parameters.AddWithValue(
                        "@RoleID",
                        Convert.ToInt32(
                        textroleid.Text));

                    con.Open();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "User Added Successfully");

                    LoadUsers();

                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnseruser_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                using (SqlConnection con =
                    new SqlConnection(conString))
                {
                    string query =
                    @"SELECT
                        UserID,
                        Username,
                        RoleID,
                        Status,
                        FailedAttempts,
                        CreatedDate,
                        LastLogin
                    FROM UserAccount
                    WHERE
                        Username LIKE @Search
                        OR CAST(UserID AS VARCHAR) LIKE @Search
                        OR CAST(RoleID AS VARCHAR) LIKE @Search";

                    SqlCommand cmd =
                        new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue(
                        "@Search",
                        "%" + textsearch.Text + "%");

                    SqlDataAdapter da =
                        new SqlDataAdapter(cmd);

                    DataTable dt =
                        new DataTable();

                    da.Fill(dt);

                    dataGridViewusrman.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonupdateuser_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (textpass.Text !=
                    textconfigpass.Text)
                {
                    MessageBox.Show(
                        "Passwords do not match.");
                    return;
                }

                string hash =
                    BCrypt.Net.BCrypt.HashPassword(
                    textpass.Text);

                using (SqlConnection con =
                    new SqlConnection(conString))
                {
                    string query =
                    @"UPDATE UserAccount
                    SET
                        Username=@Username,
                        PasswordHash=@PasswordHash,
                        RoleID=@RoleID
                    WHERE
                        UserID=@UserID";

                    SqlCommand cmd =
                        new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue(
                        "@UserID",
                        Convert.ToInt32(
                        textid.Text));

                    cmd.Parameters.AddWithValue(
                        "@Username",
                        textusrname.Text);

                    cmd.Parameters.AddWithValue(
                        "@PasswordHash",
                        hash);

                    cmd.Parameters.AddWithValue(
                        "@RoleID",
                        Convert.ToInt32(
                        textroleid.Text));

                    con.Open();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "User Updated Successfully");

                    LoadUsers();

                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttondeleteuser_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                DialogResult result =
                    MessageBox.Show(
                    "Delete this user?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection con =
                        new SqlConnection(conString))
                    {
                        string query =
                        @"DELETE FROM UserAccount
                          WHERE UserID=@UserID";

                        SqlCommand cmd =
                            new SqlCommand(query, con);

                        cmd.Parameters.AddWithValue(
                            "@UserID",
                            Convert.ToInt32(
                            textid.Text));

                        con.Open();

                        cmd.ExecuteNonQuery();

                        MessageBox.Show(
                            "User Deleted");

                        LoadUsers();

                        ClearFields();
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
            textusrname.Clear();
            textpass.Clear();
            textconfigpass.Clear();
            textroleid.Clear();
        }

        private void registeruser_Load(
            object sender,
            EventArgs e)
        {
            LoadUsers();
        }

        private void buttonbackjob_Click(
            object sender,
            EventArgs e)
        {
            admindashcs form = new admindashcs();
            form.Show();
            this.Hide();
        }
    }


}