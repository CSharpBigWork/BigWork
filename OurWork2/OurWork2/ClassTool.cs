using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurWork2
{
    /// <summary>
    /// ClassTool类是为得到课表所进行的相关方法的集合
    /// </summary>
    class ClassTool
    {
        public DateTime startDay = new DateTime(2018, 09, 03, 00, 00, 00);
        string[] fromTime = { "08:00", "08:50", "09:50", "10:40", "11:30", "14:05", "14:55", "15:45", "16:40", "17:30", "18:30", "19:20", "20:10" };
        string[] endTime = { "08:45", "09:35", "10:35", "11:25", "12:15", "14:50", "15:40", "16:30", "17:25", "18:15", "19:15", "20:05", "20:55" };
        /// <summary>
        /// 得到当前的周数
        /// </summary>
        /// <returns>返回值为当前周</returns>
        public int GetThisWeek()
        {
            int week = 1;
            //DateTime startDay = new DateTime(2018, 09, 03, 00, 00, 00);
            DateTime dateTime = DateTime.Now;
            TimeSpan dayNum = dateTime.Subtract(startDay);
            week = Convert.ToInt32(dayNum.Days.ToString()) / 7 + 1;
            return week;
        }


        /// <summary>
        /// 得到当前为星期几
        /// </summary>
        /// <returns>星期所对应的id</returns>
        public int GetDayOfWeek()
        {
            int dayOfWeek = 0;
            string dt = DateTime.Today.DayOfWeek.ToString();
            switch (dt)
            {
                case "Monday":
                    dayOfWeek = 1;
                    break;
                case "Tuesday":
                    dayOfWeek = 2;
                    break;
                case "Wednesday":
                    dayOfWeek = 3;
                    break;
                case "Thursday":
                    dayOfWeek = 4;
                    break;
                case "Friday":
                    dayOfWeek = 5;
                    break;
                case "Saturday":
                    dayOfWeek = 6;
                    break;
                case "Sunday":
                    dayOfWeek = 0;
                    break;
            }
            return dayOfWeek;
        }

        /// <summary>
        /// 用于确定这节课在某周是否需要上
        /// </summary>
        /// <param name="course"></param>
        /// <returns>boolean</returns>
        public bool IfHaveClass(Course course, int week)
        {
            //首先判断是否在周数内
            if (course.fromWeek > week || course.endWeek < week)
            {
                return false;
            }
            //判断这周是否用上课
            if (course.interval != 1)
            {
                int interval = course.interval;
                if (course.fromWeek % interval == week % interval)
                {
                    return true;
                }
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 确定当日上课顺序
        /// </summary>
        /// <param name="courses"></param>
        /// <returns>排序好的当日课表</returns>
        public List<Course> GetOrderedCourses(List<Course> courses)
        {
            List<Course> rslList = courses.OrderBy(a => a.fromClass).ToList();
            return rslList;
        }

        /// <summary>
        /// 得到一节课的上课时间
        /// </summary>
        /// <returns>上课时间</returns>
        public string GetClassTime(Course course)
        {
            string classTime = null;
            int fromIndex = course.fromClass - 1;
            int endIndex = course.endClass - 1;
            classTime = fromTime[fromIndex] + "-" + endTime[endIndex];
            return classTime;
        }

        /// <summary>
        /// 获得上课地点
        /// </summary>
        /// <param name="course"></param>
        /// <returns>上课地点</returns>
        public string GetClassroom(Course course)
        {
            string classroom = null;
            if (course.classroom == "")
            {
                classroom = course.note;
            }
            else
            {
                classroom = course.area + "，" + course.classroom;
            }
            return classroom;
        }

    }
}
