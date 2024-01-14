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
using WindowsFormsApp4;

namespace GestionProjet
{
    public partial class Register : System.Windows.Forms.Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\Documents\users.mdf;Integrated Security=True;Connect Timeout=30");

        public Register()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)

        {
            if (register_username.Text == "" || register_password.Text == "" || register_email.Text == "" || register_confirm.Text == "")
            {
                MessageBox.Show("Fill the blanks");
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;

                        string selectUsername = "SELECT COUNT(id) FROM USERSS WHERE username = @user";
                        using (SqlCommand checkuser = new SqlCommand(selectUsername, connect))
                        {
                            checkuser.Parameters.AddWithValue("@user", register_username.Text.Trim());
                            int count = (int)checkuser.ExecuteScalar();
                            if (count >= 1)
                            {
                                MessageBox.Show(register_username.Text.Trim(), "Already Exist");
                            }
                            else
                            {
                                string insertdata = "INSERT INTO USERSS (username, password, email, date) VALUES (@username, @password, @email, @date)";
                                using (SqlCommand cmd = new SqlCommand(insertdata, connect))
                                {
                                    cmd.Parameters.AddWithValue("@username", register_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", register_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@email", register_email.Text.Trim());
                                    cmd.Parameters.AddWithValue("@date", today);
                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Welcome");

                                    UserOrderForm io = new UserOrderForm();
                                    io.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }

            if (register_confirm.Text != register_password.Text)
            {
                register_confirm.Text = string.Empty;
                register_password.Text = string.Empty;
                MessageBox.Show("Not the same");
            }


        }





        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login rg = new Login();
            rg.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
