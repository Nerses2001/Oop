
using System;

// A given class may define only a single static constructor. In other words, the static constructor cannot be overloaded.
// A static constructor does not take an access modifier and cannot take any parameters.
// A static constructor executes exactly one time, regardless of how many objects of the type are created.
// The runtime invokes the static constructor when it creates an instance of the class or before accessing the first static member invoked by the caller
// The static constructor executes before any instance-level constructors.


namespace Oop.ClassExamples.Statices
{
    class ChangeStatic
    {
        public double currBalance;
        public static double currlnterestRate = 0.04;


        public ChangeStatic(double balance)
        {
            currBalance = balance;
        }
        static ChangeStatic()
        {
            // The message "In static ctor! " is printed only once,
            // because the CLR calls all static constructors
            // before the first use (and never calls them again for a given application instance):
            Console.WriteLine("In static ctor!"); 
            currlnterestRate = 0.04;
        }

        public static double GetlnterestRate()
        {
            return currlnterestRate;

        }
        public static void SetlnterestRate(double newRate)
        {
            currlnterestRate = newRate;
        }
    }
}
