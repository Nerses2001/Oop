using System;


namespace Oop.PrinciplesOop.Polymorphism.Abstract
{
    abstract class Shape
    {
        public string PetName { get; set; }
        public Shape(string name = "NoName") 
        {
            PetName = name;
        }

        public virtual void Draw()
        {
            Console.WriteLine("Inside Shape.Draw()");
        }
    }
}
