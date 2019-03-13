using System;
using System.Text;

namespace Lesson7_WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            //string myString = "My \"so-called\" life ";
            //string myString = "What if I need a\nnew line";
            //string myString = "Go to your c:\\ drive";
            //string myString = @"Go to your c:\ drive";
            //string myString = String.Format("{0} = {1} and {0} = {1}", "First", "Second");

            //for currency use :C:
            //string myString = String.Format("{0:C}", 123.45);

            //number format:
            //string myString = String.Format("{0:N}", 1234567890);

            //percentage format
            //string myString = String.Format("Percentage: {0:P}", .123);

            //custom format, will insert extra numbers to the left-most # character (formats right to left)
            //string myString = String.Format("Custom (Phone Number): {0:(###) ###-####}", 1234567890);

            //string myString = " That summer we took threes across the board  ";
            //myString = myString.Substring(6);
            //myString = myString.Substring(6, 14);
            //myString = myString.ToUpper();
            //myString = myString.Replace(" ", "--");
            //myString = myString.Remove(6, 14);
            //myString = myString.Trim();
            //myString = String.Format("Length before: {0} -- Length after: {1}", myString.Length, myString.Trim().Length);

            /*
            String myString = "";
            for (int i = 0; i < 100; i++)
            {
                myString += "--" + i.ToString();
            }
            */
            
            //String Builder, more efficient way to deal with changing strings
            StringBuilder myString = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                myString .Append("--");
                myString.Append(i);
            }

            

            //string myString = " ";
            Console.WriteLine(myString);
            Console.ReadLine();


        }
    }
}
