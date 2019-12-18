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

        //todo
        // do the checks here

        [Fact]
        public void OpenHomePage()
        {
            WebDriver.Navigate().GoToUrl("http://google.com/");
        }
        
        


    }     
}