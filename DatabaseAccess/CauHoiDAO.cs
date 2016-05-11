using DataTableObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess
{
    public class CauHoiDAO
    {
        public List<CauHoi> GetAllCauHoi()
        {
            OlympiaDataContext db = new OlympiaDataContext();
            return db.CauHois.ToList();
        }
    }
}
