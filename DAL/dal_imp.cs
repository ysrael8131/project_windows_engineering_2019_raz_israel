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
        dataSource ds;
        public dal_imp()
        {
            ds = new dataSource();
        }

        public void addBoomLocation(BoomLocation boomLocation)
        {
            ds.boomlocations.Add(boomLocation);
            ds.SaveChanges();
        }

        public void addBoomsInRange(BoomsInRange boomsInRange)
        {
            throw new NotImplementedException();
        }

        public void addReport(Report report)
        {
            ds.reports.Add(report);
            ds.SaveChanges();
        }

        public void deleteBoomLocation(BoomLocation boomLocation)
        {

        }

        public void deleteBoomsInRange(BoomsInRange boomsInRange)
        {
            throw new NotImplementedException();
        }

        public void deleteReport(Report report)
        {
            ds.reports.Remove(report);
            ds.SaveChanges();
        }

        public BoomLocation GetBoomLocation(BoomLocation boomLocation)
        {

            return ds.boomlocations.Find(boomLocation);
        }

        public BoomsInRange GetBoomsInRange(BoomsInRange boomsInRange)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BoomsInRange> GetBoomsInRanges()
        {
            throw new NotImplementedException();
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

        public void updateBoomsInRange(BoomsInRange boomsInRange)
        {
            throw new NotImplementedException();
        }

        public void updateReport(Report report)
        {
            throw new NotImplementedException();
        }
    }
}
