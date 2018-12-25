namespace OurWork2
{
    partial class MainFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.tabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.listView1 = new MetroFramework.Controls.MetroListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.listView3 = new MetroFramework.Controls.MetroListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.weekComboBox = new MetroFramework.Controls.MetroComboBox();
            this.dayComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.getClassButton = new MetroFramework.Controls.MetroButton();
            this.updataButton = new MetroFramework.Controls.MetroButton();
            this.addButton = new MetroFramework.Controls.MetroButton();
            this.dateLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.metroTabPage1);
            this.tabControl1.Controls.Add(this.metroTabPage2);
            this.tabControl1.Controls.Add(this.metroTabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(412, 186);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.listView1);
            this.metroTabPage1.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(404, 144);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "课程安排";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listView1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(0, 3);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.OwnerDraw = true;
            this.listView1.Size = new System.Drawing.Size(404, 141);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.UseSelectable = true;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.listView1_ItemMouseHover);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "课程名称";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "上课教室";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "任课老师";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "上课时间";
            this.columnHeader5.Width = 100;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.listView3);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(404, 144);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "日期提醒";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // listView3
            // 
            this.listView3.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader1});
            this.listView3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listView3.ForeColor = System.Drawing.SystemColors.Menu;
            this.listView3.FullRowSelect = true;
            this.listView3.Location = new System.Drawing.Point(0, 3);
            this.listView3.Name = "listView3";
            this.listView3.OwnerDraw = true;
            this.listView3.Size = new System.Drawing.Size(404, 141);
            this.listView3.TabIndex = 5;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.UseSelectable = true;
            this.listView3.View = System.Windows.Forms.View.Details;
            this.listView3.SelectedIndexChanged += new System.EventHandler(this.listView3_SelectedIndexChanged);
            this.listView3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView3_MouseDoubleClick);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "事件";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 280;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "倒计时";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 105;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 0;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(404, 144);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "日程安排";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.tabControl1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 104);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(412, 186);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // weekComboBox
            // 
            this.weekComboBox.FormattingEnabled = true;
            this.weekComboBox.ItemHeight = 23;
            this.weekComboBox.Items.AddRange(new object[] {
            "第1周",
            "第2周",
            "第3周",
            "第4周",
            "第5周",
            "第6周",
            "第7周",
            "第8周",
            "第9周",
            "第10周",
            "第11周",
            "第12周",
            "第13周",
            "第14周",
            "第15周",
            "第16周",
            "第17周",
            "第18周",
            "第19周",
            "第20周"});
            this.weekComboBox.Location = new System.Drawing.Point(4, 8);
            this.weekComboBox.Name = "weekComboBox";
            this.weekComboBox.Size = new System.Drawing.Size(72, 29);
            this.weekComboBox.TabIndex = 2;
            this.weekComboBox.UseSelectable = true;
            this.weekComboBox.SelectedIndexChanged += new System.EventHandler(this.weekComboBox_SelectedIndexChanged);
            // 
            // dayComboBox
            // 
            this.dayComboBox.FormattingEnabled = true;
            this.dayComboBox.ItemHeight = 23;
            this.dayComboBox.Items.AddRange(new object[] {
            "周日",
            "周一",
            "周二",
            "周三",
            "周四",
            "周五",
            "周六"});
            this.dayComboBox.Location = new System.Drawing.Point(104, 8);
            this.dayComboBox.Name = "dayComboBox";
            this.dayComboBox.Size = new System.Drawing.Size(64, 29);
            this.dayComboBox.TabIndex = 3;
            this.dayComboBox.UseSelectable = true;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.getClassButton);
            this.metroPanel2.Controls.Add(this.updataButton);
            this.metroPanel2.Controls.Add(this.weekComboBox);
            this.metroPanel2.Controls.Add(this.addButton);
            this.metroPanel2.Controls.Add(this.dayComboBox);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(20, 60);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(412, 44);
            this.metroPanel2.TabIndex = 5;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // getClassButton
            // 
            this.getClassButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("getClassButton.BackgroundImage")));
            this.getClassButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.getClassButton.Location = new System.Drawing.Point(284, 8);
            this.getClassButton.Name = "getClassButton";
            this.getClassButton.Size = new System.Drawing.Size(30, 30);
            this.getClassButton.TabIndex = 5;
            this.getClassButton.UseSelectable = true;
            this.getClassButton.Click += new System.EventHandler(this.getClassButton_Click);
            // 
            // updataButton
            // 
            this.updataButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updataButton.BackgroundImage")));
            this.updataButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.updataButton.Location = new System.Drawing.Point(331, 7);
            this.updataButton.Name = "updataButton";
            this.updataButton.Size = new System.Drawing.Size(30, 30);
            this.updataButton.TabIndex = 8;
            this.updataButton.UseSelectable = true;
            this.updataButton.Click += new System.EventHandler(this.updataButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addButton.BackgroundImage")));
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addButton.Location = new System.Drawing.Point(378, 7);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(30, 30);
            this.addButton.TabIndex = 6;
            this.addButton.UseSelectable = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("方正兰亭超细黑简体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateLabel.Location = new System.Drawing.Point(300, 35);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(90, 22);
            this.dateLabel.TabIndex = 7;
            this.dateLabel.Text = "日期显示";
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(452, 310);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "AfterEight";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.tabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage3.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton addButton;
        private MetroFramework.Controls.MetroButton getClassButton;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        public MetroFramework.Controls.MetroComboBox weekComboBox;
        public MetroFramework.Controls.MetroComboBox dayComboBox;
        public MetroFramework.Controls.MetroListView listView3;
        public MetroFramework.Controls.MetroListView listView1;
        private System.Windows.Forms.Label dateLabel;
        private MetroFramework.Controls.MetroButton updataButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

