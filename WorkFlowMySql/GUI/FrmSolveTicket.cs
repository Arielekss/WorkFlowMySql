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
                serviceMethods.UpdateTicketStatusById(ticketHeader.TicketId, "Cancel");
                ticketHeader.Status = "Cancel";
                LoadData();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
    }
}
