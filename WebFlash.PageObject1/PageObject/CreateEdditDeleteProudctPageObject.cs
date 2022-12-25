using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFlash.PageObject1.WCPageObject;

namespace WebFlash.PageObject1.PageObject
{
    public class CreateEdditDeleteProudctPageObject : BasePageObject
    {
        private IWebDriver _driver;
        private By _createProductPageTitle => By.XPath("//h1[@class='text-info']");
        private By _nameField => By.XPath("//input[@id='Name']");
        private By _categoryField => By.XPath("//input[@id='CategoryName']");
        private By _descriptionTextArea=> By.XPath("//textarea[@id='Description']");
        private By _priceField => By.XPath("//input[@id='Price']");
        private By _createButton => By.XPath("//input[@value='Create']");
        private By _backToListButton => By.XPath("//a[@class='btn-primary btn form-control ']");
        private By _nameFieldTitle => By.XPath("//label[@for='Name']");
        private By _categoryFieldTitle => By.XPath("//label[@for='CategoryName']");
        private By _descriptionFieldTitle => By.XPath("//label[@for='Description']");
        private By _priceFieldTitle => By.XPath("//label[@for='Price']");
        public CreateEdditDeleteProudctPageObject(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }
        // Перейти на страницу создания продукта по ссылке 
        public void GetUrlCreateProductPage() 
        {
            _driver.Navigate().GoToUrl(WCCreateEdditDeleteProductPageObject.URL);
        }
        // Получение текста заголовка создания продукта 
        public string GetProductPageTitle() 
        {
            return _driver.FindElement(_createProductPageTitle).Text;
        }
        // Заполнение формы создания продукта 
        public void EntryProductCreateFields(string? name, string? categoryName, string? description, int? price) 
        {
            _driver.FindElement(_nameField).SendKeys(name);
            _driver.FindElement(_categoryField).SendKeys(categoryName);
            _driver.FindElement(_descriptionTextArea).SendKeys(description);
            _driver.FindElement(_priceField).SendKeys($"{price}");
        }
        // Нажатие на кнопку создания продукта 
        public void CreateProductButtonClick() 
        {
            _driver.FindElement(_createButton).Click();
        }
        // Нажатие на кнопку возврата к странице со списком продуктов 
        public void BackToProductPageClick() 
        {
            _driver.FindElement(_backToListButton).Click();
        }
        // Получение словаря со списком заголовков полей 
        public Dictionary<string, string> GetTextTitleOfFields() 
        {
            Dictionary<string, string> textTitleDic = new Dictionary<string, string>()
            {
                {TitleEnumForCreateEdditDeletePage.Name.ToString(), _driver.FindElement(_nameFieldTitle).Text},
                {TitleEnumForCreateEdditDeletePage.CategoryName.ToString(), _driver.FindElement(_categoryFieldTitle).Text},
                {TitleEnumForCreateEdditDeletePage.Description.ToString(), _driver.FindElement(_descriptionFieldTitle).Text},
                {TitleEnumForCreateEdditDeletePage.Price.ToString(), _driver.FindElement(_priceFieldTitle).Text}

            };
            return textTitleDic;
        }
        // Получение значения из словаря по ключу 
        public string GetDictionaryTitleValue(Dictionary<string, string> dict, string key)
        {
            string value = dict[key];
            return value;
        }
    }

    
}
