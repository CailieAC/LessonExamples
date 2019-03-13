using System;

namespace Lesson8_ClassesObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string car1Make;
            string car1Model;
            int car1Year;
            string car1Color;

            string car2Make;
            string car2Model;
            int car2Year;
            string car2Color;

            string car3Make;
            string car3Model;
            int car3Year;
            string car3Color;
            */
            Car myCar = new Car();
            myCar.Make = "Oldsmobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1986;
            myCar.Color = "Silver";

            Console.WriteLine("{0} {1} {2} {3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color);

            //decimal value = DetermineMarketValue(myCar);
            //Console.WriteLine("{0:C}",value);

            Console.WriteLine("{0:C}", myCar.DetermineMaketValue());

            Console.ReadLine();
        }

        private static decimal DetermineMarketValue(Car car)
        {
            decimal carValue = 100.0M;
            //Someday I might look up the car online with a
            //webservice to get a more accurate value
            return carValue;
        }

    }
    class Car
    {
        //type "prop" tab tab
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        //Create method inside this separate Car class
        public decimal DetermineMaketValue()
        {
            decimal carValue;
            if (Year > 1990)
                carValue = 10000;
            else
                carValue = 2000;
            return carValue;
        }
    }
}
