using System;
using System.IO;
using System.Net;

namespace base_automation_project.utils
{
    public class Crawler
    {
        //path where log will be recorded
        private string logPath;

        public Crawler(string logfilePath)
        {
            logPath = logfilePath;
        }
        
        //todo: method to parse file with urls 
        // 

        public bool checkUrl(string url)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse httpWebResponse = (HttpWebResponse) httpWebRequest.GetResponse();

            if (httpWebResponse.StatusCode != HttpStatusCode.OK)
            {
                TextWriter textWriter = new StreamWriter(logPath);
                string msg = String.Format
                ("{0} has issues, see description: {1} \n *** \n", url, httpWebResponse.StatusDescription);
                textWriter.WriteLine(msg);
                return false;
            }
            return true;
        }
        
        
        



    }
}