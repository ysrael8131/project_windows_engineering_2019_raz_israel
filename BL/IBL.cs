using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IBL
    {
        void addReport(Report report);
        void deleteReport(Report report);
        void updateReport(Report report);


        void addBoomLocation(BoomLocation boomLocation);
        void deleteBoomLocation(BoomLocation boomLocation);
        void updateBoomLocation(BoomLocation boomLocation);

        void addEvent(Event event1);
        void deleteEvent(Event event1);
        void updateEvent(Event event1);

        IEnumerable<BoomLocation> getListBoomLocation();
        IEnumerable<Report> getListReports();
        IEnumerable<Event> GetEvents();

        BoomLocation GetBoomLocation(BoomLocation boomLocation);
        Report GetReport(Report Report);
        Event GetEvent(Event event1);
    }
}
