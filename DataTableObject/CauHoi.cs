using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTableObject
{
    public class CauHoi
    {   
        [Key]
        public int ID_CauHoi { get; set; }
        public String Ten { get; set; }
        public String NoiDung { get; set; }
        public int ID_Goi { get; set; }
        [ForeignKey("ID_Goi")]

        public virtual GoiCauHoi GoiCauHoi { set; get; }//Liên kết 1-1
        public CauHoi() { }
        public CauHoi(String ten, String noiDung, int id_goi)
        {
            Ten = ten;
            NoiDung = noiDung;
            ID_Goi = id_goi;
        }
    }
}
