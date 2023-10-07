using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUpPortalAutomation.Pages;
using NUnit.Framework;
using TurnUpPortalAutomation.Utilities;

namespace TurnUpPortalAutomation.Test
{
    [TestFixture]
    public class TMTests : CommonDriver
    {

        [SetUp]
        public void SetUpTM()
        {
            driver = new ChromeDriver();

            //LoginPage object initialization and definition
            LoginPage loginPageobj = new LoginPage();
            loginPageobj.LoginActions(driver);

            //HomePage object initialization and definition
            HomePage homePageobj = new HomePage();
            homePageobj.GoToTMPage(driver);
            homePageobj.VerifyUserLogin(driver);
        }

        [Test, Order(1), Description(" This test creates a new time/Material record")]
        public void TestCreateTimeRecord()
        {
            //TMPage object initialization and definition
            TMPage tmPageobj = new TMPage();
            tmPageobj.CreateTimeRecord(driver);
        }

        [Test, Order(2), Description(" This test Updates a new time/Material record")]
        public void TestEditTimeRecord()
        {
            TMPage tmPageobj = new TMPage();
            tmPageobj.EditTimeRecord(driver);
        }

        [Test, Order(3), Description(" This test deletes a new time/Material record")]
        public void TestDeleteTimeRecord()
        {
            TMPage tmPageobj = new TMPage();
            tmPageobj.DeleteTimeRecord(driver);
        }

        [TearDown]
        public void CloseTestRun()
        {
            driver.Close();
        }


















    }
}
