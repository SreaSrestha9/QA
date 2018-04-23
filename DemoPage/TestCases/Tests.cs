using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SiteDriverHandler;
using OpenQA.Selenium;
using DemoPage.PageObjects;
using DemoPage.PageService;

namespace DemoPage.TestCases
{
    class Tests : TestBase
    {

        [Test]
        public void ClickOnDemo()
        {
            string prevUrl = SiteDriver.GetCurrentUrl();
            DemoMainPageService.ClickOnDemo();
            string currUrl = SiteDriver.GetCurrentUrl();

            Assert.True(prevUrl != currUrl);
        }

        [Test]
        public void CheckGenderOrder()
        {
            DemoMainPageService.ClickOnDemo();
            List<string> lst = new List<string>() { "optionFemale", "optionMale", "optionOther" };
            List<IWebElement> listElements1 = SiteDriver.FindElements(PersonalityTestPageObject.gender, "CSSSelector");
            List<string> listGender = new List<string>();
            foreach (IWebElement e in listElements1)
            {
                listGender.Add(e.GetAttribute("id"));
            }
            Assert.True(SiteDriver._IsOrdered(listGender, lst));

        }

        [Test]
        public void CheckElementsOrder()
        {
            DemoMainPageService.ClickOnDemo();
            List<string> lst = new List<string>()
            {"Full Name","Gender","Email","Username","Password","City","State","Zip Code","Contact No","Introduce yourself","What are your hobbies","Favourite Food","Select Skills","Country","Favourite Item A","Favourite Item B","Favourite Item C","Favourite Item D","Favourite Item E","Favourite Item F","Favourite Item G","Favourite Item I","Favourite Item J","Favourite Item K","Favourite Item L","Favourite Item L","Favourite Item N","Favourite Item O","Favourite Item P","Favourite Item Q","Favourite Item R","Favourite Item S"};
            List<IWebElement> listElements1 = SiteDriver.FindElements(PersonalityTestPageObject.elementsList, "CSSSelector");
            List<string> listElements = new List<string>();
            foreach (IWebElement e in listElements1)
            {
                listElements.Add(e.Text);
            }
            Assert.True(SiteDriver._IsOrdered(listElements, lst));
        }

        [Test]
        public void CheckFoodOrder()
        {
            DemoMainPageService.ClickOnDemo();
            List<string> lst = new List<string>() { "Pizza", "Burger", "Sandwich", "Chapati" };
            List<IWebElement> listElements1 = SiteDriver.FindElements(PersonalityTestPageObject.foodList, "CSSSelector");
            List<string> listFood = new List<string>();
            foreach (IWebElement e in listElements1)
            {
                listFood.Add(e.Text.Trim());
            }
            Assert.True(SiteDriver._IsOrdered(listFood, lst));

        }
        /*
                public void IsClickable() {
                    DemoMainPageService.ClickOnDemo();
                    List<IWebElement> listElements1 = SiteDriver.FindElements(PersonalityTestPageObject.gender, "CSSSelector");
                    foreach (IWebElement e in listElements1) {
                        ;
                    }
                }*/

        [Test]
        public void OnSubmit()
        {
            DemoMainPageService.ClickOnDemo();

            PersonalityTestPageService.SetFullName("Shreya Shrestha");
            PersonalityTestPageService.SelectGender();
            PersonalityTestPageService.SetEmail("srea.srestha9@gmail.com");
            PersonalityTestPageService.SetPassword("jakdjflkajfdk");
            PersonalityTestPageService.SetCity("Kathmandu");
            PersonalityTestPageService.SetState("Nepalmandal");
            PersonalityTestPageService.SetZipCode("00977");
            PersonalityTestPageService.SetContactNo("9849310444");
            PersonalityTestPageService.SetIntroduction(SiteDriver.ReplicateString("intro "));
            PersonalityTestPageService.SetHobbies(SiteDriver.ReplicateString("replicate"));
            PersonalityTestPageService.ClickFavFood();
            PersonalityTestPageService.SelectSkills("Coding");
            PersonalityTestPageService.SelectCountry("Switzerland");
            PersonalityTestPageService.SelectFavItem();

            string curUrl = SiteDriver.GetCurrentUrl();
            PersonalityTestPageService.ClickSubmitButton();
            string nextpage = SiteDriver.GetCurrentUrl();

            Assert.True(curUrl != nextpage);

        }

        [Test]

        public void OnReset()
        {
            DemoMainPageService.ClickOnDemo();
            string curUrl = SiteDriver.GetCurrentUrl();
            PersonalityTestPageService.SetFullName("Shreya Shrestha");
            PersonalityTestPageService.SelectGender();
            PersonalityTestPageService.SetEmail("srea.srestha9@gmail.com");
            PersonalityTestPageService.SetPassword("jakdjflkajfdk");
            PersonalityTestPageService.SetCity("Kathmandu");
            PersonalityTestPageService.ClickResetButton();
            string diffUrl = SiteDriver.GetCurrentUrl();
            Assert.True(curUrl == diffUrl);

        }

        [Test]
        public void ValidateEmalId()
        {
            DemoMainPageService.ClickOnDemo();
            PersonalityTestPageService.SetEmail("srea.srestha9@gmail.com");
            string email = PersonalityTestPageService.getEmailAddress();
            int atIndex = email.IndexOf("@");
            Assert.True(atIndex > 1 && atIndex < (email.Length - 1));
        }

        [Test]
        public void NoFillSubmit()
        {

            DemoMainPageService.ClickOnDemo();
            string curUrl = SiteDriver.GetCurrentUrl();
            PersonalityTestPageService.ClickSubmitButton();
            string nexturl = SiteDriver.GetCurrentUrl();
            Assert.True(curUrl != nexturl);
        }

        [Test]
        public void MutlipleSelectionsOnCountry()
        {
            DemoMainPageService.ClickOnDemo();
            Assert.True(PersonalityTestPageService.IsMultipleCountrySelect);

        }

        [Test]

        public void MultipleSelectionOnSkills()
        {

            DemoMainPageService.ClickOnDemo();
            Assert.True(PersonalityTestPageService.IsMultipleSkillSelect);
        }

        [Test]

        public void MultipleSelectionOnGender()
        {
            DemoMainPageService.ClickOnDemo();
            Assert.True(PersonalityTestPageService.SelectMultipleGender() == 1);

        }

        [Test]

        public void MutipleSelectionOnFavFood() {
            DemoMainPageService.ClickOnDemo();
            Assert.True(PersonalityTestPageService.SelectMutipleFavFood() > 1);
        }

        [Test]

        public void IsZipCodeNumeric()
        {
            DemoMainPageService.ClickOnDemo();

            PersonalityTestPageService.SetZipCode("00977");
            Assert.True(PersonalityTestPageService.CheckNumericZip);
        }


    }
}
