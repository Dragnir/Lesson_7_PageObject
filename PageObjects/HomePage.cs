using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7_PageObject.PageObjects
{
    public class HomePage : BasePage
    {
        private static readonly By HomeLnl = By.ClassName("");

        public HomePage() : base(HomeLnl, "") {}

        private readonly BaseElement _loginButton = new BaseElement(By.XPath("//*[text()='Log in']/ancestor::button"));

        public void GoToLogin()
        {
            _loginButton.Click();
        }

    }
}
