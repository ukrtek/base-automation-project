using base_automation_project.utils;
using OpenQA.Selenium.Remote;
using Serilog;

namespace base_automation_project.Pages
{
    public class ParentPage
    {
        //todo: add logger field;
        protected ActionsWithElements Actions;
        protected RemoteWebDriver Driver;
        protected LoggerManager LoggerManager;
        protected ILogger Logger;
        protected string ExpectedURL;
        protected ConfigProvider ConfigProvider;

        public ParentPage(RemoteWebDriver driver /*, string expectedUrl*/)
        {
            Driver = driver;
            Actions = new ActionsWithElements(Driver);
            LoggerManager = new LoggerManager();
            Logger = LoggerManager.buildLogger();

            //todo: need to investigate the following line for c# specifics
            //PageFactory.initElements(webDriver, this);  // this line starts init elements
            //todo - need this one??
            //this.ExpectedURL = ConfigProvider.GetFromSection<>()

        }
        

    }
}