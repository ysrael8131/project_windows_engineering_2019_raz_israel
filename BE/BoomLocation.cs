using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BoomLocation
    {
        public GeoCoordinate address { set; get; }
        public GeoCoordinate rightAddress { set; get; }
        public TimeSpan tyme { set; get; }

        //public List<Report> reports { set; get; }
    }
}
