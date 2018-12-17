using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurWork
{
    class Response
    {
        public string success { set; get; }
        public string message { set; get; }
        public List<List<Course>> data { set; get; }
    }
}
