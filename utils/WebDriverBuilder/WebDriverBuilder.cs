using System;
using base_automation_project.utils.Models;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Safari;

namespace base_automation_project.utils.WebDriverBuilder
{
    public class WebDriverBuilder
    {
        private static RemoteWebDriver GetChromeDriver(DriverOption option)
                 {
                     var chromeOptions = new ChromeOptions();
                     chromeOptions.AddAdditionalCapability("useAutomationExtension", false);
                     chromeOptions.AddArgument("no-sandbox");
                     chromeOptions.AddArguments("start-maximized");
         			
                     var driver = new ChromeDriver(option.DriverPath, chromeOptions);
         
                     driver.Navigate().GoToUrl(option.StartUrl);
         		
                     driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(option.TimeOutPageLoad);
                     driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(option.TimeOutImplicitWait);
         
                     return driver;
                 }
        
        private static RemoteWebDriver GetSafariDriver(DriverOption option)
        {
            var safariOptions = new SafariOptions();
            safariOptions.AddAdditionalCapability("useAutomationExtension", false);
            //safariOptions.AddArguments("no-sandbox");
            //safariOptions.AddArguments("start-maximized");
         			
            var driver = new SafariDriver(option.DriverPath, safariOptions);
         
            driver.Navigate().GoToUrl(option.StartUrl);
         		
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(option.TimeOutPageLoad);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(option.TimeOutImplicitWait);
         
            return driver;
        }
        
        public static RemoteWebDriver BuildDriver(DriverOption option)
        {
            switch (option.Browser)
            {
                case Browsers.Chrome:
                    return GetChromeDriver(option);

                case Browsers.Safari:
                    return GetSafariDriver(option);

                default:
                    throw new Exception("Driver is not supported");
            }
        }
    }
}