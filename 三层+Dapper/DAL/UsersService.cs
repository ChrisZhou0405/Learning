using Models;
using System.Configuration;

namespace DAL
{
   public  class UsersService
    {
        private  string connectionStr = ConfigurationManager.AppSettings["Learn"].ToString();
        public Users GetUser(int uid)
        {

            return new Users();
        }
    }
}
