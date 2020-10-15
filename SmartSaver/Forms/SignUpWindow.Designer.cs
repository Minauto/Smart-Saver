﻿namespace SmartSaver
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
            this.FirstNameLbl = new System.Windows.Forms.Label();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.LastNameLbl = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.CreateYrUserLbl = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.ConfirmTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmLbl = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstNameLbl
            // 
            this.FirstNameLbl.AccessibleName = "";
            this.FirstNameLbl.AutoSize = true;
            this.FirstNameLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.FirstNameLbl.Location = new System.Drawing.Point(16, 48);
            this.FirstNameLbl.Name = "FirstNameLbl";
            this.FirstNameLbl.Size = new System.Drawing.Size(91, 21);
            this.FirstNameLbl.TabIndex = 9;
            this.FirstNameLbl.Text = "First Name";
            // 
            // SignUpButton
            // 
            this.SignUpButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.SignUpButton.Location = new System.Drawing.Point(196, 210);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(75, 23);
            this.SignUpButton.TabIndex = 6;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // LastNameLbl
            // 
            this.LastNameLbl.AutoSize = true;
            this.LastNameLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.LastNameLbl.Location = new System.Drawing.Point(192, 48);
            this.LastNameLbl.Name = "LastNameLbl";
            this.LastNameLbl.Size = new System.Drawing.Size(93, 21);
            this.LastNameLbl.TabIndex = 10;
            this.LastNameLbl.Text = "Last Name";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FirstNameTextBox.Location = new System.Drawing.Point(17, 72);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(159, 26);
            this.FirstNameTextBox.TabIndex = 1;
            this.FirstNameTextBox.TextChanged += new System.EventHandler(this.FirstNameTextBox_TextChanged);
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LastNameTextBox.Location = new System.Drawing.Point(196, 72);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(159, 26);
            this.LastNameTextBox.TabIndex = 2;
            this.LastNameTextBox.TextChanged += new System.EventHandler(this.PasswordTextBok_TextChanged);
            // 
            // CreateYrUserLbl
            // 
            this.CreateYrUserLbl.AutoSize = true;
            this.CreateYrUserLbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.CreateYrUserLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CreateYrUserLbl.Location = new System.Drawing.Point(12, 9);
            this.CreateYrUserLbl.Name = "CreateYrUserLbl";
            this.CreateYrUserLbl.Size = new System.Drawing.Size(353, 25);
            this.CreateYrUserLbl.TabIndex = 8;
            this.CreateYrUserLbl.Text = "Create Your Smart Saver Account";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AccessibleName = "";
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.UsernameLabel.Location = new System.Drawing.Point(16, 101);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(88, 21);
            this.UsernameLabel.TabIndex = 11;
            this.UsernameLabel.Text = "Username";
            // 
            // ConfirmTextBox
            // 
            this.ConfirmTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ConfirmTextBox.Location = new System.Drawing.Point(196, 178);
            this.ConfirmTextBox.Name = "ConfirmTextBox";
            this.ConfirmTextBox.Size = new System.Drawing.Size(159, 26);
            this.ConfirmTextBox.TabIndex = 5;
            this.ConfirmTextBox.UseSystemPasswordChar = true;
            this.ConfirmTextBox.TextChanged += new System.EventHandler(this.ConfirmTextBox_TextChanged);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UsernameTextBox.Location = new System.Drawing.Point(17, 125);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(338, 26);
            this.UsernameTextBox.TabIndex = 3;
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AccessibleName = "";
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.PasswordLbl.Location = new System.Drawing.Point(16, 154);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(82, 21);
            this.PasswordLbl.TabIndex = 12;
            this.PasswordLbl.Text = "Password";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PasswordTextBox.Location = new System.Drawing.Point(17, 178);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(159, 26);
            this.PasswordTextBox.TabIndex = 4;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // ConfirmLbl
            // 
            this.ConfirmLbl.AccessibleName = "";
            this.ConfirmLbl.AutoSize = true;
            this.ConfirmLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ConfirmLbl.Location = new System.Drawing.Point(192, 154);
            this.ConfirmLbl.Name = "ConfirmLbl";
            this.ConfirmLbl.Size = new System.Drawing.Size(71, 21);
            this.ConfirmLbl.TabIndex = 13;
            this.ConfirmLbl.Text = "Confirm";
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.BackButton.Location = new System.Drawing.Point(280, 210);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SignUpWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(381, 242);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ConfirmLbl);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.ConfirmTextBox);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.CreateYrUserLbl);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.LastNameLbl);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.FirstNameLbl);
            this.Name = "SignUpWindow";
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.SignUpWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstNameLbl;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Label LastNameLbl;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label CreateYrUserLbl;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox ConfirmTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label ConfirmLbl;
        private System.Windows.Forms.Button BackButton;
    }
}