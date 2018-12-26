namespace OurWork2
{
    partial class EditScheduleFrm
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
            this.editButton = new MetroFramework.Controls.MetroButton();
            this.deleteButton = new MetroFramework.Controls.MetroButton();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.evtSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.evtSource)).BeginInit();
            this.SuspendLayout();
            // 
            // editButton
            // 
            this.editButton.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.editButton.Location = new System.Drawing.Point(34, 113);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(103, 23);
            this.editButton.TabIndex = 0;
            this.editButton.Text = "确认修改";
            this.editButton.UseSelectable = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.deleteButton.Location = new System.Drawing.Point(174, 113);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 23);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "确认删除";
            this.deleteButton.UseSelectable = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "HH：mm";
            this.dateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.evtSource, "dateKey", true));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(34, 74);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.ShowUpDown = true;
            this.dateTimePicker.Size = new System.Drawing.Size(74, 21);
            this.dateTimePicker.TabIndex = 2;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.evtSource, "Events", true));
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(126, 74);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(148, 23);
            this.metroTextBox1.TabIndex = 3;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // evtSource
            // 
            this.evtSource.DataSource = typeof(OurWork2.Event);
            // 
            // EditScheduleFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 171);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(308, 171);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(308, 171);
            this.Name = "EditScheduleFrm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "EditSchedule";
            this.Load += new System.EventHandler(this.EditScheduleFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.evtSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton editButton;
        private MetroFramework.Controls.MetroButton deleteButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.BindingSource evtSource;
    }
}