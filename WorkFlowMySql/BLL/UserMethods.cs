using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WorkFlowMySql.GUI;

namespace WorkFlowMySql.BLL
{
    public class UserMethods
    {
        public List<UserModel> GetUserList()
        {
            using (var context = new WorkFlowContext())
            {
                    return context.Customer.ToList();
            };
        }

        public string HashPassword(string password)
        {
            var md5 = new MD5CryptoServiceProvider();
            var data = Encoding.ASCII.GetBytes(password);
            var md5data = md5.ComputeHash(data);
            return Convert.ToBase64String(md5data);
        }
    }
}
