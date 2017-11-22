using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkFlowMySql.GUI;

namespace WorkFlowMySql.GUI
{
    public partial class FrmLoginMenu : Form
    {
        UserModel user = new UserModel();
        
        public FrmLoginMenu()
        {
            InitializeComponent();
        }

        private void llblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (FrmRegisteration frm = new FrmRegisteration())
            {
               frm.ShowDialog(this);
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            CopyValueFromControls();
           if(!ValidateUser())
            {
                MessageBox.Show("Wrong Login or Password");
                return;
            }
            using (FrmUserMenu frm = new FrmUserMenu(user))
            {
                frm.ShowDialog(this);
            }
        }

        private void CopyValueFromControls()
        {
            if(!string.IsNullOrEmpty(txtLogin.Text))
            {
                user.UserName = txtLogin.Text;
            }
            if (!string.IsNullOrEmpty(txtPass.Text))
            {
                user.Pass = txtPass.Text;
            }
        }

        private bool ValidateUser()
        {
            if (user.Pass == GetUserFromDb())
                return true;

            return false;
        }

        private string GetUserFromDb()
        {
            string userPass = string.Empty;
            using (var context = new WorkFlowContext())
            {
                var CustomerQuery = context.Customer.Where(s => s.UserName == user.UserName);
                foreach (var users in CustomerQuery)
                {
                    userPass = users.Pass;
                }
            }
            return userPass;
        }
        /*var CustomerQuery = context.Customer.Where(s => s.UserId == 1).ToList();
                    var user = CustomerQuery.FirstOrDefault<UserModel>();
                    MessageBox.Show(string.Format("{0}", user.UserName));*/
    }
}
