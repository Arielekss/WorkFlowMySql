using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using WorkflowMVC.MapMethods;
using WorkflowMVC.Models;
using WorkFlowMySql.BLL;
using WorkFlowMySql.Data;

namespace WorkflowMVC.Controllers
{
    public class HomeController : Controller
    {
        TicketModel ticketModel = new TicketModel();
        private ModelsMapper mapper = new ModelsMapper();
        private TicketViewModel ticketViewMethod = new TicketViewModel();
        WorkFlowMySql.BLL.TicketCreator ticketCreator = new TicketCreator();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        
        public ActionResult TicketCreator(Ticket ticket)
        {
            if (!string.IsNullOrEmpty(ticket.Header))
            {
                ticketCreator.SendTicketToDb(mapper.MapTicket2TicketModel(ticket));
            }
                
            ViewBag.Message = "Your application description page.";
            return View();
        }
        public ActionResult GetTicket()
        {
            return View();
        }

        public ActionResult TicketList()
        {
            List<Ticket> list = new List<Ticket>();
            list = mapper.MapTicketModelList2TicketList(ticketViewMethod.GetTicketList());
            return View(list);
        }
    }
}