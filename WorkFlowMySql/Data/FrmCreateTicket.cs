using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkFlowMySql.BLL;

namespace WorkFlowMySql.Data
{
    public partial class FrmCreateTicket : Form
    {
        UserModel user;
        TicketModel ticket = new TicketModel();
        TicketCreator ticketCreator = new TicketCreator();

        private FrmCreateTicket()
        {
            InitializeComponent();
        }

        public FrmCreateTicket(UserModel user)
        {
            InitializeComponent();
            this.user = user;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            if (DialogResult != DialogResult.OK)
                return;

            CopyValueFromControls();
            ticketCreator.SendTicketToDb(ticket);
        }

        private void CopyValueFromControls()
        {
            if(!string.IsNullOrEmpty(txtTicketHeader.Text))
            {
                ticket.Header = txtTicketHeader.Text;
            }

            
            ticket.Priority = cbPriority.SelectedItem.ToString();
            ticket.UserRegister = user.UserName;
            ticket.RegisterDate = DateTime.Now;
            ticket.Deadline = ticketCreator.CalculateDeadline(ticket.Priority);
        }
        
    }
}
