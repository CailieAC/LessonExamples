using System;

namespace Lesson8_ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Car myCar = new Car();

            Car.MyMethod();

            /*
            myCar.Make = "Oldsmobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1986;
            myCar.Color = "Silver";
            */

            /*
            Car myCar = new Car
            {
                Make = "Oldsmobile",
                Model = "Cutlas Supreme",
                Year = 1986,
                Color = "Silver"
            };
            */

            Car myThirdCar = new Car("Ford", "Escape", 2005, "White");

            Car myOtherCar;
            //setting one object equal to another means it points to the same place in memory
            myOtherCar = myCar;
            Console.WriteLine("{0} {1} {2} {3}", 
                myOtherCar.Make, 
                myOtherCar.Model, 
                myOtherCar.Year, 
                myOtherCar.Color);

            //Because myCar and myOtherCar are pointing at the same place, changing either
            //will change the other
            myOtherCar.Model = "98";

            Console.WriteLine("{0} {1} {2} {3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color);

            //intentionally setting these object values to null, or when they go out of scope
            //that object handle will be removed from memory
            myOtherCar = null;

            /* This code section would throw an exception
                Console.WriteLine("{0} {1} {2} {3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color);
            */

            //This will remove all references to this "bucket" and the object will be removed from memory
            //We don't know when the .Net framework runtime will actually execute the garbage collection
            //step, so that can pose problems in certain situations. We don't know when this object will
            //actually be removed. We can request .Net to do this, but not covering it right now.
            myCar = null;



            Console.ReadLine();
        }


    }
    class Car
    {
        //type "prop" tab tab
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        //Constructor, sets default value. If you don't set one, the default has no parameters.
        public Car()
        {
            //this.Make this keyword is optional, refers to this instance of this object
            //This could load values into various properties from a config file or database, etc.
            Make = "Nissan";
        }

        //overloaded constructor/method - having more than one constructor/method with same name
        //and different inputs
        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }
        public static void MyMethod()
        {
            Console.WriteLine("Called the static MyMethod");
        }
    }
}
