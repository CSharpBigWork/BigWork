namespace OurWork2
{
    partial class LoginFrm
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
            this.userNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.passwordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.submitButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.checkBox = new MetroFramework.Controls.MetroCheckBox();
            this.SuspendLayout();
            // 
            // userNameTextBox
            // 
            // 
            // 
            // 
            this.userNameTextBox.CustomButton.Image = null;
            this.userNameTextBox.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.userNameTextBox.CustomButton.Name = "";
            this.userNameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.userNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.userNameTextBox.CustomButton.TabIndex = 1;
            this.userNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.userNameTextBox.CustomButton.UseSelectable = true;
            this.userNameTextBox.CustomButton.Visible = false;
            this.userNameTextBox.Lines = new string[0];
            this.userNameTextBox.Location = new System.Drawing.Point(86, 72);
            this.userNameTextBox.MaxLength = 32767;
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.PasswordChar = '\0';
            this.userNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userNameTextBox.SelectedText = "";
            this.userNameTextBox.SelectionLength = 0;
            this.userNameTextBox.SelectionStart = 0;
            this.userNameTextBox.ShortcutsEnabled = true;
            this.userNameTextBox.Size = new System.Drawing.Size(136, 23);
            this.userNameTextBox.TabIndex = 0;
            this.userNameTextBox.UseSelectable = true;
            this.userNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.userNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // passwordTextBox
            // 
            // 
            // 
            // 
            this.passwordTextBox.CustomButton.Image = null;
            this.passwordTextBox.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.passwordTextBox.CustomButton.Name = "";
            this.passwordTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.passwordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordTextBox.CustomButton.TabIndex = 1;
            this.passwordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwordTextBox.CustomButton.UseSelectable = true;
            this.passwordTextBox.CustomButton.Visible = false;
            this.passwordTextBox.Lines = new string[0];
            this.passwordTextBox.Location = new System.Drawing.Point(86, 114);
            this.passwordTextBox.MaxLength = 32767;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.SelectionLength = 0;
            this.passwordTextBox.SelectionStart = 0;
            this.passwordTextBox.ShortcutsEnabled = true;
            this.passwordTextBox.Size = new System.Drawing.Size(136, 23);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.UseSelectable = true;
            this.passwordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.White;
            this.submitButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.submitButton.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.submitButton.Location = new System.Drawing.Point(122, 153);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(100, 23);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "确认";
            this.submitButton.UseSelectable = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(29, 72);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "学号：";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(29, 114);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(51, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "密码：";
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(32, 157);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(75, 15);
            this.checkBox.TabIndex = 5;
            this.checkBox.Text = "记住密码";
            this.checkBox.UseSelectable = true;
            // 
            // LoginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 207);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.passwordTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginFrm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox userNameTextBox;
        private MetroFramework.Controls.MetroTextBox passwordTextBox;
        private MetroFramework.Controls.MetroButton submitButton;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroCheckBox checkBox;
    }
}