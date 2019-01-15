using System;
using System.Collections.Generic;
using Models;
using System.Data.SqlClient;
using Dapper;
using System.Configuration;

namespace DAL
{
    public class UsersService
    {
        private readonly string connectionStr = "Data Source=.;Initial Catalog=Learn;User Id=sa;Password=pwd@123456";
        //private readonly string connectionStr = ConfigurationManager.ConnectionStrings["Learn"].ConnectionString;



        public Users GetUser(int uid)
        {
            using (var dapper=new  SqlConnection(connectionStr)) {
                return dapper.QueryFirstOrDefault<Users>("SELECT*FROM Users WHERE UserID=@UserID", new { UserID = uid });
            }
        }
    }
}
