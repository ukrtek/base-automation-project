namespace base_automation_project.utils.WebDriverBuilder
{
    public class DriverOption
    {
        /// <summary>
        /// 
        /// </summary>
        public int TimeOutPageLoad { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int TimeOutImplicitWait { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Browsers Browser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string StartUrl { get; set; }

        /// <summary>
        /// 
        /// </summary> 
        public string DriverPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IncognitoMode { get; set; }
    }
}