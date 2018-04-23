using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SiteDriverHandler;
using System;
using DemoPage.PageService;
using System.Collections.Generic;

namespace DemoPage
{
    public class MainProgram : SiteDriver
    {
        public static void Main(string[] args)
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArguments("disable-infobars");

            new MainProgram(new ChromeDriver(option) { Url = "https://wingskushma.github.io/pages/index.html" });
        }
        public MainProgram(IWebDriver webDriver) : base(webDriver)
        {
            string prevUrl = SiteDriver.GetCurrentUrl();
            DemoMainPageService.ClickOnDemo();
            string currUrl = SiteDriver.GetCurrentUrl();
            

            verifyDiffUrl(prevUrl, currUrl);

            PersonalityTestPageService.SetFullName("Shreya Shrestha");
            PersonalityTestPageService.SelectGender();
            PersonalityTestPageService.SetEmail("srea.srestha9@gmail.com");
            PersonalityTestPageService.SetPassword("jakdjflkajfdk");
            PersonalityTestPageService.SetCity("Kathmandu");
            PersonalityTestPageService.SetState("Nepalmandal");
            PersonalityTestPageService.SetZipCode("00977");
            PersonalityTestPageService.SetContactNo("9849310444");
            PersonalityTestPageService.SetIntroduction(SiteDriver.ReplicateString("intro "));
            PersonalityTestPageService.SetHobbies(SiteDriver.ReplicateString("hobbies "));
            PersonalityTestPageService.ClickFavFood();
            PersonalityTestPageService.SelectSkills("Coding");
            PersonalityTestPageService.SelectCountry("Switzerland");
            PersonalityTestPageService.SelectFavItem();

            prevUrl = currUrl;
            PersonalityTestPageService.ClickSubmitButton();
            //bool moveahead = false;
            //try
            //{
            //    List<IWebElement> elements = SiteDriver.FindElements("input:invalid", "CSSSelector");
            //    foreach(IWebElement e in elements)
            //    {
            //        Console.WriteLine(e.)
            //    }
            //}
            //catch(NoSuchElementException e)
            //{
            //    moveahead = true;
            //}
          
            currUrl = SiteDriver.GetCurrentUrl();
            verifyDiffUrl(prevUrl, currUrl);
          
            SiteDriver.closeDriver();
        }

      
            public static void verifyDiffUrl(string url1, string url2)
        {
            Assert.True(url1!=url2);
        }

        //PersonalityTestPageService.ClickResetButton();
    }
}
