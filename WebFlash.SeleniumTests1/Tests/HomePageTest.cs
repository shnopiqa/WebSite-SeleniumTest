using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using WebFlash.PageObject1.PageObject;
using WebFlash.SeleniumTests1.StaticObjectsForTest;
using Xunit;



namespace WebFlash.SeleniumTests1.Tests
{
    public class HomePageTest : BaseTest, IClassFixture<BaseTest>
    {

        public HomePageTest(BaseTest baseTest) 
        {
        
        }
        //Проверка отображения заголовка на главной странице 
        [Fact]
        public void GoToHomePageTest() 
        {
           homePage.GoToHomePageUrl();
            Assert.Equal(WCHomePage.ExpectedHeader, homePage.GetHeaderHomePage());   
        }
        // Проверка заголовка страницы продуктов при преходе из главной страницы
        [Fact]
        public void ChekProductPageTitleFromHomePage()
        {
            homePage.GoToHomePageUrl();
            homePage.GoToProductPageByHeaderButton();
            var ActualHeader = productPage.GetProductPageTitleText();
            Assert.Equal(WCProductPage.ExpectedHeader, ActualHeader);
       
        }
        // Проверка заголовка футера на главной странице 
        [Fact]
        public void GetFooterTitleFromHomePage()
        {
            homePage.GoToHomePageUrl();
            var ActualHeader = productPage.GetTextFromFooter();
            Assert.Equal(WCHomePage.ExpectedFutterText, ActualHeader.Trim());

        }






    }
}