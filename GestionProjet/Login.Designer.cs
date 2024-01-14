namespace GestionProjet
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button2 = new Button();
            login_username = new TextBox();
            login_password = new TextBox();
            check_showpassword = new CheckBox();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            button1 = new Button();
            Guest = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(678, 386);
            button2.Name = "button2";
            button2.Size = new Size(146, 40);
            button2.TabIndex = 1;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // login_username
            // 
            login_username.Location = new Point(569, 214);
            login_username.Name = "login_username";
            login_username.Size = new Size(198, 23);
            login_username.TabIndex = 2;
            login_username.TextChanged += textBox1_TextChanged;
            // 
            // login_password
            // 
            login_password.Location = new Point(569, 254);
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new Size(198, 23);
            login_password.TabIndex = 3;
            // 
            // check_showpassword
            // 
            check_showpassword.AutoSize = true;
            check_showpassword.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            check_showpassword.ForeColor = SystemColors.ControlLightLight;
            check_showpassword.Location = new Point(574, 313);
            check_showpassword.Name = "check_showpassword";
            check_showpassword.Size = new Size(129, 26);
            check_showpassword.TabIndex = 4;
            check_showpassword.Text = "Show-Pass";
            check_showpassword.TextAlign = ContentAlignment.TopCenter;
            check_showpassword.UseVisualStyleBackColor = true;
            check_showpassword.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox3);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(367, 483);
            panel1.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._3dda0b7e6002cef9e0e052209a1e1b96;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(367, 480);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(497, 386);
            button1.Name = "button1";
            button1.Size = new Size(146, 40);
            button1.TabIndex = 2;
            button1.Text = "Sign-up";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Guest
            // 
            Guest.AutoSize = true;
            Guest.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            Guest.Location = new Point(640, 438);
            Guest.Name = "Guest";
            Guest.Size = new Size(63, 25);
            Guest.TabIndex = 4;
            Guest.Text = "Guest";
            Guest.Click += Guest_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(548, 29);
            label1.Name = "label1";
            label1.Size = new Size(200, 29);
            label1.TabIndex = 6;
            label1.Text = "Gestion de Café";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(399, 209);
            label2.Name = "label2";
            label2.Size = new Size(131, 28);
            label2.TabIndex = 7;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(402, 254);
            label3.Name = "label3";
            label3.Size = new Size(128, 28);
            label3.TabIndex = 8;
            label3.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo1;
            pictureBox1.Location = new Point(594, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 107);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 64, 0);
            ClientSize = new Size(887, 483);
            Controls.Add(Guest);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(check_showpassword);
            Controls.Add(login_password);
            Controls.Add(login_username);
            Controls.Add(button2);
            Name = "Login";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private TextBox login_username;
        private TextBox login_password;
        private CheckBox check_showpassword;
        private Panel panel1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Label Guest;
        private PictureBox pictureBox3;
    }
}
