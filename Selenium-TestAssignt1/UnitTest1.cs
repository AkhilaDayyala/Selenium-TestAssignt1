using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_TestAssignt1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Console.WriteLine("Testing start");
            IWebDriver driver = new ChromeDriver(@"C:\Users\91789\Downloads\chromedriver-win64\chromedriver-win64");

            driver.Navigate().GoToUrl("https://www.facebook.com/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
            IWebElement ele1 = driver.FindElement(By.Id("email"));
            ele1.SendKeys("akhila@gmail.com");
            Thread.Sleep(1000);
            IWebElement ele2 = driver.FindElement(By.Id("pass"));
            ele2.SendKeys("akhila@123");
            Thread.Sleep(1000);
            IWebElement ele3 = driver.FindElement(By.Name("login"));
            ele3.Click();
            Thread.Sleep(1000);
            Console.WriteLine("Testing ended");
            driver.Close();

        }
    }
}