namespace WindowsFormsApp4
{
    partial class GuestForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestForm));
            panel1 = new Panel();
            button4 = new Button();
            OrderAmt = new Label();
            Date = new Label();
            OrdersGv = new DataGridView();
            button3 = new Button();
            QtyTb = new TextBox();
            button2 = new Button();
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            ItemsGV = new DataGridView();
            SellerName = new TextBox();
            Ordernum = new TextBox();
            comboBox1 = new ComboBox();
            pictureBox2 = new PictureBox();
            button7 = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersGv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemsGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(OrderAmt);
            panel1.Controls.Add(Date);
            panel1.Controls.Add(OrdersGv);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(QtyTb);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(ItemsGV);
            panel1.Controls.Add(SellerName);
            panel1.Controls.Add(Ordernum);
            panel1.Controls.Add(comboBox1);
            panel1.Location = new Point(71, 57);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(796, 450);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(192, 0, 0);
            button4.Location = new Point(669, 403);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(117, 27);
            button4.TabIndex = 13;
            button4.Text = "Facture";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // OrderAmt
            // 
            OrderAmt.AutoSize = true;
            OrderAmt.Location = new Point(669, 336);
            OrderAmt.Margin = new Padding(4, 0, 4, 0);
            OrderAmt.Name = "OrderAmt";
            OrderAmt.Size = new Size(84, 15);
            OrderAmt.TabIndex = 12;
            OrderAmt.Text = "Order Amount";
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.Location = new Point(669, 20);
            Date.Margin = new Padding(4, 0, 4, 0);
            Date.Name = "Date";
            Date.Size = new Size(31, 15);
            Date.TabIndex = 11;
            Date.Text = "Date";
            Date.Click += Date_Click;
            // 
            // OrdersGv
            // 
            OrdersGv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersGv.Location = new Point(186, 287);
            OrdersGv.Margin = new Padding(4, 3, 4, 3);
            OrdersGv.Name = "OrdersGv";
            OrdersGv.Size = new Size(461, 143);
            OrdersGv.TabIndex = 10;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 0, 0);
            button3.Location = new Point(46, 347);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(117, 27);
            button3.TabIndex = 9;
            button3.Text = "User";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // QtyTb
            // 
            QtyTb.Location = new Point(69, 158);
            QtyTb.Margin = new Padding(4, 3, 4, 3);
            QtyTb.Name = "QtyTb";
            QtyTb.Size = new Size(116, 23);
            QtyTb.TabIndex = 8;
            QtyTb.Text = "Quantity";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 0, 0);
            button2.Location = new Point(493, 254);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(127, 27);
            button2.TabIndex = 7;
            button2.Text = "Place The Order";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(376, 215);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 6;
            label2.Text = "Your Order";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(69, 192);
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
            // 
            // ItemsGV
            // 
            ItemsGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ItemsGV.Location = new Point(310, 55);
            ItemsGV.Margin = new Padding(4, 3, 4, 3);
            ItemsGV.Name = "ItemsGV";
            ItemsGV.Size = new Size(461, 143);
            ItemsGV.TabIndex = 3;
            ItemsGV.CellContentClick += ItemsGV_CellContentClick;
            // 
            // SellerName
            // 
            SellerName.Location = new Point(69, 128);
            SellerName.Margin = new Padding(4, 3, 4, 3);
            SellerName.Name = "SellerName";
            SellerName.Size = new Size(116, 23);
            SellerName.TabIndex = 2;
            SellerName.Text = "Guest";
            // 
            // Ordernum
            // 
            Ordernum.Location = new Point(69, 98);
            Ordernum.Margin = new Padding(4, 3, 4, 3);
            Ordernum.Name = "Ordernum";
            Ordernum.Size = new Size(116, 23);
            Ordernum.TabIndex = 1;
            Ordernum.Text = "OrderNum";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Food", "Drink", "Breakfast", "Drink", "Ice-cream", "Cooka", "Tea", "Ice-Tea", "Hot Drink", "Cold Drink", "Espresso", "Toast" });
            comboBox1.Location = new Point(69, 55);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(140, 23);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "Category";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.SelectionChangeCommitted += comboBox1_SelectionChangeCommitted;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = GestionProjet.Properties.Resources.logoooot;
            pictureBox2.Location = new Point(12, 376);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 42);
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(888, 11);
            button7.Margin = new Padding(4, 3, 4, 3);
            button7.Name = "button7";
            button7.Size = new Size(32, 27);
            button7.TabIndex = 17;
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
            // GuestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 64, 0);
            ClientSize = new Size(922, 522);
            Controls.Add(button7);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "GuestForm";
            Text = "Form1";
            Load += GuestForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersGv).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemsGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox QtyTb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ItemsGV;
        private System.Windows.Forms.TextBox SellerName;
        private System.Windows.Forms.TextBox Ordernum;
        private System.Windows.Forms.Button button3;
        private PictureBox pictureBox2;
        private Button button7;
        private DataGridView OrdersGv;
        private Label Date;
        private Label OrderAmt;
        private Button button4;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}

