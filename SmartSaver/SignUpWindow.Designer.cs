namespace SmartSaver
{
    partial class SignUpWindow
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
            this.FirstName = new System.Windows.Forms.Label();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.LastName = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.CreateYourUser = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.ConfirmTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstName
            // 
            this.FirstName.AccessibleName = "";
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FirstName.Location = new System.Drawing.Point(13, 61);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(86, 20);
            this.FirstName.TabIndex = 0;
            this.FirstName.Text = "First Name";
            this.FirstName.Click += new System.EventHandler(this.label1_Click);
            // 
            // SignUpButton
            // 
            this.SignUpButton.Location = new System.Drawing.Point(196, 272);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(75, 23);
            this.SignUpButton.TabIndex = 1;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LastName.Location = new System.Drawing.Point(192, 61);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(86, 20);
            this.LastName.TabIndex = 2;
            this.LastName.Text = "Last Name";
            this.LastName.Click += new System.EventHandler(this.LastName_Click);
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FirstNameTextBox.Location = new System.Drawing.Point(17, 84);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(159, 26);
            this.FirstNameTextBox.TabIndex = 3;
            this.FirstNameTextBox.TextChanged += new System.EventHandler(this.FirstNameTextBox_TextChanged);
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LastNameTextBox.Location = new System.Drawing.Point(196, 84);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(159, 26);
            this.LastNameTextBox.TabIndex = 4;
            this.LastNameTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // CreateYourUser
            // 
            this.CreateYourUser.AutoSize = true;
            this.CreateYourUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CreateYourUser.Location = new System.Drawing.Point(12, 9);
            this.CreateYourUser.Name = "CreateYourUser";
            this.CreateYourUser.Size = new System.Drawing.Size(343, 26);
            this.CreateYourUser.TabIndex = 5;
            this.CreateYourUser.Text = "Create Your Smart Saver Account";
            this.CreateYourUser.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AccessibleName = "";
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UsernameLabel.Location = new System.Drawing.Point(13, 139);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(83, 20);
            this.UsernameLabel.TabIndex = 7;
            this.UsernameLabel.Text = "Username";
            this.UsernameLabel.Click += new System.EventHandler(this.UsernameLabel_Click);
            // 
            // ConfirmTextBox
            // 
            this.ConfirmTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ConfirmTextBox.Location = new System.Drawing.Point(196, 240);
            this.ConfirmTextBox.Name = "ConfirmTextBox";
            this.ConfirmTextBox.Size = new System.Drawing.Size(159, 26);
            this.ConfirmTextBox.TabIndex = 8;
            this.ConfirmTextBox.UseSystemPasswordChar = true;
            this.ConfirmTextBox.TextChanged += new System.EventHandler(this.ConfirmTextBox_TextChanged);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UsernameTextBox.Location = new System.Drawing.Point(17, 162);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(338, 26);
            this.UsernameTextBox.TabIndex = 9;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AccessibleName = "";
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PasswordLabel.Location = new System.Drawing.Point(13, 217);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(78, 20);
            this.PasswordLabel.TabIndex = 10;
            this.PasswordLabel.Text = "Password";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PasswordTextBox.Location = new System.Drawing.Point(17, 240);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(159, 26);
            this.PasswordTextBox.TabIndex = 11;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // ConfirmLabel
            // 
            this.ConfirmLabel.AccessibleName = "";
            this.ConfirmLabel.AutoSize = true;
            this.ConfirmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ConfirmLabel.Location = new System.Drawing.Point(192, 217);
            this.ConfirmLabel.Name = "ConfirmLabel";
            this.ConfirmLabel.Size = new System.Drawing.Size(64, 20);
            this.ConfirmLabel.TabIndex = 12;
            this.ConfirmLabel.Text = "Confirm";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(280, 272);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 13;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SignUpWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 342);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ConfirmLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.ConfirmTextBox);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.CreateYourUser);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.FirstName);
            this.Name = "SignUpWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label CreateYourUser;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox ConfirmTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label ConfirmLabel;
        private System.Windows.Forms.Button BackButton;
    }
}