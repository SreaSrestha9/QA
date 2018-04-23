using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using Microsoft.VisualBasic;

namespace SiteDriverHandler
{
    public class SiteDriver
    {
         
        private static IWebDriver _webDriver;
        public SiteDriver(IWebDriver webDriver)
        {
            webDriver.Manage().Window.Maximize();
            _webDriver = webDriver;            
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            
           
        }

        public static IWebElement FindElement(string selector, string how)
        {
            switch (how)
            {
                case "CSSSelector":
                    return _webDriver.FindElement(By.CssSelector(selector));
                case "XPath":
                    return _webDriver.FindElement(By.XPath(selector));
                default:
                    return _webDriver.FindElement(By.Id(selector));
            }
        }
        public static List<IWebElement> FindElements(string selector, string how)
        {
            switch (how)
            {
                case "CSSSelector":
                    return _webDriver.FindElements(By.CssSelector(selector)).ToList();
                case "XPath":
                    return _webDriver.FindElements(By.XPath(selector)).ToList();
                default:
                    return _webDriver.FindElements(By.Id(selector)).ToList();
            }
        }

        public static void Click(string selector, string How)
        {
            FindElement(selector, How).Click();
        }

        public static void SendKeys(string selector, string How, string text)
        {
            FindElement(selector, How).SendKeys(text);
        }

        public static string ReplicateString(string text)
        {
            string myvar = text; 
            StringBuilder b = new StringBuilder(myvar.Length * 2000);
            for (int i = 0; i != 2000; ++i)
            {
                b.Append(myvar);
            }
            return b.ToString();
        }

        public static string GetCurrentUrl()
        {
            return _webDriver.Url;
        }

        public static void OpenUrl(string url)
        {
            _webDriver.Url = url;
        }

        public static void closeDriver()
        {

            _webDriver.Close();
        }

        public static void ToList(string selector, string How)
        {
            List<IWebElement> listElements = FindElements(selector, How).ToList();
        }


        public static bool _IsOrdered(IList<IWebElement> list, IList<string> comparer)
        {
            if (list.Count > 1)
            {
                for (int i = 1; i < list.Count; i++)
                {
                    if (list[i].Text != comparer[i].ToString())
                    { return false; }
                }
            }
            return true;
        }

        public static bool _IsOrdered(IList<string> list, IList<string> comparer)
        {
            if (list.Count > 1)
            {
                for (int i = 1; i < list.Count; i++)
                {
                    if (list[i].ToString() != comparer[i].ToString())
                    { return false; }
                }
            }
            else {
                return false;
            }
            return true;
        }

     
            
        
    }
}

