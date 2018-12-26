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
        public scheduleService s = new scheduleService();
        public ScheduleDb evtDb = new ScheduleDb();
        public DateTime date;
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

            //载入所有事件到sheduleService
            foreach (string dt in evtDb.getAllDate())
            {
                Schedule schedule = new Schedule(dt);
                foreach (Event evt in evtDb.GetEvents(dt))
                    if (evtDb.GetEvents(dt).Count > 0)
                        schedule.AddEvents(evt);
                s.AddSchedule(schedule);
            }
            //载入当天事件显示在listview上
            date = DateTime.Now;
            Schedule sch;
            if (s.GetByDate(date.ToShortDateString()) != null)
                sch = s.GetByDate(date.ToShortDateString());
            else
            {
                sch = new Schedule(date.ToShortDateString());
                s.AddSchedule(sch);
            }
            SetListView2(sch.Events);

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
        /// 更新listview2
        /// </summary>
        /// <param name="evt"></param>
        public void SetListView2(List<Event> evt)
        {
            this.listView2.Items.Clear();
            this.listView2.BeginUpdate();
            foreach (Event _e in evt)
            {
                ListViewItem item = new ListViewItem(_e.dateKey.ToShortTimeString());
                item.SubItems.Add(_e.Events);
                this.listView2.Items.Add(item);
            }
            this.listView2.EndUpdate();
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
                    AddDetailFrm f = new AddDetailFrm(this, className, 1);
                    f.Show();
                }
                else
                {
                    MessageBox.Show("请选择课程！", "错误");
                }
            }
            if (tabControl1.SelectedIndex == 1)
            {
                AddScheduleFrm f = new AddScheduleFrm(new Event(), this);
                f.ShowDialog();
                Schedule sch;
                String dt = dateLabel.Text;
                if (s.GetByDate(dt) != null)
                    sch = s.GetByDate(dt);
                else
                {
                    sch = new Schedule(dt);
                    s.AddSchedule(sch);
                }
                Event evt = f.getResult();
                if (evt.Events != null)
                {
                    evtDb.AddRowInDataSet(evt);
                }
                UpdateSch(sch, dt);
                SetListView2(sch.Events);
            }
            if (tabControl1.SelectedIndex == 2)
            {
                AddDetailFrm f = new AddDetailFrm(this, 3);
                f.Show();
            }
        }

        /// <summary>
        /// 获取当前选择日期
        /// </summary>
        /// <returns></returns>
        public DateTime getTP()
        {
            DateTime dt = DateTime.Parse(dateLabel.Text);
            return dt;
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

        /// <summary>
        /// 更改后刷新日程
        /// </summary>
        /// <param name="s"></param>
        /// <param name="dt"></param>
        public void UpdateSch(Schedule s, string dt)
        {
            s.RemoveAllEvents();
            foreach (Event _evt in evtDb.GetEvents(dt))
                if (evtDb.GetEvents(dt).Count > 0)
                    s.AddEvents(_evt);
        }

        private void dateLabel_TextChanged(object sender, EventArgs e)
        {
            Schedule sch;
            String dt = dateLabel.Text;
            if (s.GetByDate(dt) != null)
                sch = s.GetByDate(dt);
            else
            {
                sch = new Schedule(dt);
                s.AddSchedule(sch);
            }
            SetListView2(sch.Events);
        }

        /// <summary>
        /// 获取listview选择行的时间信息
        /// </summary>
        /// <returns></returns>
        public string getSelctTime()
        {
            return listView2.SelectedItems[0].SubItems[0].Text;
        }

        private void listView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string evts = this.listView2.SelectedItems[0].SubItems[1].Text;
            Event _evt = new Event(evts);
            EditScheduleFrm f = new EditScheduleFrm(_evt, this);
            f.Show();
        }
    }
}
