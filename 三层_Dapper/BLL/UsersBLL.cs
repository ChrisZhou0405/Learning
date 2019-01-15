using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;
namespace BLL
{
   public class UsersBLL
    {
        public Users GetUsers(int uid)
        {
            return new UsersService().GetUser(uid);
        }
    }
}
