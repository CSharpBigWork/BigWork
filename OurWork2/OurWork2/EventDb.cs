using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurWork2
{
    public class EventDb
    {
        public MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(
                "datasource=localhost;username=root;" +
                "password=123456;database=csharpbigwork;charset=utf8");
            connection.Open();
            return connection;
        }

        public void AddEvent(EventDetails ed)
        {
            using (MySqlConnection con = GetConnection())
            {
                String sql = "insert into db_events set eventName ='" + ed.eventName + "',createTime='" + ed.createTime + "',courseName='"+ed.courseName+"'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                int val = cmd.ExecuteNonQuery();
            }
        }
      
        public EventDetails GetEvents(int id)
        {
            EventDetails ed = new EventDetails();
            using (MySqlConnection conn = GetConnection())
            {
                String sql = "SELECT * FROM db_events";
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn))
                {
                    using (DataSet ds = new DataSet())
                    {
                        dataAdapter.Fill(ds);
                        DataRow[] row = ds.Tables[0].Select("eventId=" + id);
                        ed.eventId = id;
                        ed.eventName = (string)row[0][1];
                        ed.createTime = (DateTime)row[0][2];
                    }
                }
            }
            return ed;
        }
        public void deleteEvent(EventDetails ed)
        {
            using (MySqlConnection con = GetConnection())
            {
                String sql = "delete from db_events where eventId = @eventId";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("eventId", ed.eventId);
                int val = cmd.ExecuteNonQuery();
            }
        }
        public void ClearEventsTable()
        {
            using (MySqlConnection connection = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand
                ("TRUNCATE TABLE db_events ", connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void edit(EventDetails ed)
        {
            using (MySqlConnection con = GetConnection())
            {
                String sql = "update db_events set createTime=@createTime,eventName=@eventName where eventId= '" + ed.eventId + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("createTime", ed.createTime);
                cmd.Parameters.AddWithValue("eventName", ed.eventName);
                int val = cmd.ExecuteNonQuery();

            }
        }
        public List<EventDetails> GetEventDetails()
        {
            List<EventDetails> events = new List<EventDetails>();
            using (MySqlConnection conn = GetConnection())
            {
                String sql = "SELECT * FROM db_events";
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn))
                {
                    using (DataSet ds = new DataSet())
                    {
                        dataAdapter.Fill(ds);
                        foreach (DataRow row in ds.Tables[0].Rows)
                        {
                            EventDetails ed = new EventDetails();
                            ed.eventId = (int)row[0];
                            ed.eventName = (string)row[1];
                            ed.createTime = (DateTime)row[2];
                            ed.courseName = (string)row[3];
                            events.Add(ed);
                        }
                    }
                }
            }
            return events;
        }

        public List<EventDetails> GetEventDetails(string courseName)
        {
            List<EventDetails> events = new List<EventDetails>();
            using (MySqlConnection conn = GetConnection())
            {
                String sql = "SELECT * FROM db_events where courseName='"+ courseName+"'";
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn))
                {
                    using (DataSet ds = new DataSet())
                    {
                        dataAdapter.Fill(ds);
                        foreach (DataRow row in ds.Tables[0].Rows)
                        {
                            EventDetails ed = new EventDetails();
                            ed.eventId = (int)row[0];
                            ed.eventName = (string)row[1];
                            ed.createTime = (DateTime)row[2];
                            ed.courseName = (string)row[3];
                            events.Add(ed);
                        }
                    }
                }
            }
            return events;
        }

        public void deleteClassDetail()
        {
            using (MySqlConnection conn = GetConnection())
            {
                String sql = "DELETE  FROM db_events where courseName<>''";
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn))
                {
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
