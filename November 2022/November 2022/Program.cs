using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

// open chrome browser
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

// launch turnup portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

// identify username textbox and enter valid username
IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");

// identify password textbox and enter valid password
IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");

// click login button
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
loginButton.Click();

// check if user has logged in successfully
IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

if(helloHari.Text == "Hello hari!")
{
    Console.Write("Logged in successfully, test passed.");    
}
else
{
    Console.Write("Login failed, test failed.");
}