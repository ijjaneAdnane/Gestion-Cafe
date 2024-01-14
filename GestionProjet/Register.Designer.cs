namespace GestionProjet
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            pictureBox1 = new PictureBox();
            register_email = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            Login = new Button();
            login_password = new TextBox();
            register_username = new TextBox();
            label5 = new Label();
            label6 = new Label();
            register_confirm = new TextBox();
            register_password = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo1;
            pictureBox1.Location = new Point(544, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 107);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // register_email
            // 
            register_email.AutoSize = true;
            register_email.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_email.Location = new Point(398, 222);
            register_email.Name = "register_email";
            register_email.Size = new Size(77, 28);
            register_email.TabIndex = 17;
            register_email.Text = "Email";
            register_email.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(398, 181);
            label2.Name = "label2";
            label2.Size = new Size(131, 28);
            label2.TabIndex = 16;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(491, 25);
            label1.Name = "label1";
            label1.Size = new Size(200, 29);
            label1.TabIndex = 15;
            label1.Text = "Gestion de Café";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(381, 512);
            panel1.TabIndex = 14;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(381, 509);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(604, 431);
            button2.Name = "button2";
            button2.Size = new Size(146, 40);
            button2.TabIndex = 10;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Login
            // 
            Login.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Login.Location = new Point(604, 363);
            Login.Name = "Login";
            Login.Size = new Size(146, 40);
            Login.TabIndex = 2;
            Login.Text = "Sign-up";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // login_password
            // 
            login_password.Location = new Point(585, 230);
            login_password.Name = "login_password";
            login_password.Size = new Size(198, 23);
            login_password.TabIndex = 12;
            // 
            // register_username
            // 
            register_username.Location = new Point(585, 186);
            register_username.Name = "register_username";
            register_username.Size = new Size(198, 23);
            register_username.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(398, 309);
            label5.Name = "label5";
            label5.Size = new Size(162, 28);
            label5.TabIndex = 22;
            label5.Text = "Confirmation";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(398, 268);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(128, 28);
            label6.TabIndex = 21;
            label6.Text = "Password";
            label6.Click += label6_Click;
            // 
            // register_confirm
            // 
            register_confirm.Location = new Point(585, 317);
            register_confirm.Name = "register_confirm";
            register_confirm.PasswordChar = '*';
            register_confirm.Size = new Size(198, 23);
            register_confirm.TabIndex = 20;
            // 
            // register_password
            // 
            register_password.Location = new Point(585, 273);
            register_password.Name = "register_password";
            register_password.PasswordChar = '*';
            register_password.Size = new Size(198, 23);
            register_password.TabIndex = 19;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 64, 0);
            ClientSize = new Size(903, 504);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(register_confirm);
            Controls.Add(register_password);
            Controls.Add(pictureBox1);
            Controls.Add(Login);
            Controls.Add(register_email);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(login_password);
            Controls.Add(register_username);
            Name = "Register";
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label register_email;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Button Login;
        private TextBox login_password;
        private TextBox register_username;
        private Button button2;
        private Label label5;
        private Label label6;
        private TextBox register_confirm;
        private TextBox register_password;
        private PictureBox pictureBox2;
    }
}