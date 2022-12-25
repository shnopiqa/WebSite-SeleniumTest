using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using WebFlash.PageObject1.PageObject;
using WebFlash.SeleniumTests1.StaticObjectsForTest;
using Xunit;



namespace WebFlash.SeleniumTests1.Tests
{
    public class MainPageTest : IClassFixture<BaseTest>
    {
        private BaseTest _baseTest;
        private HomePageObject _homePage;
        private ProductPageObject _productPage;
        public MainPageTest(BaseTest baseTest) 
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
          _homePage.OpenHomePage();
            Assert.Equal(WCHomePage.ActualHeader, _homePage.GetHeaderHomePage());
            
        }
        // Пробный тест - удалить 
        [Fact]
        public void GoToProductPageFromHomePageTest()
        {
            _homePage.GoToHomePageUrl();
            

        }

        [Fact]
        public void GoToEdditPageFromProductPageTest() 
        {
            _homePage.GoToHomePageUrl();
            _homePage.GetProductPageFromHomePage();
            _productPage.GetEdditPageFromProductPage();
        }

    }
}