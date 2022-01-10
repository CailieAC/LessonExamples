using System;

namespace Lesson9_ReferencesToAssemblies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter URL: ");
            string url = Console.ReadLine();
            Console.Write("Enter filepath: ");
            string filepath = Console.ReadLine();
            ScrapeLibrary newScrape = new ScrapeLibrary();

            if (filepath.Length > 0)
                Console.WriteLine(newScrape.ScrapeWebpage(url, filepath));
            else
                Console.WriteLine(newScrape.ScrapeWebpage(url));
            Console.ReadLine();
        }
    }
}
