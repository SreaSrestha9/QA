using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SiteDriverHandler;
using OpenQA.Selenium.Chrome;

namespace DemoPage
{
    [TestFixture]
    class TestBase
    {
        [SetUp]
        public void SetUp()
        {
            ChromeOptions option = new ChromeOptions();
            new SiteDriver(new ChromeDriver(option) { Url = "https://wingskushma.github.io/pages/index.html" });
        }

        [TearDown]
        public void CleanUp()
        { SiteDriver.closeDriver(); }
    }
}
