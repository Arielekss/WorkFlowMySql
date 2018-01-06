using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using WorkflowMVC.MapMethods;
using WorkflowMVC.Models;
using WorkFlowMySql.BLL;
using WorkFlowMySql.BLL.User;
using WorkFlowMySql.Data;
using WorkFlowMySql.GUI;

namespace WorkflowMVC.Controllers
{
    public class HomeController : Controller
    {
        private TicketHeader ticketModel = new TicketHeader();
        private UserModel userModel = new UserModel();
        private UserRegistration userRegistration = new UserRegistration();
        private UserValidation userValidation = new UserValidation();
        private ModelsMapper mapper = new ModelsMapper();
        private TicketViewMethods ticketViewMethod = new TicketViewMethods();
        WorkFlowMySql.BLL.TicketCreator ticketCreator = new TicketCreator();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your appslication description page.";

            return View();
        }
        
        public ActionResult TicketCreator(WebTicketHeader ticket)
        {
            TicketBody ticketBodyContent= new TicketBody();
            ticketBodyContent.Content = ticket.Content;
            if (!string.IsNullOrEmpty(ticket.Header))
            {
                ticketCreator.SendTicketToDb(mapper.MapTicket2TicketModel(ticket), ticketBodyContent);
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
            List<WebTicketHeader> list = new List<WebTicketHeader>();
            list = mapper.MapTicketModelList2TicketList(ticketViewMethod.GetTicketList());
            return View(list);
        }

        public ActionResult LogIn(WebUserModel webUserModel)
        {
            if(userValidation.ValidateUserLoginAndPassword(userModel = mapper.MapWebUserModel2UserModel(webUserModel)))
            return View("TicketCreator");
            else
            {
                return View("Index");
            }
        }

        public ActionResult Register()
        {
            return View("Register");
        }

        public ActionResult CreateUser(WebUserModel webUserModel)
        {
            userModel = mapper.MapWebUserModel2UserModel(webUserModel);
            if (userModel != null)
            {
                userRegistration.CreateUserAccount(userModel);
            }
            return View("Index");
        }
    }
}