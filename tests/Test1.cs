using System;
using base_automation_project.utils;
using base_automation_project.utils.Models;
using base_automation_project.utils.WebDriverBuilder;
using OpenQA.Selenium.Remote;
using Xunit;

namespace base_automation_project.tests
{
    public class Test1 : BaseTest
    {
        public Test1(TestFixture fixture) : base(fixture)
        {
        }

        // do the checks here
        //todo

        [Fact]
        public void DemoTest()
        {
            var testComplete = false;
            Driver.Navigate().GoToUrl();
            Driver.Navigate().GoToUrl(ConfigProvider.GetFromSection<DriverOption>("AyfiDev)")/*ConfigProvider.GetFromSection<DriverOption>("AyfiDev")*/);
            var alert = Driver.SwitchTo().Alert();
            alert.SetAuthenticationCredentials("user", "testuser");
            alert.Accept();
            testComplete = true;
            Assert.True(testComplete);

        }
    }     
}