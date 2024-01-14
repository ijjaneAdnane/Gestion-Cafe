namespace WindowsFormsApp4
{
    partial class UserOrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserOrderForm));
            panel1 = new Panel();
            facture = new Button();
            label3 = new Label();
            Date = new Label();
            button5 = new Button();
            OrderAmt = new Label();
            OrdersGv = new DataGridView();
            QtyTb = new TextBox();
            button2 = new Button();
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            ItemsGV = new DataGridView();
            SellerName = new TextBox();
            Ordernum = new TextBox();
            categorycb = new ComboBox();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button7 = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersGv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemsGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(facture);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(Date);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(OrderAmt);
            panel1.Controls.Add(OrdersGv);
            panel1.Controls.Add(QtyTb);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(ItemsGV);
            panel1.Controls.Add(SellerName);
            panel1.Controls.Add(Ordernum);
            panel1.Controls.Add(categorycb);
            panel1.Location = new Point(124, 124);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(808, 496);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // facture
            // 
            facture.BackColor = Color.FromArgb(192, 0, 0);
            facture.Location = new Point(676, 435);
            facture.Margin = new Padding(4, 3, 4, 3);
            facture.Name = "facture";
            facture.Size = new Size(117, 27);
            facture.TabIndex = 14;
            facture.Text = "FACTURE";
            facture.UseVisualStyleBackColor = false;
            facture.Click += facture_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(128, 128, 255);
            label3.Location = new Point(589, 375);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 13;
            label3.Text = "Total";
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.Location = new Point(589, 20);
            Date.Name = "Date";
            Date.Size = new Size(31, 15);
            Date.TabIndex = 12;
            Date.Text = "Date";
            Date.Click += Date_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(192, 0, 0);
            button5.Location = new Point(203, 67);
            button5.Margin = new Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new Size(69, 27);
            button5.TabIndex = 11;
            button5.Text = "Refresh";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // OrderAmt
            // 
            OrderAmt.AutoSize = true;
            OrderAmt.Location = new Point(629, 375);
            OrderAmt.Margin = new Padding(4, 0, 4, 0);
            OrderAmt.Name = "OrderAmt";
            OrderAmt.Size = new Size(84, 15);
            OrderAmt.TabIndex = 10;
            OrderAmt.Text = "Amount Order";
            OrderAmt.Click += label3_Click;
            // 
            // OrdersGv
            // 
            OrdersGv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersGv.Location = new Point(118, 319);
            OrdersGv.Margin = new Padding(4, 3, 4, 3);
            OrdersGv.Name = "OrdersGv";
            OrdersGv.Size = new Size(461, 143);
            OrdersGv.TabIndex = 9;
            OrdersGv.CellContentClick += OrdersGv_CellContentClick;
            // 
            // QtyTb
            // 
            QtyTb.Location = new Point(472, 218);
            QtyTb.Margin = new Padding(4, 3, 4, 3);
            QtyTb.Name = "QtyTb";
            QtyTb.RightToLeft = RightToLeft.Yes;
            QtyTb.Size = new Size(116, 23);
            QtyTb.TabIndex = 8;
            QtyTb.Text = "Quantity";
            QtyTb.TextChanged += quantity_textBo_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 0, 0);
            button2.Location = new Point(344, 289);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(117, 27);
            button2.TabIndex = 7;
            button2.Text = "Place The Order";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 301);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 6;
            label2.Text = "Your Order";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.Location = new Point(596, 215);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(117, 27);
            button1.TabIndex = 5;
            button1.Text = "Add To Cart";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(370, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 4;
            label1.Text = "Place Order";
            label1.Click += label1_Click;
            // 
            // ItemsGV
            // 
            ItemsGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ItemsGV.Location = new Point(310, 55);
            ItemsGV.Margin = new Padding(4, 3, 4, 3);
            ItemsGV.Name = "ItemsGV";
            ItemsGV.Size = new Size(461, 143);
            ItemsGV.TabIndex = 3;
            ItemsGV.CellContentClick += dataGridView1_CellContentClick;
            // 
            // SellerName
            // 
            SellerName.Location = new Point(39, 152);
            SellerName.Margin = new Padding(4, 3, 4, 3);
            SellerName.Name = "SellerName";
            SellerName.Size = new Size(116, 23);
            SellerName.TabIndex = 2;
            SellerName.Text = "SellerName";
            // 
            // Ordernum
            // 
            Ordernum.Location = new Point(39, 112);
            Ordernum.Margin = new Padding(4, 3, 4, 3);
            Ordernum.Name = "Ordernum";
            Ordernum.Size = new Size(116, 23);
            Ordernum.TabIndex = 1;
            Ordernum.Text = "OrderNum";
            Ordernum.TextChanged += OrderNum_TextChanged;
            // 
            // categorycb
            // 
            categorycb.FormattingEnabled = true;
            categorycb.Items.AddRange(new object[] { "Food", "Breakfast", "Drink", "Hot Drink", "Cold Drink", "Ice-cream", "Tea", "Ice-Tea", "Cooka", "Espresso", "Toast" });
            categorycb.Location = new Point(15, 67);
            categorycb.Margin = new Padding(4, 3, 4, 3);
            categorycb.Name = "categorycb";
            categorycb.Size = new Size(140, 23);
            categorycb.TabIndex = 0;
            categorycb.Text = "ItemCat";
            categorycb.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            categorycb.SelectionChangeCommitted += categorycb_SelectionChangeCommitted;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.ForeColor = Color.Black;
            button3.Location = new Point(13, 232);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(104, 27);
            button3.TabIndex = 6;
            button3.Text = "Items";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = GestionProjet.Properties.Resources.fofee;
            pictureBox1.Location = new Point(406, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(199, 106);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = GestionProjet.Properties.Resources.logoooot;
            pictureBox2.Location = new Point(27, 544);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 42);
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(951, 12);
            button7.Margin = new Padding(4, 3, 4, 3);
            button7.Name = "button7";
            button7.Size = new Size(32, 27);
            button7.TabIndex = 16;
            button7.Text = "X";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // UserOrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 64, 0);
            ClientSize = new Size(996, 632);
            Controls.Add(button7);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "UserOrderForm";
            Text = "Form2";
            Load += UserOrderForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersGv).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemsGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ItemsGV;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox categorycb;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button facture;
        private PictureBox pictureBox1;
        private TextBox SellerName;
        private TextBox Ordernum;
        private TextBox QtyTb;
        private PictureBox pictureBox2;
        private Button button7;
        private Label OrderAmt;
        private DataGridView OrdersGv;
        private Button button5;
        private Label Date;
        private Label label3;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}