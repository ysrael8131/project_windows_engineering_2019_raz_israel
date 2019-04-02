using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BoomsInRange
    {
        public List<BoomLocation> boomLocations { set; get; }
        public TimeSpan start { set; get; }
        public TimeSpan end { set; get; }
    }
}
