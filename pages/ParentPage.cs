using base_automation_project.utils;
using OpenQA.Selenium.Remote;

namespace base_automation_project.Pages
{
    public class ParentPage
    {
        //todo: add logger field;
        protected ActionsWithElements Actions;
        protected RemoteWebDriver Driver;
        protected string ExpectedURL;
        protected ConfigProvider ConfigProvider;

        public ParentPage(RemoteWebDriver driver /*, string expectedUrl*/)
        {
            this.Driver = driver;
            Actions = new ActionsWithElements();
            
            //todo: need to investigate the following line for c# specifics
            //PageFactory.initElements(webDriver, this);  // this line starts init elements
            //todo - need this one??
            //this.ExpectedURL = ConfigProvider.GetFromSection<>()

        }
        

    }
}