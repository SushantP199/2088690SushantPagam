using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerCommLib;
using NUnit.Framework;
using Moq;

namespace CustomerCommTests
{
    [TestFixture]
    public class MailSenderShould
    {

        [OneTimeSetUp]
        public void init()
        {
            Mock<IMailSender> mailsenderMOck = new Mock<IMailSender>();

            var mailSender = mailsenderMOck.Object;
            var cust = new CustomerComm(mailSender);

        }

   

        [Test]
        public void SemdMailToCustomerTest()
        {

            Mock<IMailSender> mailsenderMOck = new Mock<IMailSender>();

            var mailSender = mailsenderMOck.Object;
            var cust = new CustomerComm(mailSender);
            var actual= cust.SendMailToCustomer();

            Assert.That(actual,Is.True);
        }


    }
}
