using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurWork2
{
    public class scheduleService
    {
        public Dictionary<String, Schedule> scdDict;
        public scheduleService()
        {
            scdDict = new Dictionary<String, Schedule>();
        }
        //添加日程
        public void AddSchedule(Schedule shedule)
        {
            //if (scdDict.ContainsKey(shedule.date))
            //    throw new Exception($"Shedule is already existed!");
            scdDict[shedule.date] = shedule;
        }
        //移除日程
        public void RemoveSchedule(String sheduleTime)
        {
            scdDict.Remove(sheduleTime);
        }
        //查询所有日程
        public List<Schedule> QueryAllSchedules()
        {
            return scdDict.Values.ToList();
        }
        //按日期查找日程
        public Schedule GetByDate(String dt)
        {
            if (scdDict.ContainsKey(dt))
            {
                return scdDict[dt];
            }
            return null;
        }
    }
}
