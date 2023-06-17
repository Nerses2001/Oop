using System;
using Oop.ClassExamples;
using Oop.ClassExamples.Constructores;

namespace Oop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car myCar = new Car();
            myCar.petName = "petName";
            myCar.currSpeed = 10;

            CarUsingConstructor car1 = new CarUsingConstructor();
            CarUsingConstructor car2 = new CarUsingConstructor(10);
            CarUsingConstructor car3 = new CarUsingConstructor("petName2");
            CarUsingConstructor car4 = new CarUsingConstructor("asas",45);
            CarUsingConstructor car5 = new CarUsingConstructor("asas", 45, "RED");

            Motorcycle m1 = new Motorcycle();
            Console.WriteLine("Name= {0}, Intensity= {1}", m1.driverName, m1.driverIntensity);
            
            Motorcycle m2 = new Motorcycle(name: "Tiny");
            Console.WriteLine("Name= {0}, Intensity= {1}",m2.driverName, m2.driverIntensity);
            
            Motorcycle m3 = new Motorcycle(7);
            Console.WriteLine("Name= {0}, Intensity= {1}",m3.driverName, m3.driverIntensity);
            
            Console.ReadLine();

        }
    }
}
