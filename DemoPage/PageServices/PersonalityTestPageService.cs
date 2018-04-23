using System;
using System.Collections.Generic;
using System.Text;
using SiteDriverHandler;
using DemoPage.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections;
using System.Threading;
using System.Linq;

namespace DemoPage.PageService
{
    class PersonalityTestPageService
    {
        //private static List<string> checkboxList = new List<string>() {"" };
        public static void SetFullName(string strFullName)
        {
            SiteDriver.SendKeys(PersonalityTestPageObject.fullName, "CSSSelector", strFullName);
        }

        public static void SelectGender(int gender=1)
        {
            List<IWebElement> listElements = SiteDriver.FindElements(PersonalityTestPageObject.gender, "CSSSelector");
            listElements[gender].Click();
        }

        public static int SelectMultipleGender()
        {
            List<IWebElement> listElements = SiteDriver.FindElements(PersonalityTestPageObject.gender, "CSSSelector");
            int count = 0;
            foreach (IWebElement e in listElements) {
                e.Click();
            }

            foreach (IWebElement e in listElements) {
               count+=e.Selected?1:0;
               
            }
            return count;

                 
        }
        public static void SetEmail(string strEmail)
        {
            SiteDriver.SendKeys(PersonalityTestPageObject.email, "CSSSelector", strEmail);
        }

        public static void SetUserName(string strUName)
        {
            SiteDriver.SendKeys(PersonalityTestPageObject.username, "CSSSelector", strUName);
        }

        public static void SetPassword(string strPassword)
        { SiteDriver.SendKeys(PersonalityTestPageObject.password, "CSSSelector", strPassword); }

        public static void SetCity(string strCity)
        { SiteDriver.SendKeys(PersonalityTestPageObject.city, "CSSSelector", strCity); }

        public static void SetState(string strState)
        { SiteDriver.SendKeys(PersonalityTestPageObject.state, "CSSSelector", strState); }

        public static void SetZipCode(string strZipCode)
        { SiteDriver.SendKeys(PersonalityTestPageObject.zipCode, "CSSSelector", strZipCode); }

        public static void SetContactNo(string strContactNo)
        { SiteDriver.SendKeys(PersonalityTestPageObject.contactNo, "CSSSelector", strContactNo); }
        
        public static void SetIntroduction(string strIntro)
        { SiteDriver.SendKeys(PersonalityTestPageObject.introdution, "CSSSelector", strIntro);
          
              }
       
        /*
        public static void SetIntroduction()
        {
            string textarea = SiteDriver.FindElement(PersonalityTestPageObject.introdution, "CSSSelector").Text;
            
        }
        */
        public static void SetHobbies(string strHobbies)
        { SiteDriver.SendKeys(PersonalityTestPageObject.hobbies, "CSSSelector", strHobbies); }

        public static void ClickFavFood()
        {
            List<IWebElement> listElements = SiteDriver.FindElements(PersonalityTestPageObject.favFood, "CSSSelector");


            foreach (IWebElement e in listElements)
            {
                e.Click();
            }

        }

        public static int SelectMutipleFavFood() {
            int count = 0;
            PersonalityTestPageService.ClickFavFood();
            foreach (IWebElement e in SiteDriver.FindElements(PersonalityTestPageObject.favFood, "CSSSelector")) {
                count += e.Selected?1:0;
            }
            Console.WriteLine("count:"+count);
            return count;
           
            }

        public static void SelectSkills(string skill)
        {
            SelectElement selectElement = new SelectElement(SiteDriver.FindElement(PersonalityTestPageObject.skills, "CSSSelector"));
            selectElement.SelectByText(skill);
        }

        public static void SelectCountry(string country)
        {
            SelectElement selectElement = new SelectElement(SiteDriver.FindElement(PersonalityTestPageObject.country, "CSSSelector"));
            selectElement.SelectByText(country);
        }

        public static Boolean IsMultipleSkillSelect
        {
            get
            {
                SelectElement selectElement = new SelectElement(SiteDriver.FindElement(PersonalityTestPageObject.skills, "CSSSelector"));
                return selectElement.IsMultiple;
            }
        }
        public static Boolean IsMultipleCountrySelect
        {
            get
            {
                SelectElement selectElement = new SelectElement(SiteDriver.FindElement(PersonalityTestPageObject.country, "CSSSelector"));
                return selectElement.IsMultiple;
            }
        }

        public static void SelectFavItem()
        {
            List<IWebElement> listElements = SiteDriver.FindElements(PersonalityTestPageObject.fav, "CSSSelector");

            foreach (IWebElement e in listElements)
            {/*
                if (e.GetAttribute("value").Substring(5, 1) == "1")
                {*/
                    e.Click();
                }
           // }
        }


        public static void ClickSubmitButton()
        {
            SiteDriver.Click(PersonalityTestPageObject.submitBtn, "CSSSelector");
        }

        public static void ClickResetButton()
        {
            SiteDriver.Click(PersonalityTestPageObject.resetBtn, "CSSSelector");
        }
   
        
        public static string getEmailAddress()
        {
            return getTextBoxValue(PersonalityTestPageObject.email, "CSSSelector");
        }

        public static string getTextBoxValue(string selector, string how)
        {
            return SiteDriver.FindElement(selector, how).GetAttribute("value");

        }

        public static bool CheckNumericZip
        {
            get
            {
                try
                {
                    string zip = getTextBoxValue(PersonalityTestPageObject.zipCode, "CSSSelector");
                    Convert.ToInt32(zip);
                    return true;
                }
                catch (InvalidCastException e)
                {
                    return false;
                }
            }
        }

       
    }

}



