using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurWork2
{
    public class Event
    {
        public string Events { get; set; }
        public DateTime dateKey { get; set; }
        public Event() { }
        public Event(string evt)
        {
            this.Events = evt;
        }
    }
}
