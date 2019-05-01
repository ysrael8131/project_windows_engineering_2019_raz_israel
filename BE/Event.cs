using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Event
    {
        public int idEvent { set; get; }
        public List<Report> reports { set; get; }
        public List<BoomLocation> boomLocations { set; get; }
        public DateTime start { set; get; }
        public DateTime end { set; get; }
    }
}
