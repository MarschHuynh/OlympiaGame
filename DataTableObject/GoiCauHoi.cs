using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTableObject
{
    public class GoiCauHoi
    {
        [Key]
        public int ID_Goi { get; set; }
        [StringLength(40)]
        public String Ten { get; set; }

        //Liên kết 1-n
        public virtual ICollection<CauHoi> CacCauHoi { set; get; }
        public GoiCauHoi() { }
        public GoiCauHoi(String ten)
        {
            Ten = ten;
        }
    }
}
