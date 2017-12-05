using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkFlowMySql.Data;
using WorkFlowMySql.GUI;

namespace WorkFlowMySql.BLL.UnitTests
{
    [TestFixture]
    public class TicketServiceModuleTests
    {
        [Test]
        public void UpdateTicketStatusById()
        {
            //arrange
            var mockSet = new Mock<DbSet<TicketHeader>>();
            var mockContext = new Mock<WorkFlowContext>();
            mockContext.Setup(m => m.Ticket).Returns(mockSet.Object);
            //act
            string ticketStatus = "Cancel";
            var ticketService = new TicketServiceMethods(mockContext.Object);
            ticketService.UpdateTicketStatusById(It.IsAny<int>(), ticketStatus, It.IsAny<string>());


            //assert
            mockSet.Verify(m => m.Add(It.IsAny<TicketHeader>()), Times.Once());
        }
    }
}
