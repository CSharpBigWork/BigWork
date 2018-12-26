namespace OurWork2
{
    partial class AddScheduleFrm
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
            this.components = new System.ComponentModel.Container();
            this.textBox = new MetroFramework.Controls.MetroTextBox();
            this.submitButton = new MetroFramework.Controls.MetroButton();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.evtSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.evtSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox
            // 
            // 
            // 
            // 
            this.textBox.CustomButton.Image = null;
            this.textBox.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.textBox.CustomButton.Name = "";
            this.textBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox.CustomButton.TabIndex = 1;
            this.textBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox.CustomButton.UseSelectable = true;
            this.textBox.CustomButton.Visible = false;
            this.textBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.evtSource, "Events", true));
            this.textBox.Lines = new string[0];
            this.textBox.Location = new System.Drawing.Point(95, 90);
            this.textBox.MaxLength = 32767;
            this.textBox.Name = "textBox";
            this.textBox.PasswordChar = '\0';
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox.SelectedText = "";
            this.textBox.SelectionLength = 0;
            this.textBox.SelectionStart = 0;
            this.textBox.ShortcutsEnabled = true;
            this.textBox.Size = new System.Drawing.Size(148, 23);
            this.textBox.TabIndex = 0;
            this.textBox.UseSelectable = true;
            this.textBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // submitButton
            // 
            this.submitButton.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.submitButton.Location = new System.Drawing.Point(95, 134);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(148, 23);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "确认添加";
            this.submitButton.UseSelectable = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "HH:mm";
            this.dateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.evtSource, "dateKey", true));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(23, 90);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.ShowUpDown = true;
            this.dateTimePicker.Size = new System.Drawing.Size(56, 21);
            this.dateTimePicker.TabIndex = 3;
            // 
            // evtSource
            // 
            this.evtSource.DataSource = typeof(OurWork2.Event);
            // 
            // AddScheduleFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 197);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.textBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(274, 197);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(274, 197);
            this.Name = "AddScheduleFrm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "AddSchedule";
            ((System.ComponentModel.ISupportInitialize)(this.evtSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox textBox;
        private MetroFramework.Controls.MetroButton submitButton;
        private System.Windows.Forms.BindingSource evtSource;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}