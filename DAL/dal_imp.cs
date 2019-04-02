using BE;
using DS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dal_imp : IDAL
    {
        // dataSource ds;
        //public dal_imp()
        //{
        //    ds = new dataSource();
        //}

        public void addBoomLocation(BoomLocation boomLocation)
        {
            using (var ds = new dataSource())
            {
                ds.boomlocations.Add(boomLocation);
                ds.SaveChanges();
            }
        }

        public void addReport(Report report)
        {
            using (var ds = new dataSource())
            {
                ds.reports.Add(report);
                ds.SaveChanges();
            }
        }

        public void deleteBoomLocation(BoomLocation boomLocation)
        {

        }

        public void deleteReport(Report report)
        {
            using (var ds = new dataSource())
            {
                ds.reports.Remove(report);
                ds.SaveChanges();
            }
        }

        public BoomLocation GetBoomLocation(BoomLocation boomLocation)
        {

            return ds.boomlocations.Find(boomLocation);
        }

        public IEnumerable<BoomLocation> getListBoomLocation()
        {
            return ds.boomlocations.ToList();
        }

        public IEnumerable<Report> getListReports()
        {
            return ds.reports.ToList();
        }

        public Report GetReport(Report report)
        {
            return ds.reports.Find(report);
        }

        public void updateBoomLocation(BoomLocation boomLocation)
        {
            throw new NotImplementedException();
        }

        public void updateReport(Report report)
        {
            throw new NotImplementedException();
        }
    }
}
