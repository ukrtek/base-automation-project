using System.IO;
using Microsoft.Extensions.Configuration;

namespace base_automation_project.utils
{
    public class ConfigProvider
    {
        private static IConfiguration _configuration
        {
            get
            {
                return new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory()).AddEnvironmentVariables()
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .AddJsonFile("appsettings.local.json", optional: true, reloadOnChange: true)
                    .AddEnvironmentVariables()
                    .Build();
            }
        }

        public static T GetFromSection<T>(string section)
        {
            return _configuration.GetSection(section).Get<T>();
        }
    }
}