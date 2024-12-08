namespace ShawarmaManagementSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            UserName = new TextBox();
            Password = new TextBox();
            LoginButton = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // UserName
            // 
            UserName.Font = new Font("Segoe UI", 20F);
            UserName.Location = new Point(346, 195);
            UserName.Name = "UserName";
            UserName.Size = new Size(280, 43);
            UserName.TabIndex = 2;
            // 
            // Password
            // 
            Password.Font = new Font("Segoe UI", 20F);
            Password.Location = new Point(346, 270);
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.Size = new Size(280, 43);
            Password.TabIndex = 3;
            // 
            // LoginButton
            // 
            LoginButton.Font = new Font("Segoe UI", 20F);
            LoginButton.Location = new Point(308, 361);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(161, 49);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(180, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 118);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(323, 69);
            label2.Name = "label2";
            label2.Size = new Size(395, 37);
            label2.TabIndex = 15;
            label2.Text = "Shawarma Management System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(180, 201);
            label1.Name = "label1";
            label1.Size = new Size(141, 37);
            label1.TabIndex = 16;
            label1.Text = "UserName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(180, 276);
            label3.Name = "label3";
            label3.Size = new Size(128, 37);
            label3.TabIndex = 17;
            label3.Text = "Password";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(LoginButton);
            Controls.Add(Password);
            Controls.Add(UserName);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox UserName;
        private TextBox Password;
        private Button LoginButton;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label label3;
    }
}