namespace SmartSaver.Forms
{
    partial class Settings
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
            this.CustomizeComboBox = new System.Windows.Forms.ComboBox();
            this.AddNewChoiceButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.CustomizeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CustomizeComboBox
            // 
            this.CustomizeComboBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.CustomizeComboBox.FormattingEnabled = true;
            this.CustomizeComboBox.Location = new System.Drawing.Point(12, 34);
            this.CustomizeComboBox.Name = "CustomizeComboBox";
            this.CustomizeComboBox.Size = new System.Drawing.Size(124, 29);
            this.CustomizeComboBox.TabIndex = 0;
            // 
            // AddNewChoiceButton
            // 
            this.AddNewChoiceButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddNewChoiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewChoiceButton.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.AddNewChoiceButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddNewChoiceButton.Location = new System.Drawing.Point(12, 69);
            this.AddNewChoiceButton.Name = "AddNewChoiceButton";
            this.AddNewChoiceButton.Size = new System.Drawing.Size(124, 29);
            this.AddNewChoiceButton.TabIndex = 1;
            this.AddNewChoiceButton.Text = "Add New";
            this.AddNewChoiceButton.UseVisualStyleBackColor = false;
            this.AddNewChoiceButton.Click += new System.EventHandler(this.AddNewChoiceButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.RemoveButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RemoveButton.Location = new System.Drawing.Point(12, 104);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(124, 29);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // CustomizeLabel
            // 
            this.CustomizeLabel.AutoSize = true;
            this.CustomizeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.CustomizeLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.CustomizeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CustomizeLabel.Location = new System.Drawing.Point(12, 9);
            this.CustomizeLabel.Name = "CustomizeLabel";
            this.CustomizeLabel.Size = new System.Drawing.Size(95, 21);
            this.CustomizeLabel.TabIndex = 3;
            this.CustomizeLabel.Text = "Customize:";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1076, 483);
            this.Controls.Add(this.CustomizeLabel);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddNewChoiceButton);
            this.Controls.Add(this.CustomizeComboBox);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CustomizeComboBox;
        private System.Windows.Forms.Button AddNewChoiceButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Label CustomizeLabel;
    }
}