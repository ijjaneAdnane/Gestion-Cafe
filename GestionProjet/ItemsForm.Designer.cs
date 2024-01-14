namespace WindowsFormsApp4
{
    partial class ItemsForm
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
            Order_button = new Button();
            panel1 = new Panel();
            Date = new Label();
            Edit_button = new Button();
            delete_button = new Button();
            label5 = new Label();
            ItemsGV = new DataGridView();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            itemprice_textBox = new TextBox();
            add_button = new Button();
            label1 = new Label();
            itemname_textBox = new TextBox();
            Itemnum_textbox = new TextBox();
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            button7 = new Button();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ItemsGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Order_button
            // 
            Order_button.BackColor = Color.Red;
            Order_button.Location = new Point(13, 229);
            Order_button.Margin = new Padding(4, 3, 4, 3);
            Order_button.Name = "Order_button";
            Order_button.Size = new Size(72, 27);
            Order_button.TabIndex = 9;
            Order_button.Text = "Order";
            Order_button.UseVisualStyleBackColor = false;
            Order_button.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(Date);
            panel1.Controls.Add(Edit_button);
            panel1.Controls.Add(delete_button);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(ItemsGV);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(itemprice_textBox);
            panel1.Controls.Add(add_button);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(itemname_textBox);
            panel1.Controls.Add(Itemnum_textbox);
            panel1.Controls.Add(comboBox1);
            panel1.Location = new Point(93, 123);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(839, 428);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.Location = new Point(638, 15);
            Date.Margin = new Padding(4, 0, 4, 0);
            Date.Name = "Date";
            Date.Size = new Size(31, 15);
            Date.TabIndex = 16;
            Date.Text = "Date";
            // 
            // Edit_button
            // 
            Edit_button.BackColor = Color.FromArgb(192, 0, 0);
            Edit_button.Location = new Point(180, 291);
            Edit_button.Margin = new Padding(4, 3, 4, 3);
            Edit_button.Name = "Edit_button";
            Edit_button.Size = new Size(117, 27);
            Edit_button.TabIndex = 15;
            Edit_button.Text = "Edit";
            Edit_button.UseVisualStyleBackColor = false;
            Edit_button.Click += Edit_button_Click;
            // 
            // delete_button
            // 
            delete_button.BackColor = Color.FromArgb(192, 0, 0);
            delete_button.Location = new Point(315, 291);
            delete_button.Margin = new Padding(4, 3, 4, 3);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(117, 27);
            delete_button.TabIndex = 14;
            delete_button.Text = "Delete";
            delete_button.UseVisualStyleBackColor = false;
            delete_button.Click += delete_button_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(505, 50);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 13;
            label5.Text = "ItemsList";
            // 
            // ItemsGV
            // 
            ItemsGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ItemsGV.Location = new Point(315, 82);
            ItemsGV.Margin = new Padding(4, 3, 4, 3);
            ItemsGV.Name = "ItemsGV";
            ItemsGV.Size = new Size(461, 143);
            ItemsGV.TabIndex = 12;
            ItemsGV.CellContentClick += ItemsGV_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 232);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 11;
            label4.Text = "ItemPrice";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 136);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 10;
            label3.Text = "ItemName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 106);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 9;
            label2.Text = "ItemNum";
            // 
            // itemprice_textBox
            // 
            itemprice_textBox.Location = new Point(180, 228);
            itemprice_textBox.Margin = new Padding(4, 3, 4, 3);
            itemprice_textBox.Name = "itemprice_textBox";
            itemprice_textBox.Size = new Size(116, 23);
            itemprice_textBox.TabIndex = 8;
            itemprice_textBox.Text = "ItemPrice";
            // 
            // add_button
            // 
            add_button.BackColor = Color.FromArgb(192, 0, 0);
            add_button.Location = new Point(48, 291);
            add_button.Margin = new Padding(4, 3, 4, 3);
            add_button.Name = "add_button";
            add_button.Size = new Size(117, 27);
            add_button.TabIndex = 5;
            add_button.Text = "Add ";
            add_button.UseVisualStyleBackColor = false;
            add_button.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(336, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 4;
            label1.Text = "Manage Items";
            // 
            // itemname_textBox
            // 
            itemname_textBox.Location = new Point(180, 128);
            itemname_textBox.Margin = new Padding(4, 3, 4, 3);
            itemname_textBox.Name = "itemname_textBox";
            itemname_textBox.Size = new Size(116, 23);
            itemname_textBox.TabIndex = 2;
            itemname_textBox.Text = "ItemName";
            // 
            // Itemnum_textbox
            // 
            Itemnum_textbox.Location = new Point(180, 98);
            Itemnum_textbox.Margin = new Padding(4, 3, 4, 3);
            Itemnum_textbox.Name = "Itemnum_textbox";
            Itemnum_textbox.Size = new Size(116, 23);
            Itemnum_textbox.TabIndex = 1;
            Itemnum_textbox.Text = "ItemNum";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Food", "Breakfast", "Drink", "Jus", "Hot Drink", "Cold Drink", "Ice-cream", "Cooka", "Tea", "Ice-Tea", "Cafe-Glace", "Espresso", "Toast" });
            comboBox1.Location = new Point(111, 178);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(140, 23);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "Category";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = GestionProjet.Properties.Resources.fofee;
            pictureBox1.Location = new Point(392, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 105);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // button7
            // 
            button7.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(900, 12);
            button7.Margin = new Padding(4, 3, 4, 3);
            button7.Name = "button7";
            button7.Size = new Size(32, 27);
            button7.TabIndex = 13;
            button7.Text = "X";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = GestionProjet.Properties.Resources.logoooot;
            pictureBox2.Location = new Point(13, 509);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 42);
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // ItemsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 64, 0);
            ClientSize = new Size(945, 611);
            Controls.Add(pictureBox2);
            Controls.Add(button7);
            Controls.Add(pictureBox1);
            Controls.Add(Order_button);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "ItemsForm";
            Text = "ItemsForm";
            Load += ItemsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ItemsGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button Order_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox itemprice_textBox;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox itemname_textBox;
        private System.Windows.Forms.TextBox Itemnum_textbox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView ItemsGV;
        private PictureBox pictureBox1;
        private Button button7;
        private PictureBox pictureBox2;
        private Label Date;
    }
}