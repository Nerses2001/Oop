

// Static can be Data of a class
//               Methods of a class
//            	 Properties of a class
//               A constructor
//               The entire class definition
//               In conjunction with the C# using keyword
//  Static data is perfect when you have a value that should be common to all objects of that category
// On arelated note, it is an error to use the this keyword on a static member because this implies an object!

namespace Oop.ClassExamples.Statices
{
    class SavingsAccount
    {
        public double currBalance;

        public static double currlnterestRate = 0.04;
        public SavingsAccount(double balance)
        {
            currBalance = balance;
        }

        public static void SetlnterestRate(double newRate)
        {
            currlnterestRate = newRate; 
        }
        public static double GetlnterestRate()
        {
            return currlnterestRate; 
        }
    }
}
