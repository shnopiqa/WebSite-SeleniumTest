using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFlash.PageObject1.WCPageObject;

namespace WebFlash.PageObject1.PageObject
{
    public class BasePage 
    {
        public IWebDriver _driver;
        #region LOCATORS
        public By HomePageButtonFromHeader => By.XPath("//a[text()='Home']");
        public By ProductPageButtonFromHeader => By.XPath("//a[@href='/Product/ProductIndex']");
        public By HeaderLogo => By.XPath("//a[@class='navbar-brand']");
        public  By HomeFutter => By.XPath("");
        #endregion
        public BasePage(IWebDriver driver)
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
        //Получение текстового заголовка наименования футтера 
        public string GetTextFromFutter()
        {
            return _driver.FindElement(HomeFutter).Text;
        }

        // Нажатие на лого сайта в Хедер для возврата на страницу Home 
        public void GoToHomePageByLogo() 
        {
            _driver.FindElement(HeaderLogo).Click();
        }

        // Переход на главную страницу в Хедер 
        public void GoToHomePageByHeaderButton()
        {
            _driver.FindElement(ProductPageButtonFromHeader).Click();
        }

        //Переход на страницу Продуктов 
        public void GoToProductPageByHeaderButton()
        {
            _driver.FindElement(ProductPageButtonFromHeader).Click();
        }
        #endregion
    }
}
