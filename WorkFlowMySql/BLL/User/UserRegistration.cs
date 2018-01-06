using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkFlowMySql.Data;

namespace WorkFlowMySql.BLL.User
{
   public class UserRegistration
    {
        UserMethods userMethod = new UserMethods();
        public void CreateUserAccount(UserModel userModel)
        {
            using (var context = new WorkFlowContext())
            {
                userModel.Pass = userMethod.HashPassword(userModel.Pass);
                userModel.RegisterDate = DateTime.Now;
                context.Customer.Add(userModel);
                context.SaveChanges();
            }
        }
    
    }
}
