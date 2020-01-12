using base_automation_project.Pages;
using base_automation_project.utils;
using OpenQA.Selenium.Remote;
using Serilog;
using Xunit;
using Xunit.Abstractions;

namespace base_automation_project.tests
{
    public class BaseTest : IClassFixture<TestFixture>
    {
        protected RemoteWebDriver Driver;
        protected ILogger Logger;
        
        protected HomePage HomePage;
        protected AboutPage AboutPage;
        protected BlogsPage BlogsPage;
        protected ContactPage ContactPage;

        //todo - where should the object be created??
        public BaseTest(TestFixture fixture)
        { 
            Driver = fixture.Driver;
            Logger = fixture.Logger;
            HomePage = new HomePage(Driver);
            AboutPage = new AboutPage(Driver);
            BlogsPage = new BlogsPage(Driver);
            ContactPage = new ContactPage(Driver);
        }
    }
}