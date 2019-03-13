using System;

namespace Lesson8_UnderstandingScope
{
    class Program
    {
        private static string k = "";

        static void Main(string[] args)
        {
            string j = "";
            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine((i));

                if(i == 9)
                {
                    string l = i.ToString();
                }
                //Console.WriteLine(l);
            }
            Console.WriteLine("Outside of the for block: " + j);
            Console.WriteLine("Outside of the for block: " + k);

            Car myCar = new Car();
            //When I type myCar. I can only see the public methods listed, not the private ones
            myCar.DoSomething();

            Console.ReadLine();
        }

        static void HelperMethod()
        {
            Console.WriteLine("Value of k from the HelperMethod(): " + k);
        }
    }

    class Car
    {
        public void DoSomething()
        {
            Console.WriteLine(HelperMethod());
        }
        private string HelperMethod()
        {
            return "Hello world!";
        }
    }
}
