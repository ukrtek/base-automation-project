using System.Collections.Generic;
using System.IO;
using System.Net;
using base_automation_project.utils;
using Xunit;
using HtmlAgilityPack;

namespace base_automation_project.tests
  
{
    public class LinksTest
    {
        [Fact]
        public void Test()
        {
            string logfilePath = "/Users/mariiayemelianova/sm-automation/base-automation-project/utils/crawl-log.txt";
            Crawler crawler = new Crawler
                (logfilePath);
            
            string startUrl = "https://www.google.com/";
            string html;

            bool isAllRequestsOK = true;

            using (WebClient client = new WebClient())
            {
                html = client.DownloadString(startUrl);
            }
            
            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);
            
            //make a list of all links found on page
            List<string> links = new List<string>();
            TextWriter textWriter = new StreamWriter("links.txt");

            HtmlNodeCollection nodeCollection = htmlDoc
                .DocumentNode
                .SelectNodes("//a[@href]");

            //todo: check each link using checkUrl method
            
            foreach (HtmlNode link in nodeCollection)
            {
                string url = link.Attributes["href"].Value;
                if (crawler.checkUrl(url) == false)
                {
                    isAllRequestsOK = true;
                }
                links.Add(url);
                textWriter.WriteLine(url);
            }
            textWriter.Close();

        }
        
    }
}