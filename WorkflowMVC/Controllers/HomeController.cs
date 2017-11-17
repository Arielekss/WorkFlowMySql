using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkflowMVC.Models;
using WorkFlowMySql.BLL;
using WorkFlowMySql.Data;

namespace WorkflowMVC.Controllers
{
    public class HomeController : Controller
    {
        TicketModel ticketModel = new TicketModel();
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

        public ActionResult TicketCreator()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult CreateTicket(TicketModel ticketModel)
        {
            ViewBag.Message = "Your application description page.";
            ticketCreator.SendTicketToDb(ticketModel);
            return View();
        }

    }
}