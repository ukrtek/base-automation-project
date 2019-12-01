using System.Collections.Generic;
using System.IO;
using System.Net;
using Xunit;
using HtmlAgilityPack;

namespace base_automation_project.tests

{
    public class LinksTest
    {
        [Fact]
        public void Test()
        {
            string startUrl = "https://www.google.com/";
            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(startUrl);
            
            List<string> links = new List<string>();
            TextWriter textWriter = new StreamWriter("links.txt");


            foreach (HtmlNode link in htmlDoc.DocumentNode.SelectNodes("//a[@href]"))
            {
                string val = link.Attributes["href"].Value;
                links.Add(val);
                textWriter.WriteLine(val);
            }
            
            textWriter.Close();
            
            







        }
        
    }
}