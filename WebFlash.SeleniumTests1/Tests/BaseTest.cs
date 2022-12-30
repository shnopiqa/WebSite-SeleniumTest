using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;

namespace WebFlash.SeleniumTests1.Tests
{
    public class BaseTest : IDisposable
    {
        public IWebDriver driver;
        public BaseTest()
        {
            driver = new ChromeDriver();
           
            driver.Manage().Window.Maximize();

        }
        public void Dispose()
        {
            driver.Dispose();
            driver.Quit();
        }

    }
}
