using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace WebFlash.PageObject1.PageObject
{
    public class HomePageObject
    {
        
        public IWebDriver _driver;
        #region XPathElements 
        private By _xPathToHomePage => By.XPath("//a[text()='Home']");
        private By _homeHeaderText => By.XPath("//h1[text() = 'Welcome']");
        private By _productButton => By.XPath("//a[@href='/Product/ProductIndex']");
        private By _homeFotterText => By.XPath("");
        #endregion
        public HomePageObject(IWebDriver driver) 
        {
            _driver = driver;
        }
        //Переход к главной странцие по ссылке 
        public void GoToHomePageUrl() 
        {
            _driver.Navigate().GoToUrl("https://localhost:7082/");
        }
        //Переход к главной странице через хедер сайта 
        public void OpenHomePage() 
        {
            _driver.FindElement(_xPathToHomePage).Click();
        }
        //Получение заголовка на странице Home 
        public string GetHeaderHomePage() 
        {
           return _driver.FindElement(_homeHeaderText).Text;
        }
        //Получение текстовой версии наименования футтера 
        public string GetFutterHomePage()
        {
            return _driver.FindElement(_homeFotterText).Text;
        }
        // Переход с главной страницы на страницу продуктов 
        public ProductPageObject GetProductPageFromHomePage()
        {
            _driver.FindElement(_productButton).Click();
            return new ProductPageObject(_driver);
        }

    }
}
