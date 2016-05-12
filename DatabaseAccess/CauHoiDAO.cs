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

        public List<CauHoi> GetCauHoiByIdGoi(int id)
        {
            OlympiaDataContext db = new OlympiaDataContext();

            var result = from ch in db.CauHois
                         join gch in db.GoiCauHois on ch.ID_Goi equals gch.ID_Goi
                         where ch.ID_Goi == id
                         select ch;

            return result.ToList();
        }

        //public void TaoCauHoi(String ten,String noiDung,String linhVuc,int id_goi)
        //{
        //    OlympiaDataContext db = new OlympiaDataContext();
        //    db.CauHois.Add(new CauHoi(ten,noiDung,linhVuc,id_goi));
        //    db.SaveChanges();
        //}

        public void CapNhatOrThemCauHoi(int id,String ten,String noiDung,String linhVuc,int id_Goi,String dapAn)
        {
            OlympiaDataContext db = new OlympiaDataContext();
            CauHoi result = null;
            try
            {
                result = (CauHoi)db.CauHois.Where(ch => ch.ID_CauHoi == id).Single();
            } catch (Exception e)
            {
                Console.Write("ERROR:", e.ToString());
            }
            
            if (result != null)
            {
                result.Ten = ten;
                result.LinhVuc = linhVuc;
                result.NoiDung = noiDung;
                result.DapAn = dapAn;
                result.ID_Goi = id_Goi;
            } else
            {
                db.CauHois.Add(new CauHoi(ten,noiDung,linhVuc,id_Goi,dapAn));
            }
            
            db.SaveChanges();
        }

        public void XoaCauHoiById(int id)
        {
            OlympiaDataContext db = new OlympiaDataContext();
            CauHoi result = (CauHoi)db.CauHois.Where(ch => ch.ID_CauHoi == id).Single();
            db.CauHois.Remove(result);
            db.SaveChanges();
        }

    }
}
