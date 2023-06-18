using System;


namespace Oop.PrinciplesOop.Polymorphism.Abstract
{
    class HexagonAbstractMethod: ShapeAbstractMethod
    {
        public HexagonAbstractMethod() { }
        public HexagonAbstractMethod(string name):base (name) { }

        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Hexagon", PetName);
        }
    }
}
