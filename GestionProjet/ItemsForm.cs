using GestionProjet;
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

namespace WindowsFormsApp4
{
    public partial class ItemsForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\Documents\users.mdf;Integrated Security=True;Connect Timeout=30");



        public ItemsForm()
        {
            InitializeComponent();
        }
        void populate()
        {
            Con.Open();
            string query = "select * from ItemTb1";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ItemsGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserOrderForm frm = new UserOrderForm();
            frm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(itemname_textBox.Text) || string.IsNullOrEmpty(Itemnum_textbox.Text) || string.IsNullOrEmpty(itemprice_textBox.Text))
            {
                MessageBox.Show("Fill All The Data");
            }
            else
            {
                try
                {
                    if (Con.State == ConnectionState.Closed)
                    {
                        Con.Open();
                    }
                    string query = "INSERT INTO ItemTb1 (ItemNum, ItemName, Itemcat, ItemPrice) VALUES (@ItemNum, @ItemName, @Itemcat, @ItemPrice)";


                    SqlCommand cmd = new SqlCommand(query, Con);

                    cmd.Parameters.AddWithValue("@ItemNum", Itemnum_textbox.Text);
                    cmd.Parameters.AddWithValue("@ItemName", itemname_textBox.Text);
                    if (comboBox1.SelectedItem != null)
                    {
                        cmd.Parameters.AddWithValue("@Itemcat", comboBox1.SelectedItem.ToString());
                    }

                    if (decimal.TryParse(itemprice_textBox.Text, out decimal itemPrice))
                    {
                        cmd.Parameters.AddWithValue("@ItemPrice", itemPrice);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Item Successfully Created");
                    }
                    else
                    {
                        MessageBox.Show("Invalid Item Price");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    if (Con.State == ConnectionState.Open)
                    {
                        Con.Close();
                    }
                }
            }

            populate();
        }



        private void ItemsForm_Load(object sender, EventArgs e)
        {
            populate();
            Date.Text = DateTime.Now.ToString();
        }

        private void user_button_Click(object sender, EventArgs e)
        {
            
        }

        private void ItemsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Assurez-vous que la ligne est valide
            {
                DataGridViewRow row = ItemsGV.Rows[e.RowIndex];

                Itemnum_textbox.Text = row.Cells[0].Value.ToString();
                itemname_textBox.Text = row.Cells[1].Value.ToString();
                comboBox1.SelectedItem = row.Cells[2].Value.ToString();
                itemprice_textBox.Text = row.Cells[3].Value.ToString();
            }
        }


        private void delete_button_Click(object sender, EventArgs e)
        {
            if (Itemnum_textbox.Text == "")
            {
                MessageBox.Show("Select The Item to be Deleted");
            }
            else
            {
                try
                {
                    if (Con.State == ConnectionState.Closed)
                    {
                        Con.Open();
                    }

                    string query = "DELETE FROM ItemTb1 WHERE ItemNum = '" + Itemnum_textbox.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item Successfully Deleted");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    if (Con.State == ConnectionState.Open)
                    {
                        Con.Close();
                    }

                    populate();
                }
            }
        }


        private void Edit_button_Click(object sender, EventArgs e)
        {
            if (Itemnum_textbox.Text == "" || itemname_textBox.Text == "" || itemprice_textBox.Text == "")
            {
                MessageBox.Show("Fill All The Fields");
            }
            else
            {
                try
                {
                    if (Con.State == ConnectionState.Closed)
                    {
                        Con.Open();
                    }

                    string query = "UPDATE ItemTb1 SET ItemName='" + itemname_textBox.Text + "', Itemcat='" + comboBox1.SelectedItem.ToString() + "' WHERE ItemPrice='" + itemprice_textBox.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item Successfully Edited");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    if (Con.State == ConnectionState.Open)
                    {
                        Con.Close();
                    }

                    populate();
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
