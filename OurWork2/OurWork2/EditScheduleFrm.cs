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
    public partial class EditScheduleFrm : MetroForm
    {
        Event result = new Event();
        MainFrm mainFrm;
        public EditScheduleFrm(Event e, MainFrm mainFrm)
        {
            InitializeComponent();
            this.mainFrm = mainFrm;
            this.dateTimePicker.Value = DateTime.Parse(mainFrm.getSelctTime());
            evtSource.DataSource = e;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            ((Event)evtSource.Current).dateKey = DateTime.Parse(mainFrm.getTP().ToShortDateString() + " "
                + this.dateTimePicker.Value.ToShortTimeString());
            result = (Event)evtSource.Current;
            Event evt = result;
            String dt = mainFrm.dateLabel.Text;
            string tString = mainFrm.listView2.SelectedItems[0].SubItems[0].Text;
            Schedule sch = mainFrm.s.GetByDate(dt);
            string _dt = dt + " " + tString;
            if (!evt.dateKey.Equals(DateTime.MinValue))
            {
                mainFrm.evtDb.Edit(evt, _dt);
                mainFrm.UpdateSch(sch, dt);
                mainFrm.SetListView2(sch.Events);
            }
            this.Dispose();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            String dt = mainFrm.dateLabel.Text;
            Schedule sch = mainFrm.s.GetByDate(dt);
            if (mainFrm.listView2.SelectedItems.Count != 0)
            {
                string tString = mainFrm.listView2.SelectedItems[0].SubItems[0].Text;
                mainFrm.evtDb.Delete(dt + " " + tString);
                mainFrm.UpdateSch(sch, dt);
                mainFrm.SetListView2(sch.Events);
                MessageBox.Show("删除成功!");
            }
            else
            {
                MessageBox.Show("请选择事件！", "错误");
            }
            this.Dispose();
        }

        public Event getResult()
        {
            return result;
        }

        private void EditScheduleFrm_Load(object sender, EventArgs e)
        {
            this.dateTimePicker.Value = DateTime.Parse(mainFrm.getSelctTime());
        }
    }
}
