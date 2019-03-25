using System;
using System.IO;
using System.Net;

namespace Lesson9_Namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
           
            /*
            // Example: Write one string to a text file.
            string text = "A class is the most powerful data type in C#. Like a structure, " +
                           "a class defines the data and behavior of the data type. ";
            // WriteAllText creates a file, writes the specified string to the file,
            // and then closes the file.    You do NOT need to call Flush() or Close().
            //System.IO.File.WriteAllText(@"C:\Users\Public\TestFolder\WriteText.txt", text);
            File.WriteAllText(@"E:\Documents\Comp Sci\CoderGirl\Lesson 9\WriteText.txt", text);
            Console.ReadLine();
            */

            WebClient client = new WebClient();
            string reply = client.DownloadString("https://developer.microsoft.com/en-us/");
            Console.WriteLine(reply);
            File.WriteAllText(@"E:\Documents\Comp Sci\CoderGirl\Lesson 9\WriteText.txt", reply);
            Console.ReadLine();
        }
    }
}
