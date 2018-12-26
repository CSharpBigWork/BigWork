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
    public partial class AddScheduleFrm : MetroForm
    {
        Event result = new Event();
        MainFrm mainFrm;
        public AddScheduleFrm(Event e, MainFrm mainFrm)
        {
            InitializeComponent();
            this.mainFrm = mainFrm;
            evtSource.DataSource = e;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            ((Event)evtSource.Current).dateKey = DateTime.Parse(mainFrm.getTP().ToShortDateString() + " "
            + this.dateTimePicker.Value.ToShortTimeString());
            result = (Event)evtSource.Current;
            this.Close();
        }

        public Event getResult()
        {
            return result;
        }

    }
}
