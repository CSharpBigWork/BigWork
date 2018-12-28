using MetroFramework.Forms;
using Newtonsoft.Json;
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
    public partial class LoginFrm : MetroForm
    {
        MainFrm mainFrm;
        public LoginFrm(MainFrm mainFrm)
        {
            InitializeComponent();
            this.mainFrm = mainFrm;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            List<List<Course>> courses = new List<List<Course>>();
            string userName = userNameTextBox.Text;
            string password = passwordTextBox.Text;
            string rstStr = "id=" + userName + "&" + "password=" + password;
            GetResponse getResponse = new GetResponse();
            string jsonStr = getResponse.HttpPost("http://47.100.30.233/courses", rstStr);
            Response response = JsonConvert.DeserializeObject<Response>(jsonStr);
            if (response.success == "false")
            {
                MessageBox.Show(response.message, "错误");
                return;
            }
            courses = response.data;
            ClassDb classDb = new ClassDb();
            classDb.ClearCoursesTable();
            foreach (var courses1 in courses)
            {
                foreach (Course course in courses1)
                {
                    classDb.AddRowInDataSet(course);
                }
            }
            mainFrm.courses = mainFrm.GetCourses();
            int slctWeek = mainFrm.weekComboBox.SelectedIndex + 1;
            int slctDay = mainFrm.dayComboBox.SelectedIndex;
            mainFrm.db.deleteClassDetail();
            mainFrm.listView1.Items.Clear();
            mainFrm.listView3.Items.Clear();
            mainFrm.eventDetails = mainFrm.db.GetEventDetails();
            mainFrm.SetListView3(mainFrm.eventDetails);
            mainFrm.SetListView1(slctWeek, slctDay);
            this.Dispose();
        }
    }
}
