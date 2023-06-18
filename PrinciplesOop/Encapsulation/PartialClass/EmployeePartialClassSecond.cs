using System;

namespace Oop.PrinciplesOop.Encapsulation.PartialClass
{
    partial class EmployeePartialClassFirst
    {
        public void PrintDetails()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
            Console.WriteLine($"Hire Date: {HireDate.ToShortDateString()}");
        }
    }
}
