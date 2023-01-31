using Lesson_7_PageObject.PageObjects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson_7_PageObject.Tests
{
    public class MailTests : BaseTest
    {
        private HomePage _homePage;
        private LoginPage _loginPage;
        private MailPage _mailPage;
        private string userName = "vadim.kuryan.vka";

        [Test]
        public void SendMailTest()
        {
            _homePage = new HomePage();
            _homePage.GoToLogin();
            _loginPage = new LoginPage();
            _loginPage.SetLogin(userName);
            _loginPage.SetPassword("Vka_6463296");
            _loginPage.SignIn();
            _mailPage = new MailPage();
            //Assert.AreEqual(userName, _mailPage.GetAccountName());
            _mailPage.WriteNewMail();
            Thread.Sleep(2000);
        }
    }
}
