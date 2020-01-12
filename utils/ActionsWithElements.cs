using OpenQA.Selenium.Remote;
using Serilog;

namespace base_automation_project.utils
{
    public class ActionsWithElements
    {
        protected RemoteWebDriver WebDriver;
        protected ILogger Logger;

        public ActionsWithElements(RemoteWebDriver webDriver)
        {
            WebDriver = webDriver;
            Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File("logs/log.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();
        }

    }
}