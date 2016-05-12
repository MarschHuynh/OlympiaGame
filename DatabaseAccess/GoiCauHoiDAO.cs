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
            var result = (GoiCauHoi)db.GoiCauHois.Where(gch => gch.Ten == ten).FirstOrDefault();
            return result;
        }

        public void TaoGoiCauHoi(String name)
        {
            OlympiaDataContext db = new OlympiaDataContext();
            db.GoiCauHois.Add(new GoiCauHoi(name));
            db.SaveChanges();
        }

        public void XoaGoiCauHoiById(int id)
        {
            OlympiaDataContext db = new OlympiaDataContext();
            GoiCauHoi result =(GoiCauHoi) db.GoiCauHois.Where(gch => gch.ID_Goi == id).Single();
            db.GoiCauHois.Remove(result);
            db.SaveChanges();
        }
    }
}
