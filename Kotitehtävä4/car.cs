using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{

    class Program
    {
        static void Main(string[] args)
        {
            // create one car instance
            Car car = new Car();
            car.Name = "Audi";
            car.Tyres = 240;
            car.Speed = 100;


            car.PrintData();
            Console.WriteLine(car.ToString());
            Console.ReadLine();
        }
    }
}






