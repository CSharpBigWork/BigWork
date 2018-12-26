using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurWork
{
    class ClassDb
    {
        public MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(
                "datasource=localhost;username=root;" +
                "password=123456;database=csharpbigwork;charset=utf8");
            connection.Open();
            return connection;
        }

        public void AddRowInDataSet(Course course)
        {
            using (MySqlConnection conn = GetConnection())
            {
                String sql = "SELECT * FROM courses";
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn))
                {
                    MySqlCommandBuilder cmdBuilder = new MySqlCommandBuilder(dataAdapter);
                    using (DataSet ds = new DataSet())
                    {
                        dataAdapter.Fill(ds);
                        DataRow newRow = ds.Tables[0].NewRow();
                        newRow[1] = course.name;
                        newRow[2] = course.teacher;
                        newRow[3] = course.fromWeek;
                        newRow[4] = course.endWeek;
                        newRow[5] = course.fromClass;
                        newRow[6] = course.endClass;
                        newRow[7] = course.day;
                        newRow[8] = course.area;
                        newRow[9] = course.classroom;
                        newRow[10] = course.interval;
                        newRow[11] = course.note;
                        newRow[12] = course.detail;
                        ds.Tables[0].Rows.Add(newRow);
                        dataAdapter.Update(ds);
                    }
                }
            }
        }

        public void ClearCoursesTable()
        {
            using (MySqlConnection connection = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand
                ("TRUNCATE TABLE courses", connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Course> GetCourses(int day)
        {
            List<Course> courses = new List<Course>();
            using (MySqlConnection conn = GetConnection())
            {
                String sql = "SELECT * FROM courses";
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn))
                {
                    using (DataSet ds = new DataSet())
                    {
                        dataAdapter.Fill(ds);
                        string str = "day=" + day;
                        DataRow[] rows = ds.Tables[0].Select("day=" + day);
                        for (int i = 0; i < rows.Length; ++i)
                        {
                            int j = i;
                            Course course = new Course();
                            course.name = (string)rows[i][1];
                            course.teacher = (string)rows[i][2];
                            course.fromWeek = (int)rows[i][3];
                            course.endWeek = (int)rows[i][4];
                            course.fromClass = (int)rows[i][5];
                            course.endClass = (int)rows[i][6];
                            course.day = (int)rows[i][7];
                            course.area = (string)rows[i][8];
                            course.classroom = (string)rows[i][9];
                            course.interval = (int)rows[i][10];
                            course.note = (string)rows[i][11];
                            course.detail = (string)rows[i][12];
                            courses.Add(course);
                        }
                    }
                }
            }
            return courses;
        }

    }
}
