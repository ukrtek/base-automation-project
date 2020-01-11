using System;
using base_automation_project.utils;
using base_automation_project.utils.Models;
using base_automation_project.utils.WebDriverBuilder;
using OpenQA.Selenium.Remote;
using Serilog;

//https://xunit.net/docs/shared-context for reference

namespace base_automation_project.tests
{
    public class TestFixture : IDisposable
    {
        public RemoteWebDriver Driver;
        public ILogger Logger;

        public TestFixture()
        {
            var driverOption = ConfigProvider.GetFromSection<DriverOption>("driverOption");
            Driver = WebDriverBuilder.BuildDriver(driverOption);
            Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File("logs/log.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();
        }

        public void Dispose()
        {
            Driver.Quit();
            Driver?.Dispose();                
        }
    }

}