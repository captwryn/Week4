using System;
using System.Collections.Generic;
namespace VirtualMethod
{
    class Car
    {
        public string Make;
        public string Model;
        public int GasAmount;

        public virtual void Drive()
        {
            Console.WriteLine("I'm driving!");
        }
    }
    class EconomyCar : Car
    {
        public override void Drive()
        {
            Console.WriteLine("I'm driving slowly!");
        }
    }

    class RaceCar : Car
    {
        public override void Drive()
        {
            Console.WriteLine("I'm driving fast!");
        }
    }


    class Program
    {
        static void TestTrack(Car testcar)
        {
            Console.WriteLine("\nWe're at the test track!");
            Console.WriteLine($"We're testing a {testcar.Model}!");
            testcar.Drive();
        }

        static void Main(string[] args)
        {
            EconomyCar pinto = new EconomyCar();
            pinto.Make = "Ford";
            pinto.Model = "Pinto";
            pinto.GasAmount = 10;

            RaceCar f1 = new RaceCar();
            f1.Make = "Formula";
            f1.Model = "One";
            f1.GasAmount = 30;

            List<Car> cars = new List<Car>();
            cars.Add(pinto);
            cars.Add(f1);

            Car mycar;
            mycar = pinto;

            Console.WriteLine($"{mycar.Make} {mycar.Model}");
            mycar.Drive();

            mycar = f1;
            Console.WriteLine($"{mycar.Make} {mycar.Model}");
            mycar.Drive();  //the code called the right version of drive.  this is "polymorphism"

            TestTrack(mycar);
        }
    }
}