using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApp4;

namespace GestionProjet
{
    public partial class Login : System.Windows.Forms.Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\Documents\users.mdf;Integrated Security=True;Connect Timeout=30");

        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = check_showpassword.Checked ? '\0' : '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register regf = new Register();
            regf.Show();
            this.Hide();


        }
        private void button2_Click(object sender, EventArgs e)
        {
            {
                if (login_username.Text == "" || login_password.Text == "")
                {
                    MessageBox.Show("Error, Fill the blanks");

                }
                else
                {
                    try
                    {
                        connect.Open();
                        string selectData = "SELECT * FROM USERSS WHERE username = @username AND password = @password";
                        using (SqlCommand command = new SqlCommand(selectData, connect))
                        {
                            command.Parameters.AddWithValue("@username", login_username.Text.Trim());
                            command.Parameters.AddWithValue("@password", login_password.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Welcome to Our Store");
                                UserOrderForm io = new UserOrderForm();
                                io.Show();
                                this.Hide();

                            }

                            else
                            {
                                MessageBox.Show("Username Or Password Incorrect");

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
        }

        private void Guest_Click(object sender, EventArgs e)
        {
            GuestForm form = new GuestForm();
            form.Show();
            this.Hide();
        }
    }
}
