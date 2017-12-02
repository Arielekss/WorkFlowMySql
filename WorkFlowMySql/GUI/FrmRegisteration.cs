using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkFlowMySql.GUI
{
    public partial class FrmRegisteration : Form
    {
        private UserModel user = new UserModel();
        

        public FrmRegisteration()
        {
            InitializeComponent();
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
            
        }

        private void CopyValueFromControls()
        {
            if (!string.IsNullOrEmpty(txtUserName.Text))
            {
                using (var context = new WorkFlowContext())
                {
                    context.Customer.Add(new UserModel
                    {
                        Pass = txtPass.Text,
                        UserName = txtUserName.Text,
                        UserType = cbUserType.SelectedItem.ToString()
                    });
                    context.SaveChanges();
                    MessageBox.Show("Registered succed");


                    /*var CustomerQuery = context.Customer.Where(s => s.UserId == 1).ToList();
                    var user = CustomerQuery.FirstOrDefault<UserModel>();
                    MessageBox.Show(string.Format("{0}", user.UserName));*/
                }
            }
        }
    }
}

