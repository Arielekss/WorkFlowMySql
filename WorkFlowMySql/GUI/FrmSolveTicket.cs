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
    public partial class FrmSolveTicket : Form
    {
        private TicketHeader ticketHeader;
        private TicketBody ticketBody;
        private TicketServiceMethods serviceMethods = new TicketServiceMethods();

        private FrmSolveTicket()
        {
            InitializeComponent();
        }

        public FrmSolveTicket(TicketHeader ticketHeader, TicketBody ticketBody)
        {
            InitializeComponent();
            this.ticketBody = ticketBody;
            this.ticketHeader = ticketHeader;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadData();
        }

        private void LoadData()
        {
            txtHeader.Text = ticketHeader.Header;
            txtActiveUser.Text = ticketHeader.ActiveUser;
            rTxtContent.Text = ticketBody.Content;
            txtStatus.Text = ticketHeader.Status;
        }

        private void btnTicketCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel the ticket?", "Cancelation",
                MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                serviceMethods.UpdateTicketStatusById(ticketHeader.TicketId, "Cancel", null);
                ticketHeader.Status = "Cancel";
                LoadData();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private bool ValidateResponse()
        {
            if (string.IsNullOrEmpty(rTxtResponse.Text))
            {
                MessageBox.Show("Please enter the response");
                return false;
            }
            return true;
        }

        private void btnCloseTicket_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to close the ticket and send respond?", "Close Ticket",
                MessageBoxButtons.YesNo);

            if (!ValidateResponse())
            {
                return;
            }
            CopyValueFromControls();
            if (dialogResult == DialogResult.Yes)
            {
                serviceMethods.UpdateTicketStatusById(ticketHeader.TicketId, "Close", ticketBody.Response);
                ticketHeader.Status = "Close";
                LoadData();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void CopyValueFromControls()
        {
            if(!string.IsNullOrEmpty(rTxtResponse.Text))
            {
                ticketBody.Response = rTxtResponse.Text;
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
        }

        private void llblForward_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (FrmUserPickingList frm = new FrmUserPickingList())
            {
                frm.ShowDialog(this);
                if (frm.DialogResult == DialogResult.OK)
                {
                    serviceMethods.MoveTicketToAnotherUser(ticketHeader,frm.selectedUser);
                    serviceMethods.AddComment(ticketHeader, frm.comment);
                    //TODO: dorobić zamknięcie
                }
            }
        }
    }
}
