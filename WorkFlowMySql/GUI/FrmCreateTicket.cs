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
using WorkFlowMySql.Data;

namespace WorkFlowMySql.GUI
{
    public partial class FrmCreateTicket : Form
    {
        UserModel user;
        TicketHeader ticketHeader = new TicketHeader();
        TicketBody ticketBody = new TicketBody();
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
            ticketCreator.SendTicketToDb(ticketHeader, ticketBody);
        }

        private void CopyValueFromControls()
        {
            if(!string.IsNullOrEmpty(txtTicketHeader.Text))
            {
                ticketHeader.Header = txtTicketHeader.Text;
            }
            if (!string.IsNullOrEmpty(rtxtTicketContent.Text))
            {
                ticketBody.Content = rtxtTicketContent.Text;
            }
            ticketHeader.Priority = cbPriority.SelectedItem.ToString();
            ticketHeader.UserRegister = user.UserName;
            ticketHeader.RegisterDate = DateTime.Now;
            ticketHeader.Deadline = ticketCreator.CalculateDeadline(ticketHeader.Priority);
           
        }
        
    }
}
