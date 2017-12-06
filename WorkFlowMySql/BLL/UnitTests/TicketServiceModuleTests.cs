using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coderful.EntityFramework.Testing.Mock;
using WorkFlowMySql.BLL.Interfaces;
using WorkFlowMySql.Data;
using WorkFlowMySql.GUI;

namespace WorkFlowMySql.BLL.UnitTests
{
    [TestFixture]
    public class TicketServiceModuleTests
    {
        
        [Test]
        public void EntityTest()
        {
            // Arrange
            var ticket = new List<TicketHeader>
            {
                new TicketHeader()
                {
                    TicketId = 1,
                    ActiveUser = "Ariel"
                },
                new TicketHeader()
                {
                    TicketId = 2,
                    ActiveUser = "Marlena"
                }
            };
            var dbContext = MockUtylity.MockDbContext(
                tickets: ticket).DbContext.Object;

            //Act
            TicketServiceMethods ticketMethods = new TicketServiceMethods();
            ticketMethods.UpdateTicketStatusById(1,"Cancel", "test");
            var result = dbContext.Ticket.Where(s => s.TicketId == 1).ToList().FirstOrDefault();
            dbContext.SaveChanges();

            // Assert
            Assert.Equals("Cancel", result.Status);
        }

    }
}