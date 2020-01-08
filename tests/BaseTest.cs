using base_automation_project.Pages;
using base_automation_project.utils;
using OpenQA.Selenium.Remote;
using Xunit;

namespace base_automation_project.tests
{
    public class BaseTest : IClassFixture<TestFixture>
    {
        
        protected RemoteWebDriver Driver;
        //todo:add logger
        protected ConfigProvider ConfigProvider;
        
        protected HomePage HomePage;
        protected AboutPage AboutPage;
        protected BlogsPage BlogsPage;
        protected ContactPage ContactPage;

        //todo - where should the object be created??
        public BaseTest(TestFixture fixture)
        {
            this.Driver = fixture.Driver;
            //todo - init logger
            ConfigProvider = new ConfigProvider();
            HomePage = new HomePage(Driver);
            AboutPage = new AboutPage(Driver);
            BlogsPage = new BlogsPage(Driver);
            ContactPage = new ContactPage(Driver);
        }
    }
}