﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorkflowMVC.Models;
using WorkFlowMySql.Data;
using WorkFlowMySql.GUI;

namespace WorkflowMVC.MapMethods
{
    public class ModelsMapper
    {
        public TicketHeader MapTicket2TicketModel(WebTicketHeader ticket)
        {
            return new TicketHeader()
            {
                Header = ticket.Header,
                Priority = ticket.Priority,
                RegisterDate = ticket.RegisterDate,
                UserRegister = ticket.UserRegister,
                TicketId = ticket.TicketId,
                ActiveUser = ticket.ActiveUser,
                Deadline = ticket.Deadline,
                CloseDate = ticket.CloseDate,
                Guid = ticket.Guid,
                Status = ticket.State
            };
        }

        public List<WebTicketHeader> MapTicketModelList2TicketList(List<TicketHeader> ticket)
        {
            List<WebTicketHeader> ticketList = new List<WebTicketHeader>();
            foreach (TicketHeader ticketModel in ticket)
            {
                ticketList.Add(new WebTicketHeader()
                {
                    Header = ticketModel.Header,
                    Priority = ticketModel.Priority,
                    RegisterDate = ticketModel.RegisterDate,
                    UserRegister = ticketModel.UserRegister,
                    TicketId = ticketModel.TicketId,
                    ActiveUser = ticketModel.ActiveUser,
                    Deadline = ticketModel.Deadline,
                    CloseDate = ticketModel.CloseDate,
                    Guid = ticketModel.Guid,
                    State = ticketModel.Status
                });
            }
            return ticketList;
        }

        public WebTicketBody MapWebTicketContent2TicketModelContent(TicketBody ticketBody)
        {
            return new WebTicketBody()
            {
                TicketGuid = ticketBody.TicketGuid,
                Response = ticketBody.Response,
                Id = ticketBody.Id,
                Content = ticketBody.Content
            };
        }

        public TicketBody MapTicketBody2WebTicketContent(WebTicketBody webTicketContent)
        {
            return new TicketBody()
            {
                TicketGuid = webTicketContent.TicketGuid,
                Response = webTicketContent.Response,
                Id = webTicketContent.Id,
                Content = webTicketContent.Content
            };
        }

        public WebUserModel MapWebUserModel2UserModelMapUserModel2WebUserModel(UserModel userModel)
        {
            return new WebUserModel()
            {
                UserId = userModel.UserId,
                UserName = userModel.UserName,
                Pass = userModel.Pass,
                Email = userModel.Email,
                RegisterDate = userModel.RegisterDate,
                UserType = userModel.UserType
            };
        }

        public UserModel MapWebUserModel2UserModel(WebUserModel webUserModel)
        {
            return new UserModel()
            {
                UserId = webUserModel.UserId,
                UserName = webUserModel.UserName,
                Pass = webUserModel.Pass,
                Email = webUserModel.Email,
                RegisterDate = webUserModel.RegisterDate,
                UserType = webUserModel.UserType
            };

        }
    }
}