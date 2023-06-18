using System;


namespace Oop.PrinciplesOop.Polymorphism.Abstract
{
    abstract class ShapeAbstractMethod
    {
        public string PetName { get; set; }
        public ShapeAbstractMethod(string name = "NoName") 
        {
            PetName = name;
        }

        public abstract void Draw();
    }
}
