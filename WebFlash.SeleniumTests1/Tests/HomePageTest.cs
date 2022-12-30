using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using WebFlash.PageObject1.PageObject;
using WebFlash.SeleniumTests1.StaticObjectsForTest;
using Xunit;



namespace WebFlash.SeleniumTests1.Tests
{
    public class HomePageTest : IClassFixture<BaseTest>
    {
        private BaseTest _baseTest;
        private HomePageObject _homePage;
        private ProductPageObject _productPage;
        public HomePageTest(BaseTest baseTest) 
        {
            _baseTest = baseTest;
            _homePage = new HomePageObject(_baseTest.driver);
            _productPage = new ProductPageObject(_baseTest.driver); 
        }
        //Проверка отображения заголовка на главной странице 
        [Fact]
        public void GoToHomePageTest() 
        {
           _homePage.GoToHomePageUrl();
            Assert.Equal(WCHomePage.ExpectedHeader, _homePage.GetHeaderHomePage());   
        }
        // Проверка заголовка страницы продуктов при преходе из главной страницы
        [Fact]
        public void ChekProductPageTitleFromHomePage()
        {
            _homePage.GoToHomePageUrl();
            _homePage.GoToProductPageByHeaderButton();
            var ActualHeader = _productPage.GetProductPageTitleText();
            Assert.Equal(WCProductPage.ExpectedHeader, ActualHeader);
       
        }
        // Проверка заголовка футера на главной странице 
        [Fact]
        public void GetFooterTitleFromHomePage()
        {
            _homePage.GoToHomePageUrl();
            var ActualHeader = _productPage.GetTextFromFooter();
            Assert.Equal(WCHomePage.ExpectedFutterText, ActualHeader.Trim());

        }






    }
}