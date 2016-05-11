using DataTableObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess
{
    public class GoiCauHoiDAO
    {
        public List<GoiCauHoi> GetAllGoiCauHoi()
        {
            OlympiaDataContext db = new OlympiaDataContext();
            return db.GoiCauHois.ToList();
        }
        
        public GoiCauHoi GetGoiCauHoiByTen(String ten)
        {
            OlympiaDataContext db = new OlympiaDataContext();
            var result = from gch in db.GoiCauHois
                      where gch.Ten == ten
                      select gch;
            return result.ToArray()[0];
        }

    }
}
