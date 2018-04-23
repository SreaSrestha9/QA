using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using DemoPage.PageObjects;
using SiteDriverHandler;


namespace DemoPage.PageService
{
    class DemoMainPageService
    {
        public static void ClickOnDemo()
        {
            SiteDriver.Click(DemoMainPageObject.demo, "CSSSelector");
        }
    }
}
