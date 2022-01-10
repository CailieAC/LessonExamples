using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Lesson9_ReferencesToAssemblies
{
    class ScrapeLibrary
    {
        public string ScrapeWebpage(string url)
        {
            return GetWebpage(url);
        }
        public string ScrapeWebpage(string url, string filepath)
        {
            string reply = GetWebpage(url);
            File.WriteAllText(filepath, reply);
            return reply;
        }

        private string GetWebpage(string url)
        {
            WebClient client = new WebClient();
            string content = client.DownloadString(url);
            content += "That's All Folks!";
            return content;
        }
    }
}
