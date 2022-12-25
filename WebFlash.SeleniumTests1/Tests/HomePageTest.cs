using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using WebFlash.PageObject1.PageObject;
using WebFlash.SeleniumTests1.StaticObjectsForTest;
using Xunit;



namespace WebFlash.SeleniumTests1.Tests
{
    public class HomePageTest : IClassFixture<BaseTest>
    {
        private BaseTest _baseTest;
        private HomePageObject _homePage;
        public HomePageTest(BaseTest baseTest) 
        {
            _baseTest = baseTest;
            _homePage = new HomePageObject(_baseTest.driver);
        }
        //Проверка отображения заголовка на главной странице 
        [Fact]
        public void GoToHomePageTest() 
        {
           _homePage.GoToHomePageUrl();
            Assert.Equal(WCHomePage.ActualHeader, _homePage.GetHeaderHomePage());   
        }
      
        
       

    }
}