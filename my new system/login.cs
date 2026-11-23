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
using BCrypt.Net;


namespace my_new_system
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonlogback_Click(object sender, EventArgs e)
        {
           homepage homepage = new homepage();
            homepage.Show();
            this.Hide();
        }

        private void buttonlog_Click(object sender, EventArgs e)
        {
            string username = textusername.Text.Trim();
            string password = textpass.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            string connectionString =
                @"Data Source=MSI\SQLEXPRESS;Initial Catalog=MarsColonizationDB;Integrated Security=True;Trust Server Certificate=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string query = @"SELECT UserID,
                                    Username,
                                    PasswordHash,
                                    RoleID,
                                    Status
                             FROM UserAccount
                             WHERE Username = @Username";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@Username", username);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string storedHash = reader["PasswordHash"].ToString();
                        string status = reader["Status"].ToString();
                        int roleID = Convert.ToInt32(reader["RoleID"]);

                        if (status != "Active")
                        {
                            MessageBox.Show("Your account is inactive or locked.");
                            reader.Close();
                            return;
                        }

                        bool passwordMatched =
                            BCrypt.Net.BCrypt.Verify(password, storedHash);

                        if (passwordMatched)
                        {
                            reader.Close();

                            MessageBox.Show("Login Successful");

                            this.Hide();

                            switch (roleID)
                            {
                                case 1:
                                    admindashcs admin = new admindashcs();
                                    admin.Show();
                                    break;

                                case 2:
                                    dashbord staff = new dashbord();
                                    staff.Show();
                                    break;

                                case 3:
                                    ColonySuperintendentdas colony =
                                        new ColonySuperintendentdas();
                                    colony.Show();
                                    break;

                                case 4:
                                    Pilotdash pilot = new Pilotdash();
                                    pilot.Show();
                                    break;

                                default:
                                    MessageBox.Show("Unknown role assigned.");
                                    this.Show();
                                    break;
                            }
                        }
                        else
                        {
                            reader.Close();
                            MessageBox.Show("Invalid username or password.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message);
                }
            }
        }

    }

}

