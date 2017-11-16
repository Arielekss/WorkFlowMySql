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
    public partial class FrmViewTicket : Form
    {
        BindingList<TicketModel> ticketList = new BindingList<TicketModel>();
        TicketViewModel ticketView = new TicketViewModel();
        private string userName;

        public FrmViewTicket()
        {
            InitializeComponent();
        }

        public FrmViewTicket(string userName)
        {
            InitializeComponent();
            this.userName = userName;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            RefreshList();
        }

        private void RefreshList()
        {
            if (string.IsNullOrEmpty(userName))
                dgTicketView.DataSource = ticketView.GetTicketList();

            else
                dgTicketView.DataSource = ticketView.GetTicketListByUser(userName);
        }
    }
}
