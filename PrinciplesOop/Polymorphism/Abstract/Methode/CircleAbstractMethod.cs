using System;


namespace Oop.PrinciplesOop.Polymorphism.Abstract
{
    class CircleAbstractMethod : ShapeAbstractMethod
    {
        public CircleAbstractMethod() { }
        public CircleAbstractMethod(string name): base(name){}

        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Circle", PetName);
        }
    }
}
