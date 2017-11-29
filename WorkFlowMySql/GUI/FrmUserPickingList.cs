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

namespace WorkFlowMySql.GUI
{
    public partial class FrmUserPickingList : Form
    {
        UserMethods user = new UserMethods();
        public UserModel selectedUser = new UserModel();
        string comment = String.Empty;
        public FrmUserPickingList()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            dbgChooseUser.DataSource = user.GetUserList();
        }

        private void dbgChooseUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dbgChooseUser.Rows[index];
            selectedUser.UserId = Convert.ToInt32(selectedRow.Cells[0].Value);
            selectedUser.UserName = selectedRow.Cells[1].Value.ToString();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            CopyCommentFromControls();
            if (DialogResult != DialogResult.OK || !CopyCommentFromControls())
            {
                return;
            }
        }

        private bool CopyCommentFromControls()
        {
            if (!string.IsNullOrEmpty(rTxtComment.Text))
            {
                comment = rTxtComment.Text;
                return true;
            }
            MessageBox.Show("Enter comment");
            return false;
        }
    }
}
