using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFlash.PageObject1.PageObject
{
    public class ProductPageObject
    {
        private IWebDriver _driver;
        private By _productListTitle => By.XPath("//h1[text()='Products List']");
        private By _productTableHeader => By.XPath("//table[@data-test-id='product-table-id']//thead");
        private By _productTableBody => By.XPath("//table[@data-test-id='product-table-id']//tbody");
        private By _edditButtonForProductTable => By.XPath("//table[@data-test-id='product-table-id']//tbody//a[@class='btn btn-success']");
        public ProductPageObject(IWebDriver driver)
        {
            _driver = driver;
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
        //Получение страницы редактирование продукта со страницы продукта
        public void GetEdditPageFromProductPage() 
        {
            _driver.FindElements(_edditButtonForProductTable).FirstOrDefault().Click();
        }

    }
}
