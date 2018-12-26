using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurWork2
{
    public class Schedule
    {
        private List<Event> events = new List<Event>();
        public String date { get; set; }  //日程所在的时间
        public List<Event> Events               //日程中包含的事件
        {
            get => this.events;
        }
        public Schedule(String dt)
        {
            this.date = dt;
        }
        public void AddEvents(Event newEvent)   //添加事件
        {
            if (this.Events.Contains(newEvent))
            {
                throw new Exception($"Events- {newEvent} is already existed!");
            }
            events.Add(newEvent);
        }
        public void RemoveEvents(DateTime dt)      //移除事件
        {
            events.RemoveAll(d => d.dateKey == dt);
        }
        public void RemoveAllEvents()      //移除所有事件
        {
            events.Clear();
        }
    }
}
