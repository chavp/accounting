using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Mail;
using System.Net;

namespace Chavp.Accounting.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var smtpClient = new SmtpClient();
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Host = "saleshub-smtp-demo.herokuapp.com";
            //smtpClient.Port = 2525;
            smtpClient.Credentials = new NetworkCredential("testuser", "testpass");
            //smtpClient.EnableSsl = true;
            smtpClient.Send(new MailMessage("my.parinya@gmail.com", "55@localhost", "Test", "Hello"));
            smtpClient.SendCompleted += SmtpClient_SendCompleted;
        }

        private void SmtpClient_SendCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            Console.WriteLine("SmtpClient_SendCompleted");
        }
    }
}
