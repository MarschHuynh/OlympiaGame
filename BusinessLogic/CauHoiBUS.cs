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
        CauHoiDAO cauHoiDAO;
        public CauHoiBUS()
        {
            cauHoiDAO = new CauHoiDAO();
        }
        public List<CauHoi> GetALLCauHoi()
        {
            //CauHoiDAO ch = new CauHoiDAO();
            return cauHoiDAO.GetAllCauHoi();
        }

        public List<CauHoi> GetCauHoiByIdGoi(int id)
        {
            return cauHoiDAO.GetCauHoiByIdGoi(id);
        }

        //public void TaoCauHoi(String ten,String noiDung,String linhVuc,int id_goi)
        //{
        //    cauHoiDAO.TaoCauHoi(ten, noiDung, linhVuc, id_goi);
        //}

        public void XoaCauHoiById(int id)
        {
            cauHoiDAO.XoaCauHoiById(id);
        }
        public void CapNhatOrThemCauHoi(int id,String ten,String noiDung, String linhVuc, int id_Goi,String dapAn)
        {
            cauHoiDAO.CapNhatOrThemCauHoi(id, ten, noiDung, linhVuc, id_Goi, dapAn);
        }
    }
}
