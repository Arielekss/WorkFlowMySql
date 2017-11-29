using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
