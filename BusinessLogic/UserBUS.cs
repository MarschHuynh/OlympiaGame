using DatabaseAccess;
using DataTableObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class UserBUS
    {
        public User GetUserByUserName(String username)
        {
            return new UserDAO().GetUserByUserName(username);
        }



        /*
        0: Tài khoản không tồn tại
        1: Sai mật khẩu
        2: Tài khoản là Admin
        3: Tài khoản là MC
        4: Tài khoản là Thí Sinh
            */
        public int Authentication(String username,String password)
        {
            UserDAO userDAO = new UserDAO();
            User user = userDAO.GetUserByUserName(username);
            if (user == null)
            {
                return 0;
            } else
            {
                if (user.Password.Equals(password))
                {
                    switch (user.Type) 
                    {
                        case 0: return 2; 
                        case 1: return 3;
                        default: return 4; 
                    }
                } else
                {
                    return 1;
                }
            }
        }
    }
}
