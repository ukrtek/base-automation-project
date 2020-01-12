using System;
using base_automation_project.utils;
using base_automation_project.utils.Models;
using base_automation_project.utils.WebDriverBuilder;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using Xunit;
using Xunit.Abstractions;

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
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
                

                Logger.Error("test msg");

        }
    }     
}