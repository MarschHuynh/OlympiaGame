using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTableObject
{
    public class User
    {
        [Key]
        public int ID_User { get; set; }
        public String Ten { get; set; }
        public String Username { get; set; }
        public int Type { get; set; }
        public String Password { get; set; }
    }
}
