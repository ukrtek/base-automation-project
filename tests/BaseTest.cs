using OpenQA.Selenium.Remote;
using Xunit;

namespace base_automation_project.tests
{
    public class BaseTest : IClassFixture<TestFixture>
    {
        private readonly TestFixture _fixture;
        protected RemoteWebDriver WebDriver;
        
        //todo - where should the object be created??
        public BaseTest()
        {
            _fixture = new TestFixture();
            WebDriver = _fixture.WebDriver;
        }
    }
}