using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OurWork2
{
    public partial class MainFrm : MetroForm
    {
        public EventDb db = new EventDb();
        public List<EventDetails> eventDetails = new List<EventDetails>();
        public List<List<Course>> courses = new List<List<Course>>();
        public MainFrm()
        {
            InitializeComponent();
            ClassTool classTool = new ClassTool();
            int thisWeek = classTool.GetThisWeek();
            int dayOfWeek = classTool.GetDayOfWeek();
            courses = GetCourses();
            weekComboBox.SelectedIndexChanged -= new EventHandler(weekComboBox_SelectedIndexChanged);
            dayComboBox.SelectedIndexChanged -= new EventHandler(dayComboBox_SelectedIndexChanged);
            weekComboBox.SelectedIndex = thisWeek - 1;
            dayComboBox.SelectedIndex = dayOfWeek;
            weekComboBox.SelectedIndexChanged += new EventHandler(weekComboBox_SelectedIndexChanged);
            dayComboBox.SelectedIndexChanged += new EventHandler(dayComboBox_SelectedIndexChanged);
            SetListView1(thisWeek, dayOfWeek);
            SetDateLabel();

            eventDetails = db.GetEventDetails();
            SetListView3(eventDetails);
        }

        /// <summary>
        /// 得到数据库中courses
        /// </summary>
        /// <returns>Courses</returns>
        public List<List<Course>> GetCourses()
        {
            List<List<Course>> courses1 = new List<List<Course>>();
            ClassDb classDb = new ClassDb();
            for (int i = 0; i < 7; i++)
            {
                List<Course> courses2 = new List<Course>();
                courses2 = classDb.GetCourses(i);
                courses1.Add(courses2);
            }
            return courses1;
        }

        /// <summary>
        /// 对ListView1进行set操作
        /// </summary>
        /// <param name="week"></param>
        /// <param name="dayOfWeek"></param>
        public void SetListView1(int week, int dayOfWeek)
        {
            ClassTool classTool = new ClassTool();
            List<Course> courses0 = classTool.GetOrderedCourses(courses[dayOfWeek]);
            List<Course> courses1 = new List<Course>();
            foreach (Course a in courses0)
            {
                if (classTool.IfHaveClass(a, week))
                {
                    courses1.Add(a);
                }
            }

            this.listView1.BeginUpdate();
            for (int i = 0; i < courses1.Count; i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = Convert.ToString(courses1[i].name);
                lvi.SubItems.Add(classTool.GetClassroom(courses1[i]));
                lvi.SubItems.Add(courses1[i].teacher);
                lvi.SubItems.Add(classTool.GetClassTime(courses1[i]));
                this.listView1.Items.Add(lvi);
            }
            this.listView1.EndUpdate();
        }


        /// <summary>
        /// 对ListView3进行SET
        /// </summary>
        /// <param name="eventDetails"></param>
        public void SetListView3(List<EventDetails> eventDetails)
        {
            this.listView3.BeginUpdate();
            eventDetails = eventDetails.OrderBy(ed => Calculated.Calculate(ed.createTime.Year, ed.createTime.Month, ed.createTime.Day)).ToList();
            for (int i = 0; i < eventDetails.Count; i++)
            {
                int count = 0;
                DateTime dt = eventDetails[i].createTime;
                int year = dt.Year;
                int month = dt.Month;
                int day = dt.Day;
                count = Calculated.Calculate(year, month, day);
                ListViewItem lvi = new ListViewItem();
                lvi.Text = "距离" + eventDetails[i].courseName + eventDetails[i].eventName;

                if (count > 0)
                {
                    lvi.SubItems.Add("还有" + Convert.ToString(count) + "天");
                }
                else if (count == 0)
                {
                    lvi.SubItems.Add("今日任务");
                }
                else
                {
                    lvi.SubItems.Add("已过期");
                }
                lvi.SubItems.Add(Convert.ToString(eventDetails[i].eventId));
                this.listView3.Items.Add(lvi);
            }
            this.listView3.EndUpdate();
        }

        private void SetDateLabel()
        {
            ClassTool classTool = new ClassTool();
            if (dayComboBox.SelectedIndex == 0)
            {
                dateLabel.Text = classTool.startDay.AddDays((weekComboBox.SelectedIndex) * 7 + 6).ToString("yyyy/MM/dd");
            }
            else
            {
                dateLabel.Text = classTool.startDay.AddDays((weekComboBox.SelectedIndex) * 7 + (dayComboBox.SelectedIndex - 1)).ToString("yyyy/MM/dd");
            }
        }

        private void getClassButton_Click(object sender, EventArgs e)
        {
            LoginFrm f = new LoginFrm(this);
            f.Show();
        }

        /// <summary>
        /// 当选择的周数发生变化时对列表进行修改的方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void weekComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            int slctWeek = weekComboBox.SelectedIndex + 1;
            int slctDay = dayComboBox.SelectedIndex;
            SetListView1(slctWeek, slctDay);
            SetDateLabel();
        }

        /// <summary>
        ///  当选择的星期发生变化时对列表进行修改的方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dayComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            int slctWeek = weekComboBox.SelectedIndex + 1;
            int slctDay = dayComboBox.SelectedIndex;
            SetListView1(slctWeek, slctDay);
            SetDateLabel();
        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 实现鼠标悬停在ListView上显示相关信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView1_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            ToolTip toolTip = new ToolTip();

            string itemInfor =
            "课程名称：" + e.Item.Text + "\n" +
            "上课教室：" + e.Item.SubItems[1].Text + "\n" +
            "任课老师：" + e.Item.SubItems[2].Text + "\n" +
            "其他安排：" + "\n";

            List<EventDetails> eventDetails = db.GetEventDetails(e.Item.Text);
            eventDetails = eventDetails.OrderBy(ed => Calculated.Calculate(ed.createTime.Year, ed.createTime.Month, ed.createTime.Day)).ToList();
            foreach (var a in eventDetails)
            {
                string rstStr = "距离：";
                DateTime dt = a.createTime;
                int year = dt.Year;
                int month = dt.Month;
                int day = dt.Day;
                int count = Calculated.Calculate(year, month, day);
                rstStr += a.eventName;
                if (count >= 0)
                {
                    rstStr += "还有" + Convert.ToString(count) + "天\n";
                }
                else
                {
                    rstStr = a.eventName + "时间已过\n";
                }
                itemInfor += rstStr;
            }
            toolTip.SetToolTip((e.Item).ListView, itemInfor);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                if (listView1.SelectedItems.Count != 0)
                {
                    string className = listView1.SelectedItems[0].Text;
                    AddDetailFrm f = new AddDetailFrm(this, className,1);
                    f.Show();
                }
                else
                {
                    MessageBox.Show("请选择课程！", "错误");
                }
            }
            if (tabControl1.SelectedIndex == 1)
            {

            }
            if (tabControl1.SelectedIndex == 2)
            {
                AddDetailFrm f = new AddDetailFrm(this,3);
                f.Show();
            }
        }

        private void listView3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditDetailFrm f = new EditDetailFrm(this);
            f.Show();
        }

        private void updataButton_Click(object sender, EventArgs e)
        {
            eventDetails = db.GetEventDetails();
            var query = eventDetails.Where(ed => Calculated.Calculate(ed.createTime.Year, ed.createTime.Month, ed.createTime.Day) <= 0);
            List<EventDetails> unEventDetails = query.ToList();
            for (int i = 0; i < unEventDetails.Count; i++)
            {
                db.deleteEvent(unEventDetails[i]);
                eventDetails.Remove(unEventDetails[i]);
            }
            listView3.Items.Clear();
            SetListView3(eventDetails);
            return;
        }
    }
}
