using DataTableObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess
{
    public class UserDAO
    {
        public User GetUserByUserName(String username)
        {
            OlympiaDataContext db = new OlympiaDataContext();
            var result = (User)db.Users.Where(user => user.Username == username).FirstOrDefault();
            return result;
        }
    }
}
