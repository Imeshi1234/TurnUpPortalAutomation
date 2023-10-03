using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TurnUpPortalAutomation.Pages;

public class Program
{
    private static void Main(string[] args)
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

        //TMpage page object initialization and definition
        TMPage tmPageObj = new TMPage();
        tmPageObj.CreateTimeRecord(driver);
       
    }
}
      /** public class Program
{
    private static void Main(string[] args)
    {
        //Open chrome browser
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();

        //Launch turnup portal and navigate to website login page
        driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login");

        //Identify username textbox and enter valid username
        IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
        usernameTextbox.SendKeys("hari");

        //Identify password textbox and enter valid password
        IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
        passwordTextbox.SendKeys("123123");


        //Identify login button and click on the button
        IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
        loginButton.Click();

        //Thread.Sleep(5000);//waiting for madatory 5 seconds


        //Check if the user has logged in successfully
        IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

        if (helloHari.Text == "Hello hari!")
        {
            Console.WriteLine("User has logged in successfully.");
        }
        else
        {
            Console.WriteLine("User hasn't logged in.");
        }
    }
}
      
//test case - create new time record

//Navigate to Time and Material module

//Click on the create new botton
//Select Time from the dropdown
// Enter code
// Enter Description
//Enter the price
//Click on the save button
//check if a new time record has been created successfully