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

        IEnumerable<BoomLocation> getListBoomLocation();
        IEnumerable<Report> getListReports();

        BoomLocation GetBoomLocation(BoomLocation boomLocation);
        Report GetReport(Report report);
    }
}
