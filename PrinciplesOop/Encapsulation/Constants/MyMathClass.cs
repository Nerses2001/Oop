using System;

// C# offers the const keyword to define constant data, which can never change after the initial assignment. As
// you might guess, this can be helpful when you are defining a set of known values for use in your applications
// that are logically connected to a given class or structure.
//the constant fields of a class are implicitly static
namespace Oop.PrinciplesOop.Encapsulation.Constants
{
    class MyMathClass
    {
        public const double PI = 3.14;
        public readonly double PI2;
        public static readonly double PI3 = 3.144;
        static MyMathClass(){ PI3 = 3.14; }

        public MyMathClass()
        {
            PI2 = 3.14;
        }
        // public const double PI1;
        /* public MyMathClass()
        {
            // Not possible- must assign at time of declaration.
            PI1 = 3.14;
        }*/
        // Error! public void ChangePI(){ PI2 = 3.14444;}
        static void LocalConstStringVanable()
        {
            // A local constant data point can be directly accessed.
            const string fixedStr = "Fixed string Data";
            Console.WriteLine(fixedStr);
            // Error!
            // fixedStr = "This will not work!";

        }




    }

}
