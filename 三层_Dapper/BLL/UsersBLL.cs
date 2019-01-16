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

        public int Insert(Users user)
        {
            return new UsersService().Insert(user);
        }
        public int InsertBulk(List<Users> users)
        {
            return new UsersService().InsertBulk(users);
        }
        public Users GetUsers(int uid)
        {
            return new UsersService().GetUser(uid);
        }

        public Users GetUsersByName(string name) {
            return new UsersService().GetUsersByName(name);
        }

        public List<Users> GetAllUsers()
        {
            return new UsersService().GetAllUsers();
        }
    }
}
