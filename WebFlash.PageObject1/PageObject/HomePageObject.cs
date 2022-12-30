using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFlash.PageObject1.WCPageObject;
using Xunit;

namespace WebFlash.PageObject1.PageObject
{
    public class HomePageObject : BasePageObject
    {
        
        public IWebDriver _driver;

        #region LOCATORS
        private By _homeHeaderText => By.XPath("//h1[text() = 'Welcome']");
        #endregion
        public HomePageObject(IWebDriver driver) : base(driver)
        {
            _driver = driver;

        }
        #region METHODS
        //Переход к главной странцие по ссылке 
        public void GoToHomePageUrl()
        {
            _driver.Navigate().GoToUrl(WCHomePageObject.URL);
        }
        //Получение заголовка на странице Home 
        public string GetHeaderHomePage() 
        {
           return _driver.FindElement(_homeHeaderText).Text;
        }
        #endregion


    }
}
