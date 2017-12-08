using Coderful.EntityFramework.Testing.Mock;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkFlowMySql.Data;

namespace WorkFlowMySql
{
    internal static class MockUtylity
    {
        public static MockedDbContext<WorkFlowContext> MockDbContext(
            IList<TicketHeader> tickets = null)
        {
            var mockContext = new Mock<WorkFlowContext>();

            // Create the DbSet objects.
            var dbSets = new object[]
            {
                mockContext.MockDbSet(tickets, (objects, ticket) => ticket.TicketId == (int)objects[0] && ticket.ActiveUserId == (int)objects[1] && ticket.Status == (string)objects[2])
            };

            return new MockedDbContext<WorkFlowContext>(mockContext, dbSets);
        }
    }
}
