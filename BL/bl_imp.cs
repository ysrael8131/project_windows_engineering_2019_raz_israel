﻿using BE;
using DAL;
using GoogleMaps.LocationServices;
using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BL
{
    public class bl_imp : IBL
    {

        IDAL dal;
        public bl_imp()
        {
            dal = new dal_imp();
        }
        public void addBoomLocation(BoomLocation boomLocation)
        {
            dal.addBoomLocation(boomLocation);
        }

        public void addReport(Report report)
        {
            dal.addReport(report);
        }

        public void deleteBoomLocation(BoomLocation boomLocation)
        {
            dal.deleteBoomLocation(boomLocation);
        }

        public void deleteReport(Report report)
        {
            dal.deleteReport(report);
        }

        public BoomLocation GetBoomLocation(BoomLocation boomLocation)
        {
            return dal.GetBoomLocation(boomLocation);
        }

        public IEnumerable<BoomLocation> getListBoomLocation()
        {
            return dal.getListBoomLocation();
        }

        public IEnumerable<Report> getListReports()
        {
            return dal.getListReports();
        }

        public Report GetReport(Report report)
        {
            return dal.GetReport(report);
        }

        public void updateBoomLocation(BoomLocation boomLocation)
        {
            dal.updateBoomLocation(boomLocation);
        }

        public void updateReport(Report report)
        {
            dal.updateReport(report);
        }

        public List<GeoCoordinate> k_Means(List<Report> SequenceOfReports, int NumOfBooms)
        {

            List<GeoCoordinate> ci_List = new List<GeoCoordinate>();
            double latitude_Min;
            double latitude_Max;
            double longitude_Min;
            double longitude_Max;

            if (!SequenceOfReports.Any())
            {
                return null;
            }

            latitude_Min = SequenceOfReports.Min(item => item.CoordinateFromAddress.Latitude);
            latitude_Max = SequenceOfReports.Max(item => item.CoordinateFromAddress.Latitude);
            longitude_Min = SequenceOfReports.Min(item => item.CoordinateFromAddress.Longitude);
            longitude_Max = SequenceOfReports.Max(item => item.CoordinateFromAddress.Longitude);

            for (int i = 0; i < NumOfBooms; i++)
            {
                Random r = new Random();
                double latitude = latitude_Min + r.NextDouble() * (latitude_Max - latitude_Min);
                double longitude = longitude_Min + r.NextDouble() * (longitude_Max - longitude_Min);
                GeoCoordinate c = new GeoCoordinate(latitude, longitude);
                ci_List.Add(c);
            }

            bool is_Changed;
            do
            {
                is_Changed = false;

                for (int i = 0; i < SequenceOfReports.Count; i++)
                {
                    double min = SequenceOfReports[i].CoordinateFromAddress.GetDistanceTo(ci_List[0]);
                    SequenceOfReports[i].stamID = 0;

                    for (int j = 1; j < ci_List.Count; j++)
                    {
                        double temp = SequenceOfReports[i].CoordinateFromAddress.GetDistanceTo(ci_List[j]);
                        if (temp < min)
                        {
                            min = temp;
                            is_Changed = true;
                            SequenceOfReports[i].stamID = j;
                        }
                    }

                }


                SequenceOfReports.OrderBy(c => c.stamID);
                int id = 0;
                double c_LongitudeSum = 0;
                double c_LatitudeSum = 0;
                int counter = 0;
                for (int i = 0; i < SequenceOfReports.Count; i++)
                {
                    if (SequenceOfReports[i].stamID == id)
                    {
                        c_LatitudeSum += SequenceOfReports[i].CoordinateFromAddress.Latitude;
                        c_LongitudeSum += SequenceOfReports[i].CoordinateFromAddress.Longitude;
                        counter++;
                    }
                    if (SequenceOfReports[i].stamID != id)
                    {
                        ci_List[id].Latitude = c_LatitudeSum / counter;
                        ci_List[id].Longitude = c_LongitudeSum / counter;
                        counter = 0;
                        c_LongitudeSum = 0;
                        c_LatitudeSum = 0;
                        i--;
                        id++;
                    }
                }

            } while (is_Changed);

            return ci_List;
        }

        public GeoCoordinate ConvertAddressToCoordinate(string address)
        {
            try
            {
                GoogleLocationService locationService = new GoogleLocationService();
                
                MapPoint point = locationService.GetLatLongFromAddress(address);
                double latitude = point.Latitude;
                double longitude = point.Longitude;
                return new GeoCoordinate(latitude, longitude);
            }
            catch (Exception e)
            {

                throw;
            }





        }
    }
}
