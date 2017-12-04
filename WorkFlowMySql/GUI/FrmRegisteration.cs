using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkFlowMySql.BLL;

namespace WorkFlowMySql.GUI
{
    public partial class FrmRegisteration : Form
    {
        private UserModel user = new UserModel();
        UserMethods userMethods = new UserMethods();
        EmailServiceMethods email = new EmailServiceMethods();
        int securiteCode = 0;

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
            if (!string.IsNullOrEmpty(txtUserName.Text) && VerifySecuriteCode())
            {

                using (var context = new WorkFlowContext())
                {
                    context.Customer.Add(new UserModel
                    {
                        Pass = userMethods.HashPassword(txtPass.Text),
                        UserName = txtUserName.Text,
                        UserType = cbUserType.SelectedItem.ToString(),
                        Email = txtEmail.Text,
                        RegisterDate = DateTime.Now
                    });
                    context.SaveChanges();
                    MessageBox.Show("Registered succed");
                    
                    /*var CustomerQuery = context.Customer.Where(s => s.UserId == 1).ToList();
                    var user = CustomerQuery.FirstOrDefault<UserModel>();
                    MessageBox.Show(string.Format("{0}", user.UserName));*/
                }
            }
            else
                return;
        }
        private bool ConfirmValidation()
        {
            if(txtPass.Text !=txtConfPass.Text)
            {
                MessageBox.Show("Different passwords");
                return false;
            }
            else if (txtEmail.Text != txtConfEmail.Text)
            {
                MessageBox.Show("Different email");
                return false;
            }
            return true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!ConfirmValidation() && string.IsNullOrEmpty(txtUserName.Text))
            {
                return;
            }

            securiteCode = GenerateSecuriteCode();
            email.Sendit(txtEmail.Text, securiteCode);
            label7.Visible = true;
            txtVerificationCode.Visible = true;
        }

        private int GenerateSecuriteCode()
        {
            Random rnd = new Random();
            return rnd.Next(1, 1000);
        }

        private bool VerifySecuriteCode()
        {
            if (securiteCode == Convert.ToInt32(txtVerificationCode.Text))
                return true;
            else
            {
                MessageBox.Show("Security code is wrong");
                return false;
            }
        }
    }
}

