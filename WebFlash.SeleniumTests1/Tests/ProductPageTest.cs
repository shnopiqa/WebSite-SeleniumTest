using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFlash.PageObject1.PageObject;
using WebFlash.PageObject1.WCPageObject;
using WebFlash.SeleniumTests1.StaticObjectsForTest;
using Xunit;

namespace WebFlash.SeleniumTests1.Tests
{
    public class ProductPageTest : IClassFixture<BaseTest>
    {
        private BaseTest _baseTest;
        private HomePageObject _homePage;
        private ProductPageObject _productPage;
        private CrtEddtDelPageObject _citEddtDelPage;
        public ProductPageTest(BaseTest baseTest)
        {
            _baseTest = baseTest;
            _homePage = new HomePageObject(_baseTest.driver);
            _productPage = new ProductPageObject(_baseTest.driver);
            _citEddtDelPage = new CrtEddtDelPageObject(_baseTest.driver);
        }
       

    }
}
