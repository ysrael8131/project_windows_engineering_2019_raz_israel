using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Report
    {
        public DateTime time { set; get; }
        public double Latitude { set; get; }
        public double Longitude { set; get; }
        public int stamID { set; get; }
        public string name { set; get; }
        public int numBooms { set; get; }
    }
}
