using OpenQA.Selenium;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFlash.PageObject1.WCPageObject;

namespace WebFlash.PageObject1.PageObject
{
    public class CrtEddtDelPageObject : BasePageObject
    {
        private IWebDriver _driver;
        #region LOCATORS
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
        private By _updateButton => By.XPath("//input[@value='Update']");
        private By _deleteButton => By.XPath("//input[@value='Delete']");
        #endregion
        public CrtEddtDelPageObject(IWebDriver driver) : base(driver)
        {
            _driver = driver;
           
        }
        #region METHODS
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
        // Нажатие на кнопку подтверждения создания продукта 
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
        public Dictionary<string, string> GetDictionaryTitleOfFields() 
        {
            Dictionary<string, string> textTitleDic = new Dictionary<string, string>()
            {
                {FieldTitleForCrtEddtDelPage.Name.ToString(), _driver.FindElement(_nameFieldTitle).Text},
                {FieldTitleForCrtEddtDelPage.CategoryName.ToString(), _driver.FindElement(_categoryFieldTitle).Text},
                {FieldTitleForCrtEddtDelPage.Description.ToString(), _driver.FindElement(_descriptionFieldTitle).Text},
                {FieldTitleForCrtEddtDelPage.Price.ToString(), _driver.FindElement(_priceFieldTitle).Text}

            };
            return textTitleDic;
        }
        // Получение значения из словаря по ключу 
        public string GetDictionaryTitleValue(Dictionary<string, string> dict, FieldTitleForCrtEddtDelPage key)
        {
            string value = dict.FirstOrDefault(x => x.Value == key.ToString()).Value;
            return value;
        }
        // Очистить поле на странице редактирования страницы 
        public void ClearField(FieldTitleForCrtEddtDelPage title) 
        {
            switch (title) 
            {
                case FieldTitleForCrtEddtDelPage.Name:
                    _driver.FindElement(_nameField).Clear();
                    break;
                case FieldTitleForCrtEddtDelPage.CategoryName:
                    _driver.FindElement(_categoryField).Clear();
                    break;
                case FieldTitleForCrtEddtDelPage.Description:
                    _driver.FindElement(_descriptionTextArea).Clear();
                    break;
                case FieldTitleForCrtEddtDelPage.Price:
                    _driver.FindElement(_priceField).Clear();
                    break;
            }

        }
        // Нажатие на кнопку подтверждения редактирования продукта 
        public void UpdateButtonClick() 
        {
            _driver.FindElement(_updateButton);
        }
        // Нажатие на кнопку подтверждения удаления продукта 
        public void DeleteButtonClick()
        {
            _driver.FindElement(_deleteButton);
        }

        #endregion
    }


}
