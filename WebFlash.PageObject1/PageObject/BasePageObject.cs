using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFlash.PageObject1.WCPageObject;
using OpenQA.Selenium.Support;

namespace WebFlash.PageObject1.PageObject
{
    public class BasePageObject 
    {
        public IWebDriver _driver;
        #region LOCATORS
      
        protected By HomePageButtonFromHeader => By.XPath("//a[text()='Home']");
        protected By ProductPageButtonFromHeader => By.XPath("//a[@href='/Product/ProductIndex']");
        protected By HeaderLogo => By.XPath("//a[@class='navbar-brand']");
        protected By HomeFutter => By.XPath("//footer[@class ='border-top footer text-muted bg-dark']/div[@class='container']");
        #endregion
        public BasePageObject(IWebDriver driver)
        {
            _driver = driver;

         
        }
        #region METHODS
        //Получение текстового заголовка кнопки Home 
        public string GetTextFromHomeButton() 
        {
            return _driver.FindElement(HomePageButtonFromHeader).Text;
        }

        //Получение текстового заголовка кнопки Product 
        public string GetTextFromProductButton()
        {
            return _driver.FindElement(ProductPageButtonFromHeader).Text;
        }
        //Получение текстового заголовка наименования Футтера 
        public string GetTextFromFutter()
        {
            return _driver.FindElement(HomeFutter).Text;
        }

        // Нажатие на лого сайта в Хедер для возврата на страницу Home 
        public void GoToHomePageByLogo() 
        {
            _driver.FindElement(HeaderLogo).Click();
        }

        // Переход на главную страницу через Хедер 
        public void GoToHomePageByHeaderButton()
        {
            _driver.FindElement(ProductPageButtonFromHeader).Click();
        }

        //Переход на страницу Продуктов через Хедер 
        public void GoToProductPageByHeaderButton()
        {
            _driver.FindElement(ProductPageButtonFromHeader).Click();
        }
        // Получить текст из футера сайта
        public string GetTextFromFooter() 
        {
           return _driver.FindElement(HomeFutter).Text;
        }
       
      
        #endregion
    }
}
