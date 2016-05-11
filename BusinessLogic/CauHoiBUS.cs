using DatabaseAccess;
using DataTableObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class CauHoiBUS
    {
        public List<CauHoi> GetALLCauHoi()
        {
            CauHoiDAO ch = new CauHoiDAO();
            return ch.GetAllCauHoi();
        }

        public List<CauHoi> GetCauHoiByIdGoi(int id)
        {
            OlympiaDataContext db = new OlympiaDataContext();

            var result = from ch in db.CauHois
                         join gch in db.GoiCauHois on ch.ID_Goi equals gch.ID_Goi
                         where ch.ID_Goi == id
                         select ch;

            return result.ToList();
        }
    }
}
