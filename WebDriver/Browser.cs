using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7_PageObject.WebDriver
{
    public class Browser
    {
        private static Browser _currentInstance;
        private static IWebDriver _driver;
        public static BrowserFactory.BrowserType _currentBrowser;
        public static int ImplWait;
        public static double _timeoutForElement;
        private static string _browser;

        private Browser()
        {
            InitParams();
            _driver = BrowserFactory.GetDriver(_currentBrowser, ImplWait);
        }

        private static void InitParams()
        {
            ImplWait = Convert.ToInt32(Configuration.ElementTimeout);
            _timeoutForElement = Convert.ToDouble(Configuration.ElementTimeout);
            _browser = Configuration.Browser;
            Enum.TryParse(_browser, out _currentBrowser);
        }

        public static Browser Instance => _currentInstance ?? (_currentInstance = new Browser());

        public static void WindowMaximize()
        {
            _driver.Manage().Window.Maximize();
        }

        public static void NavigateTo(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public static IWebDriver GetDriver()
        {
            return _driver;
        }

        public static void Quit()
        {
            _driver.Quit();
            _currentInstance = null;
            _driver = null;
            _browser = null;
        }
    }
}
