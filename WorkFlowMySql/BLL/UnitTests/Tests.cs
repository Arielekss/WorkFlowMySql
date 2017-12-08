using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkFlowMySql.Data;

namespace WorkFlowMySql.BLL.UnitTests
{
    [TestFixture]
    public class Tests
    {[Test]
        public void UpdateTicket_ShouldUpdate()
        {
            //arange
            var myItems = new Mock<MockableDbSetWithExtensions<TicketHeader>>();
            var context = new Mock<WorkFlowContext>();
            context.Setup(e => e.Ticket).Returns(myItems.Object);

            //act
            TicketServiceMethods ticketService = new TicketServiceMethods(context.Object);
            ticketService.UpdateTicketStatusById(It.IsAny<int>(), It.IsAny<string>(), It.IsAny<string>());

            //assert
            //ticketService.Verify(v => v.(It.IsAny<BillingEventEntry>()), Times.Never);
        }
        
    }
}
