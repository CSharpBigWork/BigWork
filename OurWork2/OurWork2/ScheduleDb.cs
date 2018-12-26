using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OurWork2
{
    public class ScheduleDb
    {
        public MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(
                "datasource=localhost;username=root;" +
                "password=123456;database=csharpbigwork;charset=utf8");
            connection.Open();
            return connection;
        }

        /// <summary>
        /// 添加事件
        /// </summary>
        /// <param name="evt"></param>
        public void AddRowInDataSet(Event evt)
        {
            using (MySqlConnection conn = GetConnection())
            {
                String sql = "SELECT * FROM evt";
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn))
                {
                    MySqlCommandBuilder cmdBuilder = new MySqlCommandBuilder(dataAdapter);
                    using (DataSet ds = new DataSet())
                    {
                        try
                        {
                            dataAdapter.Fill(ds);
                            DataRow newRow = ds.Tables[0].NewRow();
                            newRow[0] = evt.dateKey.ToShortDateString() + " " + evt.dateKey.ToShortTimeString(); //主键
                            newRow[1] = evt.dateKey.ToShortDateString();     //日期
                            newRow[2] = evt.dateKey.ToShortTimeString();      //时间
                            newRow[3] = evt.Events;                            //详情
                            ds.Tables[0].Rows.Add(newRow);
                            dataAdapter.Update(ds);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("同一时间不能开始两件事", "错误");
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 修改事件
        /// </summary>
        /// <param name="evt"></param>
        /// <param name="dt"></param>
        public void Edit(Event evt, string dt)
        {
            using (MySqlConnection con = GetConnection())
            {
                try
                {
                    String sql = "update evt set mykey=@datetime,date=@date,time=@time,detail=@detail " +
                        "where mykey= '" + dt + "'";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("datetime", evt.dateKey.ToShortDateString() + " " + evt.dateKey.ToShortTimeString());
                    cmd.Parameters.AddWithValue("date", evt.dateKey.ToShortDateString());
                    cmd.Parameters.AddWithValue("time", evt.dateKey.ToShortTimeString());
                    cmd.Parameters.AddWithValue("detail", evt.Events);
                    int val = cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    MessageBox.Show("修改后时间与已有事件冲突！", "错误");
                }
            }
        }
        /// <summary>
        /// 删除事件
        /// </summary>
        /// <param name="datetime"></param>
        public void Delete(string datetime)
        {

            using (MySqlConnection con = GetConnection())
            {
                String sql = "delete from evt where mykey=@datetime";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("datetime", datetime);
                int val = cmd.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// 获取所有有日程安排的日期信息
        /// </summary>
        /// <returns></returns>
        public List<string> getAllDate()
        {
            using (MySqlConnection conn = GetConnection())
            {
                String sql = "SELECT * FROM evt";
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn))
                {
                    using (DataSet ds = new DataSet())
                    {
                        dataAdapter.Fill(ds);
                        List<string> dates = new List<string>();
                        int length = ds.Tables[0].Rows.Count;
                        for (int i = 0; i < length; i++)
                        {
                            if (dates.Contains((string)ds.Tables[0].Rows[i][1]))
                                continue;
                            dates.Add((string)ds.Tables[0].Rows[i][1]);
                        }
                        return dates;
                    }
                }
            }
        }

        /// <summary>
        /// 清除数据库
        /// </summary>
        public void ClearEventTable()
        {
            using (MySqlConnection connection = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand
                ("TRUNCATE TABLE evt", connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
        /// <summary>
        /// 查询某天的所有日程安排
        /// </summary>
        /// <param name="day"></param>
        /// <returns></returns>
        public List<Event> GetEvents(string day)
        {
            List<Event> evts = new List<Event>();
            using (MySqlConnection conn = GetConnection())
            {
                String sql = "SELECT * FROM evt";
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn))
                {
                    using (DataSet ds = new DataSet())
                    {
                        dataAdapter.Fill(ds);
                        string str = $"date='{day}'";
                        DataRow[] rows = ds.Tables[0].Select(str);
                        for (int i = 0; i < rows.Length; i++)
                        {
                            Event _evt = new Event();
                            _evt.dateKey = DateTime.Parse((string)rows[i][0]);
                            _evt.Events = (string)rows[i][3];
                            evts.Add(_evt);
                        }
                    }
                }
            }
            return evts;
        }
    }
}
