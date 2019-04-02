﻿using System;
using System.Collections.Generic;
using System.Device.Location;
using GoogleMaps.LocationServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Report
    {
        public TimeSpan time { set; get; }
        public int stamID { set; get; }
        public string name { set; get; }
        public string address { set; get; }
        public int numBooms { set; get; }
        public GeoCoordinate CoordinateFromAddress { set; get; }
    }
}
