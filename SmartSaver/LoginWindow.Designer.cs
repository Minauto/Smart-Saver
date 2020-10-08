namespace SmartSaver
{
    partial class LoginWindow
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
            this.passwdTxtBx = new System.Windows.Forms.TextBox();
            this.usernameTxtBx = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.passwdLbl = new System.Windows.Forms.Label();
            this.logInBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.signUpBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwdTxtBx
            // 
            this.passwdTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.passwdTxtBx.Location = new System.Drawing.Point(21, 135);
            this.passwdTxtBx.Name = "passwdTxtBx";
            this.passwdTxtBx.Size = new System.Drawing.Size(252, 26);
            this.passwdTxtBx.TabIndex = 1;
            this.passwdTxtBx.UseSystemPasswordChar = true;
            // 
            // usernameTxtBx
            // 
            this.usernameTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.usernameTxtBx.Location = new System.Drawing.Point(21, 83);
            this.usernameTxtBx.Name = "usernameTxtBx";
            this.usernameTxtBx.Size = new System.Drawing.Size(252, 26);
            this.usernameTxtBx.TabIndex = 2;
            this.usernameTxtBx.TextChanged += new System.EventHandler(this.UsernameTextbox_TextChanged);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Century Gothic", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.nameLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nameLbl.Location = new System.Drawing.Point(12, 9);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(267, 49);
            this.nameLbl.TabIndex = 3;
            this.nameLbl.Text = "Smart Saver";
            this.nameLbl.Click += new System.EventHandler(this.NameLabel_Click);
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.usernameLbl.Location = new System.Drawing.Point(17, 60);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(92, 21);
            this.usernameLbl.TabIndex = 4;
            this.usernameLbl.Text = "Username:";
            // 
            // passwdLbl
            // 
            this.passwdLbl.AutoSize = true;
            this.passwdLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.passwdLbl.Location = new System.Drawing.Point(17, 112);
            this.passwdLbl.Name = "passwdLbl";
            this.passwdLbl.Size = new System.Drawing.Size(86, 21);
            this.passwdLbl.TabIndex = 5;
            this.passwdLbl.Text = "Password:";
            this.passwdLbl.Click += new System.EventHandler(this.PasswordLabel_Click);
            // 
            // logInBtn
            // 
            this.logInBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.logInBtn.Location = new System.Drawing.Point(21, 167);
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Size = new System.Drawing.Size(74, 26);
            this.logInBtn.TabIndex = 6;
            this.logInBtn.Text = "Log In";
            this.logInBtn.UseVisualStyleBackColor = true;
            this.logInBtn.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.exitBtn.Location = new System.Drawing.Point(110, 167);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(74, 26);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // signUpBtn
            // 
            this.signUpBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.signUpBtn.Location = new System.Drawing.Point(199, 167);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(74, 26);
            this.signUpBtn.TabIndex = 8;
            this.signUpBtn.Text = "SignUp";
            this.signUpBtn.UseVisualStyleBackColor = true;
            this.signUpBtn.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(331, 248);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.logInBtn);
            this.Controls.Add(this.passwdLbl);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.usernameTxtBx);
            this.Controls.Add(this.passwdTxtBx);
            this.Name = "LoginWindow";
            this.Text = "Please Log In";
            this.Load += new System.EventHandler(this.LoginWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwdTxtBx;
        private System.Windows.Forms.TextBox usernameTxtBx;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label passwdLbl;
        private System.Windows.Forms.Button logInBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button signUpBtn;
    }
}