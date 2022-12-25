using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFlash.PageObject1.WCPageObject;

namespace WebFlash.PageObject1.PageObject
{
    public class ProductPageObject : BasePage
    {
        private IWebDriver _driver;
        #region LOCATORS 
        private By _productListTitle => By.XPath("//h1[text()='Products List']");
        private By _productTableHeader => By.XPath("//table[@data-test-id='product-table-id']//thead");
        private By _productTableBody => By.XPath("//table[@data-test-id='product-table-id']//tbody");
        private By _edditButtonForProductTable => By.XPath("//table[@data-test-id='product-table-id']//tbody//a[@class='btn btn-success']");
        private By _deleteButtonForProductTable => By.XPath("//table[@data-test-id='product-table-id']//tbody//a[@class='btn btn-danger']");
        #endregion
        public ProductPageObject(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }
        #region METHODS
        //Переход на страницу продуктов по ссылке
        public void GoToProductPageURL()
        {
            _driver.Navigate().GoToUrl(WCProductPage.URL);
        }
        //Получение заголовка страницы 
        public string GetProducPageTitleText() 
        {
            return _driver.FindElement(_productListTitle).Text;
        }
        // Получение заголовков таблицы продуктов
        public IEnumerable<IWebElement> GetpRrodyctTableHeaders() 
        {
            return _driver.FindElements(_productTableHeader).ToList();
        }
        // Получение всего списка продуктов из таблицы продуктов 
        public IEnumerable<IWebElement> GetProdyctTableBody()
        {
           return _driver.FindElements(_productTableBody).ToList();
        }
        //Получение страницы редактирование продукта 
        public void GetEdditPageFromProductPage() 
        {
            _driver.FindElements(_edditButtonForProductTable).FirstOrDefault().Click();
        }
        // Получение страницы удаления продукта 
        public void GetDeletePageFromProductPage() 
        {
            _driver.FindElements(_deleteButtonForProductTable).FirstOrDefault().Click();
        }
        #endregion
    }
}
