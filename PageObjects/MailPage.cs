using OpenQA.Selenium;

namespace Lesson_7_PageObject.PageObjects
{
    public class MailPage : BasePage
    {
        private static readonly By LoginLnl = By.XPath("//*[@class='mail-App-Footer-Item']");

        public MailPage() : base(LoginLnl, "© 2001—2023, ") {}

        private readonly BaseElement _userAccount = new BaseElement(By.CssSelector("[class = 'user-account__name']"));
        private readonly BaseElement _writeNewMail = new BaseElement(By.CssSelector("[class = 'Button2 Button2_type_link Button2_view_action Button2_size_m Layout-m__compose--pTDsx qa-LeftColumn-ComposeButton ComposeButton-m__root--fP-o9']"));
        private readonly BaseElement _passwordField = new BaseElement(By.CssSelector("[name = 'passwd']"));
        private readonly BaseElement _signIn = new BaseElement(By.CssSelector("[id = 'passp:sign-in']"));

        public string GetAccountName()
        {
            return _userAccount.GetText();
        }

        public void WriteNewMail()
        {
            _writeNewMail.Click();
        }

        public void SignIn()
        {
            _signIn.Click();
        }
    }
}
