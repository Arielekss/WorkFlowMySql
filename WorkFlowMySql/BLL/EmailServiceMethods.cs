using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkFlowMySql.BLL
{
    public class EmailServiceMethods
    {
        public void Sendit(string ReciverMail, int securityCode)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.poczta.onet.pl");

                mail.From = new MailAddress("arielekss.workflowapp@onet.pl");
                mail.To.Add(ReciverMail);
                mail.Subject = "WorkflowApp security code";
                mail.Body = string.Format("Please enter this code: {0} to WorkflowApp registration windows to confirm registration process.", securityCode);

                SmtpServer.Port = 465; //587
                SmtpServer.Credentials = new System.Net.NetworkCredential("arielekss.workflowapp", "Martwa90");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("Please check Your emailBox. We are sending security code to confirm registration.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
