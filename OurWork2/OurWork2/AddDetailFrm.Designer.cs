namespace OurWork2
{
    partial class AddDetailFrm
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
            this.detailTextBox = new MetroFramework.Controls.MetroTextBox();
            this.dateTime = new MetroFramework.Controls.MetroDateTime();
            this.submitButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // detailTextBox
            // 
            // 
            // 
            // 
            this.detailTextBox.CustomButton.Image = null;
            this.detailTextBox.CustomButton.Location = new System.Drawing.Point(158, 1);
            this.detailTextBox.CustomButton.Name = "";
            this.detailTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.detailTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.detailTextBox.CustomButton.TabIndex = 1;
            this.detailTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.detailTextBox.CustomButton.UseSelectable = true;
            this.detailTextBox.CustomButton.Visible = false;
            this.detailTextBox.Lines = new string[0];
            this.detailTextBox.Location = new System.Drawing.Point(82, 80);
            this.detailTextBox.MaxLength = 32767;
            this.detailTextBox.Name = "detailTextBox";
            this.detailTextBox.PasswordChar = '\0';
            this.detailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.detailTextBox.SelectedText = "";
            this.detailTextBox.SelectionLength = 0;
            this.detailTextBox.SelectionStart = 0;
            this.detailTextBox.ShortcutsEnabled = true;
            this.detailTextBox.Size = new System.Drawing.Size(134, 25);
            this.detailTextBox.TabIndex = 0;
            this.detailTextBox.UseSelectable = true;
            this.detailTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.detailTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(82, 130);
            this.dateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(134, 29);
            this.dateTime.TabIndex = 1;
            // 
            // submitButton
            // 
            this.submitButton.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.submitButton.Location = new System.Drawing.Point(25, 177);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(191, 23);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "确认";
            this.submitButton.UseSelectable = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(25, 80);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "事件：";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(25, 132);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(51, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "日期：";
            // 
            // AddDetailFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 228);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.detailTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDetailFrm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "AddDetail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox detailTextBox;
        private MetroFramework.Controls.MetroDateTime dateTime;
        private MetroFramework.Controls.MetroButton submitButton;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}