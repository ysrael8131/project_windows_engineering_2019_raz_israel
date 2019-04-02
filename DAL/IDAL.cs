using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IDAL
    {
        void addReport(Report report);
        void deleteReport(Report report);
        void updateReport(Report report);


        void addBoomLocation(BoomLocation boomLocation);
        void deleteBoomLocation(BoomLocation boomLocation);
        void updateBoomLocation(BoomLocation boomLocation);

        void addBoomsInRange(BoomsInRange boomsInRange);
        void deleteBoomsInRange(BoomsInRange boomsInRange);
        void updateBoomsInRange(BoomsInRange boomsInRange);

        IEnumerable<BoomLocation> getListBoomLocation();
        IEnumerable<Report> getListReports();
        IEnumerable<BoomsInRange> GetBoomsInRanges();

        BoomLocation GetBoomLocation(BoomLocation boomLocation);
        Report GetReport(Report Report);
        BoomsInRange GetBoomsInRange(BoomsInRange boomsInRange);
    }
}
