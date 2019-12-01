namespace base_automation_project.utils
{
    public class Crawler
    {

        public Crawler(string StartUrl)
        {
            
        }
        
        


        /*
  function takeNotVisitedUrlFromUrlsList(map<string, boolean> urlsStorage) -> string url {
      for url in urlsStorage {
          if "url is not visited" {
              return url
          }
      }
  }
  
  function markUrlAsVisited(map<string, boolean> urlsStorage, string urlToVisit) {
      urlsStorage[urlToVisit] = true
  }
  
  function downloadPage(string url) -> string htmlText {
      response = httpClient.get(url)
  
      // if response is error - > we want to track it  somehow here
      // check that response is html page
  
      return response.body
  }
  
  function parsePage(string htmlText) -> list<string> urls {
      // we are looking for <a> tags, extract href values
      // xml/html parsing library
  }
  
  function addFoundUrlsToUrlsStorage(map<string, boolean> urlsStorage, list<string> newUrls) {
      for url in newUrls {
          if (isUrlInterestingForUs(url) AND "url not in urlsStorage") {
              urlsStorage[url] = false    // add url to storage
          }
      }
  }
  
  function isUrlInterestingForUs(string url) -> boolean {
      // for example: check domain name
  }
  
  
  function step() {
      1) string urlToVisit = takeNotVisitedUrlFromUrlsList(urls)
  
      2) string htmlText = downloadPage(urlToVisit)
  
      3) list<string> newUrls = parsePage(htmlText)
  
      4) markUrlAsVisited(urlsStorage, urlToVisit)
  
      5) addFoundUrlsToUrlsStorage(urlsStorage, newUrls)
  }
  
  
  // GOAL: make all URLs from urlsStorage visited
  // urlsStorage always grows in size
  function crawl() {
      //  url     isVisited
      map<string, boolean> urlsStorage = {
          "http://google.com": false,
          "http://facebook.com": true
      }
  
      loop {
         step()
         wait()
      }
  }
  
  */




    }
}