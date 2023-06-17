using System;

namespace Oop.ClassExamples.Constructores
{
    class Motorcycle
    {
        public int driverIntensity;
        public string driverName;

        public Motorcycle()
        {
            Console.WriteLine("Deffault Constructor");
        }

        public Motorcycle(int intensity) : this(intensity, "")
        {
            Console.WriteLine("Constructor with intensity parameter");
        }
        public Motorcycle(string name) : this(0, name)
        {
            Console.WriteLine("In ctor taking a string");
        }
        public Motorcycle(int intensity, string name)
        {
            Console.WriteLine("In master ctor ");
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
            driverName = name;
        }


    }
}
