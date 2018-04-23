using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Automation.PageOjects;
using OpenQA.Selenium.Interactions;
using SiteDriverHandler;

namespace Automation.PageServices
{
    public class ManCityService
{       
        static List<String> lst = new List<string>() { "1. Manchester City:", "2. Manchester United:", "3. Arsenal", "Liverpool:" , "8. Chelsea" };
        static List<String> lst1 = new List<string>() { "Facebook" , "Twitter", "Google plus", "Linkedin", "Pinterest", "Whatsapp", "More" };
      

       public static bool CheckOrder1() {
           // SiteDriver.MoveToElement(SiteDriver.FindElements(ManCityObject.elementList1, "CSSSelector"));
            List<IWebElement> listElements1 = SiteDriver.FindElements(ManCityObject.elementList1, "CSSSelector");
            List<string> listTitle = new List<string>();
            foreach(IWebElement e in listElements1)
            {
                listTitle.Add(e.GetAttribute("title"));
            }
            return SiteDriver._IsOrdered(listTitle, lst1);
        }

        public static bool CheckOrder()
        {
            List<IWebElement> listElements = SiteDriver.FindElements(ManCityObject.elementList, "CSSSelector");
            List<string> listTitle = new List<string>();
            foreach (IWebElement e in listElements)
            {
                listTitle.Add(e.Text);
            }
            return SiteDriver._IsOrdered(listTitle, lst);;
        }
        /*
       
        private static bool _IsOrdered(IList<IWebElement> list, IList<string> comparer)
        {
            if (list.Count > 1) {
                for (int i = 1; i < list.Count;i++)
                {
                    if (list[i].Text != comparer[i].ToString())
                    { return false; } } }
            return true;
        }
        private static bool _IsOrdered(IList<string> list, IList<string> comparer)
        {
            if (list.Count > 1)
            {
                for (int i = 1; i < list.Count; i++)
                {
                    if (list[i].ToString() != comparer[i].ToString())
                    { Console.WriteLine(list[i].ToString() + "<>" + comparer[i].ToString() );
                        return false; }
                }
            }
            return true;
        }*/
        /*
                public static bool Tooltip(IList<IWebElement> list, IList<string> comparer) 
                {


                    // List<IWebElement> listElements1 = SiteDriver.FindElement(ManCity.elementList1, "CSSSelector").ToList();
                    if (list.Count > 1) {
                        for (int i = 1; i < list.Count; i++) {
                            hoverClickAndHold(list[i].Text).Perform();
                            hover.MoveToElement(list[i].Text).Perform();// Perform mouse hover action using 'clickAndHold' method
                          //  String ToolTipText = googleLogo.getAttribute("title"); // Get the value of Tooltip by getAttribute command
                           // Assert.assertEquals(listElements1, "Google");
                             } }
            }*/

        public static void setAuthor(string strAuthor) {
        SiteDriver.SendKeys(ManCityObject.css_txtAuthor, "CSSSelector", strAuthor);
    }
    public static void setEmailID(string strEmailID)
    {
        SiteDriver.SendKeys(ManCityObject.css_txtEmail, "CSSSelector", strEmailID);
    }
    public static void setURL(string strURL)
    {
        SiteDriver.SendKeys(ManCityObject.css_txtUrl, "CSSSelector", strURL);
    }
    public static void setComment(string strComment)
    {
        SiteDriver.SendKeys(ManCityObject.css_txtComment, "CSSSelector", strComment);
    }

    public static void clicksubmit()
    {
        SiteDriver.Click(ManCityObject.css_btnSubmit, "CSSSelector");
    }
} }
