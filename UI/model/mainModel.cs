using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using BL;
namespace UI.model
{
    public class MainModel
    {
     
        public void addReport(Report report)
        {
            using (bl_imp bl=new bl_imp() )
            {
                bl.addReport(report);
            }
        }
    }
}
