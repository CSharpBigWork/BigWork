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
    public partial class AddDetailFrm : MetroForm
    {
        MainFrm mainFrm;
        string className;
        int listNumber;
        public AddDetailFrm(MainFrm mainFrm,string className,int listNumber)
        {
            InitializeComponent();
            this.mainFrm = mainFrm;this.className = className;
            this.listNumber = listNumber;
        }
        public AddDetailFrm(MainFrm mainFrm,int listNumber)
        {
            InitializeComponent();
            this.mainFrm = mainFrm;
            this.listNumber = listNumber;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (listNumber == 1)
            {
                string detail = detailTextBox.Text;
                DateTime date = DateTime.Parse(dateTime.Text);
                EventDb db = new EventDb();
                EventDetails eventDetails = new EventDetails();
                eventDetails.eventName = detail;
                eventDetails.createTime = date;
                eventDetails.courseName = className;
                db.AddEvent(eventDetails);
                mainFrm.eventDetails = mainFrm.db.GetEventDetails();
                mainFrm.listView3.Items.Clear();
                mainFrm.SetListView3(mainFrm.eventDetails);
                this.Dispose();
            }
            else if (listNumber == 3)
            {
                if (detailTextBox.Text == "")
                {
                    MessageBox.Show("请设置事件！");
                    return;
                }
                else
                {
                    DateTime dt = DateTime.Parse(this.dateTime.Text);
                    int year = dt.Year;
                    int month = dt.Month;
                    int day = dt.Day;
                    int count = Calculated.Calculate(year, month, day);
                    if (count < 0)
                    {
                        MessageBox.Show("抱歉，日期选择出错！");
                    }
                    else
                    {
                        EventDetails ev = new EventDetails();
                        ev.eventName = detailTextBox.Text;
                        ev.createTime = dt;
                        ev.courseName = "";
                        mainFrm.db.AddEvent(ev);
                        mainFrm.eventDetails = mainFrm.db.GetEventDetails();
                        mainFrm.listView3.Items.Clear();
                        mainFrm.SetListView3(mainFrm.eventDetails);
                        this.Dispose();
                        return;
                    }
                }
            }
        }
    }
}
