using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUpPortalAutomation.Pages;
using NUnit.Framework;
/**
namespace TurnUpPortalAutomation.Test
{
    public class TMTest
    {
        [SetUp]
        public void SetUpTM()
        {
            //Open chrome browser
            IWebDriver driver = new ChromeDriver();
            //Loginpage page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);

            //Homepage page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.VerifySucssesLogin(driver);
            homePageObj.GoToTMPage(driver);

        }
        [Test]
        public void TestCreateTimeRecord()
        {
           
        }
        [Test]
        public void TestEditTimeRecord()
        {
        }
        [Test]
        public void TestDeleteTimeRecord()
        {
            tmPageObj.DeleteTimeRecord(driver);

        }
        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }






















        
        

        //TMpage page object initialization and definition
        TMPage tmPageObj = new TMPage();
        tmPageObj.CreateTimeRecord(driver);
        tmPageObj.EditTimeRecord(driver);
        
    }
}
*/