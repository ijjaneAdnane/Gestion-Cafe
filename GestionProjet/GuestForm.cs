using GestionProjet;
using GestionProjet.Properties;
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
using static System.Windows.Forms.AxHost;

namespace WindowsFormsApp4
{
    public partial class GuestForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\Documents\users.mdf;Integrated Security=True;Connect Timeout=30");

        public GuestForm()
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
        void filterbycategory()
        {
            Con.Open();
            string query = "select * from ItemTb1 where Itemcat = '" + comboBox1.SelectedItem.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ItemsGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GuestForm_Load(object sender, EventArgs e)
        {
            populate();
            table.Columns.Add("Num", typeof(int));
            table.Columns.Add("Item", typeof(string));
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("UnitPrice", typeof(int));
            table.Columns.Add("Total", typeof(int));
            OrdersGv.DataSource = table;
            Date.Text = DateTime.Now.ToString();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }
        int num = 0;
        int price, total;
        string item, cat;


        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filterbycategory();
        }
        DataTable table = new DataTable();
        int flag = 0;
        int sum = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (QtyTb.Text == "")
            {
                MessageBox.Show("What is The Quantity of Item?");
            }
            else
            {
                if (ItemsGV.SelectedRows.Count > 0)
                {
                    item = ItemsGV.SelectedRows[0].Cells[1].Value.ToString();
                    cat = ItemsGV.SelectedRows[0].Cells[2].Value.ToString();
                    price = Convert.ToInt32(ItemsGV.SelectedRows[0].Cells[3].Value.ToString());

                    int quantity = Convert.ToInt32(QtyTb.Text);
                    total = price * quantity;

                    num = num + 1;
                    table.Rows.Add(num, item, cat, price, total);

                    OrdersGv.DataSource = table;

                    sum += total;
                }
                else
                {
                    MessageBox.Show("Please select an item from the ItemsGV table.");
                }

            }
            sum += total;
            OrderAmt.Text = "" + sum / 2;

        }

        private void ItemsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ItemsGV.SelectedRows.Count > 0)
            {
                item = ItemsGV.SelectedRows[0].Cells[1].Value.ToString();
                cat = ItemsGV.SelectedRows[0].Cells[2].Value.ToString();
                price = Convert.ToInt32(ItemsGV.SelectedRows[0].Cells[3].Value.ToString());

            }
;
        }

        private void Date_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "INSERT INTO OrdersTb1 VALUES ('" + Ordernum.Text + "', '" + Date.Text + "', '" + SellerName.Text + "', '" + OrderAmt.Text + "')";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Order Succesfully Created");
            Con.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image image = Resources.logo;
            int imageX = e.PageBounds.Width - image.Width - 25;
            int imageY = 0;

            e.Graphics.DrawImage(image, new Point(imageX, imageY));

            int startY = 160; 

            e.Graphics.DrawString("Date: " + DateTime.Now, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, startY));

            int lineY = startY + 25;
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, lineY));

            int tableStartY = lineY + 25; 
            int offsetY = 20;
            int startX = 25;
            for (int i = 0; i < OrdersGv.Columns.Count; i++)
            {
                e.Graphics.DrawString(OrdersGv.Columns[i].HeaderText, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(25, tableStartY));
               
                startX += OrdersGv.Columns[i].Width;
            }

            tableStartY += offsetY; 

            for (int i = 0; i < OrdersGv.Rows.Count; i++)
            {
                 startX = 25;
                for (int j = 0; j < OrdersGv.Columns.Count; j++)
                {
                    e.Graphics.DrawString(OrdersGv.Rows[i].Cells[j].FormattedValue.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(startX, tableStartY));
                    
                    startX += OrdersGv.Columns[j].Width;
                }
                tableStartY += offsetY;
            }

            int startYAfterTable = tableStartY + 20; 

           e.Graphics.DrawString("***********************************************************************",
                new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, startYAfterTable));

            e.Graphics.DrawString("Merci de votre achat chez Café VINGHT-POINT. Nous apprécions votre confiance!",
                new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, startYAfterTable));

            startYAfterTable += offsetY;
            e.Graphics.DrawString("Nous nous engageons à vous fournir des produits de la plus haute qualité.",
                new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, startYAfterTable));


            e.Graphics.DrawString("Merci de votre achat chez Café VINGHT-POINT. Nous apprécions votre confiance!",
               new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, startYAfterTable)); ;
            
            e.Graphics.DrawString("*********Merci de votre visite******",
   new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, startYAfterTable));
        }
    }
}


