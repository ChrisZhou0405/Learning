using System;
using System.Collections.Generic;
using Models;
using System.Data.SqlClient;
using Dapper;
using Common;

namespace DAL
{
    public class UsersService
    {
        #region Insert
        #region Single Insert
        public int Insert(Users user)
        {
            using (var dapper = new SqlConnection(ConfigurationSettings.ConnectionString))
            {
                return dapper.Execute("INSERT INTO Users VALUES(@UserName,@Email,@Address)", user);
            }

        }
        #endregion

        #region InsertBulk
        public int InsertBulk(List<Users> users)
        {
            using (var dapper = new SqlConnection(ConfigurationSettings.ConnectionString))
            {
                return dapper.Execute("INSERT INTO Users VALUES(@UserName,@Email,@Address)", users);
            }
        }
        #endregion
        #endregion
        
        #region Query
        public Users GetUser(int uid)
        {
            using (var dapper = new SqlConnection(ConfigurationSettings.ConnectionString))
            {
                return dapper.QueryFirstOrDefault<Users>("SELECT*FROM Users WHERE UserID=@UserID", new { UserID = uid });
            }
        }

        public Users GetUsersByName(string username)
        {
            //Error
            using (var dapper = new SqlConnection(ConfigurationSettings.ConnectionString))
            {
                Users user = dapper.Query<Users>("SELECT*FROM Users WHERE UserName=@UserName", new { UserName = username }).AsList().Find(c => c.Email == "996190648@qq.com");
                return user;
            }

        }

        public List<Users> GetAllUsers()
        {
            using (var dapper = new SqlConnection(ConfigurationSettings.ConnectionString))
            {
                List<Users> list = dapper.Query<Users>("SELECT*FROM Users").AsList();
                return list;
            }
        }
        #endregion

        #region Update
        public int UpdateInfo(string address,string username)
        {
            using (var dapper=new SqlConnection(ConfigurationSettings.ConnectionString))
            {
                return dapper.Execute("UPDATE Users SET Address=@address WHERE UserName=@username", new { address = address, username = username });
            }
        }

        public int Update(Users users)
        {
            using (var dapper=new SqlConnection(ConfigurationSettings.ConnectionString))
            {
                return dapper.Execute("UPDATE Users SET Address=@address,UserName= @username,Email=@Email WHERE UserID=@UserID", users);

            }
        }
        #endregion

        #region Delete& IN Opreate
        public int SingleDelete(int uid)
        {
            using (var dapper=new SqlConnection(ConfigurationSettings.ConnectionString))
            {
             return   dapper.Execute("DELETE FROM Users WHERE UserID=@uid", new { uid = uid });
            }
        }

        public int MulDelete(int[] uids)
        {
            using (var dapper=new SqlConnection(ConfigurationSettings.ConnectionString))
            {
                return dapper.Execute("DELETE FROM Users WHERE UserID IN  @uids", new { uids = uids });
            }
        }



        #endregion

        #region  Mul scripts Operation 
        
        #endregion

    }
}
