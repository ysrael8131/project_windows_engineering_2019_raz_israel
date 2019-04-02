using BE;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS
{
    public class dataSource : DbContext
    {
        public dataSource() : base() { }
        public DbSet<BoomLocation> boomlocations { get; set; }
        public DbSet<Report> reports { get; set; }
        public DbSet<BoomsInRange> boomsInRanges { get; set; }
    }
}
