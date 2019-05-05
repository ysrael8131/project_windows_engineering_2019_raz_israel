using BE;
using DS;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dal_imp : IDAL, IDisposable
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

        public async void addEvent(Event event1)
        {
            ds.events.Add(event1);
            await ds.SaveChangesAsync();
        }

        public async void addReport(Report report)
        {
          
            await ds.SaveChangesAsync();
            Event ev2 = ds.events.Find(3);
                 }

        public void deleteBoomLocation(BoomLocation boomLocation)
        {

        }

        public void deleteEvent(Event event1)
        {
            throw new NotImplementedException();
        }

        public void deleteReport(Report report)
        {
            ds.reports.Remove(report);
            ds.SaveChanges();
        }

        public void Dispose()
        {
        }

        public BoomLocation GetBoomLocation(BoomLocation boomLocation)
        {

            return ds.boomlocations.Find(boomLocation);
        }

        public Event GetEvent(Event event1)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Event>> GetEvents()
        {
            return await (from d in ds.events select d).ToListAsync();
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

        public async void updateEvent(Event event1)
        {
            if (ds.events.Find(event1.NumEvent) != null)
            {
                Event event2 = ds.events.Find(event1.NumEvent);
                ds.events.Remove(event2);
                ds.events.Add(event1);
                await ds.SaveChangesAsync();
            }
            else
            {
                throw new Exception("no event");
            }

        }

        public void updateReport(Report report)
        {
            throw new NotImplementedException();
        }
    }
}
