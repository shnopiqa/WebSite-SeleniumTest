using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFlash.PageObject1.PageObject;
using WebFlash.SeleniumTests1.Common;
using Xunit;

namespace WebFlash.SeleniumTests1.Tests
{
    public class BaseTest : IDisposable
    {
        protected IWebDriver driver;
        protected CrtEddtDelPageObject crtEddtDel;
        protected HomePageObject homePage;
        protected ProductPageObject productPage;
        
        public BaseTest()
        {
            driver = CommonActions.CreateDriver();
            crtEddtDel = new CrtEddtDelPageObject(driver);
            homePage = new HomePageObject(driver);
            productPage = new ProductPageObject(driver);
        }
        public void Dispose()
        {
            driver.Dispose();
            driver.Quit();
        }

    }
}
