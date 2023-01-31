using Lesson_7_PageObject.PageObjects;
using NUnit.Framework;
using System.Threading;

namespace Lesson_7_PageObject.Tests
{
    public class MailTests : BaseTest
    {
        private HomePage _homePage;
        private LoginPage _loginPage;
        private MailPage _mailPage;
        private string userName = "vadim.kuryan.vka";
        private string password = "Vka_6463296";

        [Test]
        public void SendMailTest()
        {
            _homePage = new HomePage();
            _homePage.GoToLogin();
            _loginPage = new LoginPage();
            _loginPage.SetLogin(userName);
            _loginPage.SetPassword(password);
            _loginPage.SignIn();
            _mailPage = new MailPage();
            //Assert.AreEqual(userName, _mailPage.GetAccountName());
            _mailPage.WriteNewMail("dragnir@tut.by", "TestSubject", "TestBody");
            _mailPage.SaveMailAsDraft();
            _mailPage.GoToDraftFolder();
            Thread.Sleep(2000);
        }
    }
}
