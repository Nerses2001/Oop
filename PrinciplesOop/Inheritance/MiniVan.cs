using System;

// MiniVan "is-a" Car.
namespace Oop.PrinciplesOop.Inheritance
{
    sealed class MiniVan : ElectroCar
    {
        public void TestMethod()
        {
            Speed = 10;
            //Eror
            //currSpeed = 10;
        }
    }

    // Error! Cannot extend
    // a class marked with the sealed keyword!
    //class DeluxeMmiVan : MiniVan{}
}
