using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkFlowMySql.Data;

namespace WorkFlowMySql.BLL.User
{
   public class UserValidation
    {
        public bool ValidateUserLoginAndPassword(UserModel userModel)
        {
            UserMethods userMethods = new UserMethods();
            {
                if (userMethods.HashPassword(userModel.Pass) == GetUserFromDb(userModel))
                    return true;

                return false;
            }
        }
        private string GetUserFromDb(UserModel userModel)
        {
            string userPass = string.Empty;
            using (var context = new WorkFlowContext())
            {
                var CustomerQuery = context.Customer.Where(s => s.UserName == userModel.UserName);
                foreach (var users in CustomerQuery)
                {
                    userPass = users.Pass;
                }
            }
            return userPass;
        }
    }
}
