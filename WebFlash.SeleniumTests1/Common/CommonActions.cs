using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFlash.SeleniumTests1.Common
{
    public  class CommonActions 
    {
        private static IWebDriver driver;
        private  CommonActions() 
        {

        }
        public static IWebDriver CreateDriver()
        {
            if (driver == null)
            {
                driver = new ChromeDriver();

                driver.Manage().Window.Maximize();
            }
            return driver;
        }

      
    }
}
