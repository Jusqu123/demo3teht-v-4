using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Car
    {
        // fied member

        //properties
        public string Name { get; set; }
        public int Speed { get; set; }

        public int Tyres { get; set; }



        // method displays car data
        public void PrintData()
        {
            Console.WriteLine("Car Data: ");
            Console.WriteLine("- name : " + Name);
            Console.WriteLine("- Tyres : " + Tyres);
            Console.WriteLine("- speed : " + Speed);

        }
        // method returns heater data
        public override string ToString()
        {
            return "Name : " + Name + "tyres : " + Tyres + "speed : " + Speed;

        }
    }
}

