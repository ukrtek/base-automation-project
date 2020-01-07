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
        public RemoteWebDriver Driver;
        public TestFixture()
        {
            var driverOption = ConfigProvider.GetFromSection<DriverOption>("driverOption");
            Driver = WebDriverBuilder.BuildDriver(driverOption);
            
            //todo
            //init logger
        }

        public void Dispose()
        {
            Driver.Quit();
            Driver?.Dispose();                
        }
    }
}