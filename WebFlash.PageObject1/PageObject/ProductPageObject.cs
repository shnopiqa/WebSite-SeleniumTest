using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFlash.PageObject1.WCPageObject;

namespace WebFlash.PageObject1.PageObject
{
    public class ProductPageObject : BasePageObject
    {
        private IWebDriver _driver;
        #region LOCATORS 
        private By _productListTitle => By.XPath("//h1[text()='Products List']");
        private By _productTableHeader => By.XPath("//table[@data-test-id='product-table-id']//thead");
        private By _productTableBody => By.XPath("//table[@data-test-id='product-table-id']//tbody");
        private By _edditButtonForProductTable => By.XPath("//table[@data-test-id='product-table-id']//tbody//a[@class='btn btn-success']");
        private By _deleteButtonForProductTable => By.XPath("//table[@data-test-id='product-table-id']//tbody//a[@class='btn btn-danger']");
        private By _createProductButton => By.XPath("//a[@data-test-id='create-product-button']");
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
        public string GetProductPageTitleText() 
        {
            return _driver.FindElement(_productListTitle).Text;
        }
        // Получение заголовков таблицы продуктов
        public IEnumerable<IWebElement> GetpRroductTableHeaders() 
        {
            return _driver.FindElements(_productTableHeader).ToList();
        }
        // Получение всего списка продуктов из таблицы продуктов 
        public IEnumerable<IWebElement> GetProductTableBody()
        {
           return _driver.FindElements(_productTableBody).ToList();
        }
        //Открытие страницы редактирование продукта 
        public void GetEdditPage() 
        {
            _driver.FindElements(_edditButtonForProductTable).FirstOrDefault().Click();
        }
        // Открытие страницы удаления продукта 
        public void GetDeletePage() 
        {
            _driver.FindElements(_deleteButtonForProductTable).FirstOrDefault().Click();
        }
        // Переход на страницу создания продукта 
        public void GetCreateProductPage() 
        {
            _driver.FindElement(_createProductButton).Click();
        }
        #endregion
    }
}
