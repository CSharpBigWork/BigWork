namespace OurWork2
{
    partial class EditDetailFrm
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
            this.submitEditButton = new MetroFramework.Controls.MetroButton();
            this.deleteButton = new MetroFramework.Controls.MetroButton();
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
            this.detailTextBox.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.detailTextBox.CustomButton.Name = "";
            this.detailTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.detailTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.detailTextBox.CustomButton.TabIndex = 1;
            this.detailTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.detailTextBox.CustomButton.UseSelectable = true;
            this.detailTextBox.CustomButton.Visible = false;
            this.detailTextBox.Lines = new string[0];
            this.detailTextBox.Location = new System.Drawing.Point(102, 73);
            this.detailTextBox.MaxLength = 32767;
            this.detailTextBox.Name = "detailTextBox";
            this.detailTextBox.PasswordChar = '\0';
            this.detailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.detailTextBox.SelectedText = "";
            this.detailTextBox.SelectionLength = 0;
            this.detailTextBox.SelectionStart = 0;
            this.detailTextBox.ShortcutsEnabled = true;
            this.detailTextBox.Size = new System.Drawing.Size(139, 23);
            this.detailTextBox.TabIndex = 0;
            this.detailTextBox.UseSelectable = true;
            this.detailTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.detailTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(102, 119);
            this.dateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(139, 29);
            this.dateTime.TabIndex = 1;
            // 
            // submitEditButton
            // 
            this.submitEditButton.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.submitEditButton.Location = new System.Drawing.Point(42, 176);
            this.submitEditButton.Name = "submitEditButton";
            this.submitEditButton.Size = new System.Drawing.Size(75, 23);
            this.submitEditButton.TabIndex = 2;
            this.submitEditButton.Text = "确定修改";
            this.submitEditButton.UseSelectable = true;
            this.submitEditButton.Click += new System.EventHandler(this.submitEditButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.deleteButton.Location = new System.Drawing.Point(164, 176);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(77, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "确定删除";
            this.deleteButton.UseSelectable = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(42, 77);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "事件：";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(42, 129);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(51, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "日期：";
            // 
            // EditDetailFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 231);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.submitEditButton);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.detailTextBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(285, 231);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(285, 231);
            this.Name = "EditDetailFrm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "EditDetail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox detailTextBox;
        private MetroFramework.Controls.MetroDateTime dateTime;
        private MetroFramework.Controls.MetroButton submitEditButton;
        private MetroFramework.Controls.MetroButton deleteButton;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}