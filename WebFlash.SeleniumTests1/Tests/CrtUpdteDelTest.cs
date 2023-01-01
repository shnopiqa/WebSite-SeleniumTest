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
    public class CrtUpdteDelTest :BaseTest, IClassFixture<BaseTest>
    {
       
        public CrtUpdteDelTest(BaseTest baseTest)
        {
          
        }

        // Проверка на наличие заголовка в поле имя на странице редактирования 
        [Fact]
        public void NameFieldValueTestOnEdditPageTest()
        {
            productPage.GoToProductPageURL();
            productPage.GetFirstEdditPage();
            Dictionary<string, string> fieldsTitleDict = crtEddtDel.GetDictionaryTitleOfFields();
            string NameTitle = crtEddtDel.GetDictionaryTitleValue(fieldsTitleDict, FieldTitleForCrtEddtDelPage.Name);
            Assert.NotNull(NameTitle);
        }
        // Проверка на наличие заголовка в поле категория на странице редактирования 
        [Fact]
        public void CategoryFieldValueTestOnEdditPageTest()
        {
            productPage.GoToProductPageURL();
            productPage.GetFirstEdditPage();
            Dictionary<string, string> fieldsTitleDict = crtEddtDel.GetDictionaryTitleOfFields();
            string CategoryTitle = crtEddtDel.GetDictionaryTitleValue(fieldsTitleDict, FieldTitleForCrtEddtDelPage.CategoryName);
            Assert.NotNull(CategoryTitle);
        }
        // Проверка на наличие заголовка в поле описание на странице редактирования 
        [Fact]
        public void DescriptionFieldValueTestOnEdditPageTest()
        {
            productPage.GoToProductPageURL();
            productPage.GetFirstEdditPage();
            Dictionary<string, string> fieldsTitleDict = crtEddtDel.GetDictionaryTitleOfFields();
            string DescriptionTitle = crtEddtDel.GetDictionaryTitleValue(fieldsTitleDict, FieldTitleForCrtEddtDelPage.Description);
            Assert.NotNull(DescriptionTitle);
        }
        // Проверка на наличие заголовка в поле цена на странице редактирования 
        [Fact]
        public void PriceFieldValueTestOnEdditPageTest()
        {
            productPage.GoToProductPageURL();
            productPage.GetFirstEdditPage();
            Dictionary<string, string> fieldsTitleDict = crtEddtDel.GetDictionaryTitleOfFields();
            string PriceTitle = crtEddtDel.GetDictionaryTitleValue(fieldsTitleDict, FieldTitleForCrtEddtDelPage.Description);
            Assert.NotNull(PriceTitle);
        }

    }
}
