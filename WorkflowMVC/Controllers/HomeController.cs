using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkFlowMySql.Data;

namespace WorkflowMVC.Controllers
{
    public class HomeController : Controller
    {
        TicketModel ticketModel = new TicketModel();
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

        public ActionResult CreateTicket()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

    }
}