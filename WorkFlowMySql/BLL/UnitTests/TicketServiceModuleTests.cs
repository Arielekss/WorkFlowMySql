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
            /*var workflowrContextMock = new Mock<WorkFlowContext>();
            workflowrContextMock.Setup(x => x.Ticket.Add(It.IsAny<TicketHeader>())).Returns(Mock);*/
















            //arrange
            //var mockSet = new Mock<DbSet<TicketHeader>>();
            //var mockContext = new Mock<WorkFlowContext>();

            var workflowrContextMock = new Mock<WorkFlowContext>();
            workflowrContextMock.Setup(x => x.Ticket.Add(It.IsAny<TicketHeader>())).Returns(new TicketHeader
            {
                TicketId = 1,
                Header = "EntityTest",
                RegisterDate = DateTime.Now,
                UserRegister = "Ariel",
                ActiveUser = It.IsAny<string>(),
                ActiveUserId = It.IsAny<int>(),
                Guid = Guid.NewGuid().ToString()
            });
        

        //act
         /*    string ticketStatus = "Cancel";
             var ticketService = new TicketServiceMethods(mockContext.Object);
             ticketService.UpdateTicketStatusById(It.IsAny<int>(), ticketStatus, It.IsAny<string>());


             //assert
             mockSet.Verify(m => m.Add(It.IsAny<TicketHeader>()), Times.Once());*/
        }
    }
}
