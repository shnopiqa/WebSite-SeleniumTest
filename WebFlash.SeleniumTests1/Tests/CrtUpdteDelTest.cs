using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFlash.PageObject1.PageObject;
using WebFlash.PageObject1.WCPageObject;
using Xunit;

namespace WebFlash.SeleniumTests1.Tests
{
    public class CrtUpdteDelTest : IClassFixture<BaseTest>
    {
        private BaseTest _baseTest;
        private HomePageObject _homePage;
        private ProductPageObject _productPage;
        private CrtEddtDelPageObject _crtEddtDelPage;
        public CrtUpdteDelTest(BaseTest baseTest)
        {
            _baseTest = baseTest;
            _homePage = new HomePageObject(_baseTest.driver);
            _productPage = new ProductPageObject(_baseTest.driver);
            _crtEddtDelPage = new CrtEddtDelPageObject(_baseTest.driver);
        }

        // Проверка на наличие заголовка в поле имя на странице редактирования 
        [Fact]
        public void NameFieldValueTestOnEdditPageTest()
        {
            _productPage.GoToProductPageURL();
            _productPage.GetFirstEdditPage();
            Dictionary<string, string> fieldsTitleDict = _crtEddtDelPage.GetDictionaryTitleOfFields();
            string NameTitle = _crtEddtDelPage.GetDictionaryTitleValue(fieldsTitleDict, FieldTitleForCrtEddtDelPage.Name);
            Assert.NotNull(NameTitle);
        }
        // Проверка на наличие заголовка в поле категория на странице редактирования 
        [Fact]
        public void CategoryFieldValueTestOnEdditPageTest()
        {
            _productPage.GoToProductPageURL();
            _productPage.GetFirstEdditPage();
            Dictionary<string, string> fieldsTitleDict = _crtEddtDelPage.GetDictionaryTitleOfFields();
            string CategoryTitle = _crtEddtDelPage.GetDictionaryTitleValue(fieldsTitleDict, FieldTitleForCrtEddtDelPage.CategoryName);
            Assert.NotNull(CategoryTitle);
        }
        // Проверка на наличие заголовка в поле описание на странице редактирования 
        [Fact]
        public void DescriptionFieldValueTestOnEdditPageTest()
        {
            _productPage.GoToProductPageURL();
            _productPage.GetFirstEdditPage();
            Dictionary<string, string> fieldsTitleDict = _crtEddtDelPage.GetDictionaryTitleOfFields();
            string DescriptionTitle = _crtEddtDelPage.GetDictionaryTitleValue(fieldsTitleDict, FieldTitleForCrtEddtDelPage.Description);
            Assert.NotNull(DescriptionTitle);
        }
        // Проверка на наличие заголовка в поле цена на странице редактирования 
        [Fact]
        public void PriceFieldValueTestOnEdditPageTest()
        {
            _productPage.GoToProductPageURL();
            _productPage.GetFirstEdditPage();
            Dictionary<string, string> fieldsTitleDict = _crtEddtDelPage.GetDictionaryTitleOfFields();
            string PriceTitle = _crtEddtDelPage.GetDictionaryTitleValue(fieldsTitleDict, FieldTitleForCrtEddtDelPage.Description);
            Assert.NotNull(PriceTitle);
        }

    }
}
