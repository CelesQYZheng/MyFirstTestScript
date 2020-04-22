using System;
using Xunit;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace MyFirstTestScript
{
    public class MyFirstTest
    {
        [Fact]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");

        }
        
    }
}
