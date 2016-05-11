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
        public List<GoiCauHoi> GetALLGoiCauHoi()
        {
            GoiCauHoiDAO ch = new GoiCauHoiDAO();
            return ch.GetAllGoiCauHoi();
        }
    }
}
