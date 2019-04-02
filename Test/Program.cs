using System;
using System.Collections.Generic;
using System.Device.Location;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using BL;
using GoogleMaps.LocationServices;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            Report report = new Report(); { report.address = "Stavanger, Norway"; }
            bl_imp bl_ = new bl_imp();
            GeoCoordinate geo= bl_.ConvertAddressToCoordinate(report.address);
            Console.WriteLine(report.address);
           
            Console.WriteLine(geo.Altitude+" "+geo.Latitude );


        }
    }
}
