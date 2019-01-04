using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace TestAutomationFramework
{
    public static class Browser
    {
        private static string baseUrl = "http://localhost:12921/";        
        private static IWebDriver _webDriver = new ChromeDriver();

        public static void Initialize()
        {
            Goto("");
        }

        public static string Title
        {
            get { return _webDriver.Title; }
        }

        public static ISearchContext Driver
        {
            get { return _webDriver; }
        }

        public static void Goto(string url)
        {
            _webDriver.Url = baseUrl + url;
        }

        public static void Close()
        {
            _webDriver.Close();
        }
    }
}