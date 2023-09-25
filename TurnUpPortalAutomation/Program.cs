using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//open chrome browser

IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

//Lanuch turnup portal and navigate to website login page
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login");

//Identify username textbox and enter valid username
IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");

//Identify password textbox and enter valid username
IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");

//Identify login button and click on the button
IWebElement LoggingButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
LoggingButton.Click();

//Check the user has logged in succesfully
IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

if (helloHari.Text == "Hello Hari")
{
    Console.WriteLine("USer has logged in successfully");
}
else
{
    Console.WriteLine("User hasn't logged in");
}

//