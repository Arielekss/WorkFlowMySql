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
        public string comment = String.Empty;
        int? index = null;

        public FrmUserPickingList()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            dbgChooseUser.DataSource = user.GetUserList();
            if (index.HasValue)
                btnChoose.Enabled = true;
            else
                btnChoose.Enabled = false;
        }

        private void dbgChooseUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow selectedRow = dbgChooseUser.Rows[index.Value];
            selectedUser.UserId = Convert.ToInt32(selectedRow.Cells[0].Value);
            selectedUser.UserName = selectedRow.Cells[1].Value.ToString();
            if (index.HasValue)
                btnChoose.Enabled = true;
            else
                btnChoose.Enabled = false;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            bool corectValues = CopyCommentFromControls();
            if (DialogResult != DialogResult.OK || !corectValues)
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
            else
            { MessageBox.Show("Enter comment");
                return false;
             }
        }
    }
}
