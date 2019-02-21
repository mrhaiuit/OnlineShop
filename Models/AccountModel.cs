using Models.Framework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class AccountModel
    {
        private OnlineShopDbContext context = null;
        public AccountModel()
        {
            context = new OnlineShopDbContext();
        }

        public bool Login(string UserName, string PassWord)
        {
            var sqlParams = new SqlParameter[]
                {
                new SqlParameter("@UserName", UserName),
                new SqlParameter("@PassWord", PassWord)
                };
            var res = context.Database.SqlQuery<bool>("sp_Account_Login @UserName, @PassWord", sqlParams).SingleOrDefault();
            return res;
        }
    }
}
