using Serilog;

namespace base_automation_project.utils
{
    public class LoggerManager
    {
        public ILogger buildLogger()
        {
            return new LoggerConfiguration()
                .MinimumLevel.Information()
                //todo : remove hardcoded log path
                .WriteTo.File("logs/log.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();
        }
        
    }
}