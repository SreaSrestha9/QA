using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using Automation.PageServices;


namespace Automation
{
    class Program:SiteDriver
    {
        static void Main(string[] args)
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArguments("disable-infobars");
            new Program(new ChromeDriver(option) { Url = "http://shakarbhattarai.com.np/wordpress/" });
            
            
        }
        public Program(IWebDriver _webDriver) : base(_webDriver) {


            try
            {
                var currentUrl = GetCurrentUrl();
                //SiteDriver.dismiss();
                MainPageService.clickOnMancCityTitle();
                var differentUrl = GetCurrentUrl();

                VerifyOnClickingSubmitPageRedirects(currentUrl, differentUrl);

                Assert.True(ManCityService.CheckOrder1());
                Assert.True(ManCityService.CheckOrder());
                ManCityService.setAuthor("Author Test");
                ManCityService.setEmailID("Test@gmail.com");
                ManCityService.setURL("www.test.com");
                ManCityService.setComment("test");
                ManCityService.clicksubmit();

               
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally { SiteDriver.closeDriver(); }
        }

        public void VerifyOnClickingSubmitPageRedirects(string currentUrl, string differentUrl) {
            Assert.AreNotEqual(currentUrl, differentUrl);
       }
    }
}
