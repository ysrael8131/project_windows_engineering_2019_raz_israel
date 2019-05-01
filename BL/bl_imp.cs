using BE;
using DAL;
using GoogleMaps.LocationServices;
using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BL
{
    class bl_imp : IBL
    {

        public bl_imp() { }
        public void addBoomLocation(BoomLocation boomLocation)
        {
            using (dal_imp dal = new dal_imp())
                dal.addBoomLocation(boomLocation);
        }

        public void addReport(Report report)
        {
            using (dal_imp dal = new dal_imp())
            {
                dal.addReport(report);

                //  List<Event> event1 = GetEvents().ToList().FindAll();


                Event event1 = new Event();
                event1.start = report.time;
                event1.end = report.time.AddMinutes(10);
                event1.reports = new List<Report>();
                event1.reports.Add(report);

            }
        }

        public void deleteBoomLocation(BoomLocation boomLocation)
        {
            using (dal_imp dal = new dal_imp())
            {
                dal.deleteBoomLocation(boomLocation);
            }
        }

        public void deleteReport(Report report)
        {
            using (dal_imp dal = new dal_imp())
                dal.deleteReport(report);
        }

        public BoomLocation GetBoomLocation(BoomLocation boomLocation)
        {
            using (dal_imp dal = new dal_imp())
                return dal.GetBoomLocation(boomLocation);
        }

        public IEnumerable<BoomLocation> getListBoomLocation()
        {
            using (dal_imp dal = new dal_imp())
                return dal.getListBoomLocation();
        }

        public IEnumerable<Report> getListReports()
        {
            using (dal_imp dal = new dal_imp())
                return dal.getListReports();
        }

        public Report GetReport(Report report)
        {
            using (dal_imp dal = new dal_imp())
                return dal.GetReport(report);
        }

        public void updateBoomLocation(BoomLocation boomLocation)
        {
            using (dal_imp dal = new dal_imp())
                dal.updateBoomLocation(boomLocation);
        }

        public void updateReport(Report report)
        {
            using (dal_imp dal = new dal_imp())
                dal.updateReport(report);
        }

        //public List<GeoCoordinate> k_Means(List<Report> SequenceOfReports, int NumOfBooms)
        //{

        //    List<GeoCoordinate> ci_List = new List<GeoCoordinate>();
        //    double latitude_Min;
        //    double latitude_Max;
        //    double longitude_Min;
        //    double longitude_Max;

        //    if (!SequenceOfReports.Any())
        //    {
        //        return null;
        //    }

        //    latitude_Min = SequenceOfReports.Min(item => item.address.Latitude);
        //    latitude_Max = SequenceOfReports.Max(item => item.address.Latitude);
        //    longitude_Min = SequenceOfReports.Min(item => item.address.Longitude);
        //    longitude_Max = SequenceOfReports.Max(item => item.address.Longitude);

        //    for (int i = 0; i < NumOfBooms; i++)
        //    {
        //        Random r = new Random();
        //        double latitude = latitude_Min + r.NextDouble() * (latitude_Max - latitude_Min);
        //        double longitude = longitude_Min + r.NextDouble() * (longitude_Max - longitude_Min);
        //        GeoCoordinate c = new GeoCoordinate(latitude, longitude);
        //        ci_List.Add(c);
        //    }

        //    bool is_Changed;
        //    do
        //    {
        //        is_Changed = false;

        //        for (int i = 0; i < SequenceOfReports.Count; i++)
        //        {
        //            double min = SequenceOfReports[i].address.GetDistanceTo(ci_List[0]);
        //            SequenceOfReports[i].stamID = 0;

        //            for (int j = 1; j < ci_List.Count; j++)
        //            {
        //                double temp = SequenceOfReports[i].address.GetDistanceTo(ci_List[j]);
        //                if (temp < min)
        //                {
        //                    min = temp;
        //                    is_Changed = true;
        //                    SequenceOfReports[i].stamID = j;
        //                }
        //            }

        //        }


        //        SequenceOfReports.OrderBy(c => c.stamID);
        //        int id = 0;
        //        double c_LongitudeSum = 0;
        //        double c_LatitudeSum = 0;
        //        int counter = 0;
        //        for (int i = 0; i < SequenceOfReports.Count; i++)
        //        {
        //            if (SequenceOfReports[i].stamID == id)
        //            {
        //                c_LatitudeSum += SequenceOfReports[i].address.Latitude;
        //                c_LongitudeSum += SequenceOfReports[i].address.Longitude;
        //                counter++;
        //            }
        //            if (SequenceOfReports[i].stamID != id)
        //            {
        //                ci_List[id].Latitude = c_LatitudeSum / counter;
        //                ci_List[id].Longitude = c_LongitudeSum / counter;
        //                counter = 0;
        //                c_LongitudeSum = 0;
        //                c_LatitudeSum = 0;
        //                i--;
        //                id++;
        //            }
        //        }

        //    } while (is_Changed);

        //    return ci_List;
        //}

        public GeoCoordinate ConvertAddressToCoordinate(string address)
        {
            GoogleLocationService locationService = new GoogleLocationService();
            MapPoint point = locationService.GetLatLongFromAddress(address);
            double latitude = point.Latitude;
            double longitude = point.Longitude;
            return new GeoCoordinate(latitude, longitude);
        }

        public void addEvent(Event event1)
        {
            using (dal_imp dal = new dal_imp()) ;

        }

        public void deleteEvent(Event event1)
        {
            using (dal_imp dal = new dal_imp()) ;
        }

        public void updateEvent(Event event1)
        {
            using (dal_imp dal = new dal_imp()) ;
        }

        public IEnumerable<Event> GetEvents()
        {
            using (dal_imp dal = new dal_imp()) 
                return dal.GetEvents();
        }

        public Event GetEvent(Event event1)
        {
            using (dal_imp dal = new dal_imp())
                return dal.GetEvent(event1);
        }
    }
}
