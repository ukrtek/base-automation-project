using base_automation_project.Pages;
using OpenQA.Selenium.Remote;
using Xunit;

namespace base_automation_project.tests
{
    public class BaseTest : IClassFixture<TestFixture>
    {
        
        protected RemoteWebDriver Driver;
        //todo:add logger
        
        protected HomePage HomePage;
        protected AboutPage AboutPage;
        protected BlogsPage BlogsPage;
        protected ContactPage ContactPage;

        //todo - where should the object be created??
        public BaseTest(TestFixture fixture)
        {
            this.Driver = fixture.Driver;
            HomePage = new HomePage();
            AboutPage = new AboutPage();
            BlogsPage = new BlogsPage();
            ContactPage = new ContactPage();
        }
    }
}