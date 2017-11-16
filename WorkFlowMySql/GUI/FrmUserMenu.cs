using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkFlowMySql.Data;

namespace WorkFlowMySql.GUI
{
    public partial class FrmUserMenu : Form
    {
        UserModel user;
        private FrmUserMenu()
        {
            InitializeComponent();
        }

        public FrmUserMenu(UserModel user)
        {
            InitializeComponent();
            this.user = user;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            PrepareControls();
        }

        private void PrepareControls()
        {
            txtUser.Text = user.UserName;
        }

        private void btnCreateTick_Click(object sender, EventArgs e)
        {
            using (FrmCreateTicket frm = new FrmCreateTicket(user))
            {
                frm.ShowDialog(this);
            }
        }

        private void btnTicketView_Click(object sender, EventArgs e)
        {
            using (FrmViewTicket frm = new FrmViewTicket())
            {
                frm.ShowDialog(this);
            }
        }

        private void btnUserTick_Click(object sender, EventArgs e)
        {
            using (FrmViewTicket frm = new FrmViewTicket(user.UserName))
            {
                frm.ShowDialog(this);
            }
        }
    }
}
