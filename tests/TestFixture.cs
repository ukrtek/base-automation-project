using System;
using base_automation_project.utils;
using base_automation_project.utils.Models;
using base_automation_project.utils.WebDriverBuilder;
using OpenQA.Selenium.Remote;

//https://xunit.net/docs/shared-context for reference

namespace base_automation_project.tests
{
    public class TestFixture : IDisposable
    {
        public RemoteWebDriver WebDriver;
        public TestFixture()
        {
            var driverOption = ConfigProvider.GetFromSection<DriverOption>("driverOption");
            WebDriver = WebDriverBuilder.BuildDriver(driverOption);
            WebDriver.Manage().Window.Maximize(); 
            
            //todo
            //init logger
        }

        public void Dispose()
        {
            WebDriver.Quit();
            WebDriver?.Dispose();                
        }
    }
}