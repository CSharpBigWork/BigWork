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
    public partial class EditDetailFrm : MetroForm
    {
        EventDetails ed = new EventDetails();
        public static List<EventDetails> eventDetails = new List<EventDetails>();
        MainFrm mainFrm;
        public EditDetailFrm(MainFrm mainFrm)
        {
            InitializeComponent();
            this.mainFrm = mainFrm;
            int i = Convert.ToInt32(mainFrm.listView3.SelectedItems[0].SubItems[2].Text);
            ed = mainFrm.db.GetEvents(i);
            dateTime.Value = mainFrm.db.GetEvents(i).createTime;
            detailTextBox.Text = mainFrm.db.GetEvents(i).eventName;
        }

        private void submitEditButton_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Parse(dateTime.Text);
            int year = dt.Year;
            int month = dt.Month;
            int day = dt.Day;
            int count = Calculated.Calculate(year, month, day);
            if (count <= 0)
            {
                MessageBox.Show("抱歉，日期选择出错！");
            }
            else
            {
                ed.eventName = detailTextBox.Text;
                ed.createTime = dt;
                mainFrm.db.edit(ed);
                MessageBox.Show("修改成功！");
                mainFrm.eventDetails = mainFrm.db.GetEventDetails();
                mainFrm.listView3.Items.Clear();
                mainFrm.SetListView3(mainFrm.eventDetails);
            }
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            eventDetails = mainFrm.db.GetEventDetails();
            ed.eventName = detailTextBox.Text;
            ed.createTime = DateTime.Parse(dateTime.Text);
            mainFrm.db.deleteEvent(ed);
            MessageBox.Show("删除成功！");
            mainFrm.eventDetails = mainFrm.db.GetEventDetails();
            mainFrm.listView3.Items.Clear();
            mainFrm.SetListView3(mainFrm.eventDetails);
            this.Close();
        }
    }
}
