using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Automation.PageServices
{
    class MainPageService
{   public static void clickOnMancCityTitle() {
        SiteDriver.Click(MainObject.cssMancity, "CSSSelector"); }


}
}
