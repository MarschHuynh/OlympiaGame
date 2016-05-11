using DatabaseAccess;
using DataTableObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class GoiCauHoiBUS
    {
        GoiCauHoiDAO goiCauHoiDAO;

        public GoiCauHoiBUS()
        {
            goiCauHoiDAO = new GoiCauHoiDAO();
        }

        public List<GoiCauHoi> GetALLGoiCauHoi()
        {
            return goiCauHoiDAO.GetAllGoiCauHoi();
        }

        public GoiCauHoi GetGoiCauHoiByTen(String ten)
        {
            return goiCauHoiDAO.GetGoiCauHoiByTen(ten);
        }
        
        public void TaoGoiCauHoi(String name)
        {
            goiCauHoiDAO.TaoGoiCauHoi(name);
        }
        public void XoaGoiCauHoi(int id)
        {
            goiCauHoiDAO.XoaGoiCauHoiById(id);
        }
    }
}
