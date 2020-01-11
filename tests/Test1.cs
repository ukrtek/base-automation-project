using System;
using base_automation_project.utils;
using base_automation_project.utils.Models;
using base_automation_project.utils.WebDriverBuilder;
using OpenQA.Selenium.Remote;
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
            Logger.Error("test msg");
        }
    }     
}