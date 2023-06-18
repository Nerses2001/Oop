using System;
using Oop.PrinciplesOop.Encapsulation;
using Oop.PrinciplesOop.Inheritance.Oop.PrinciplesOop.Encapsulation;

namespace Oop.PrinciplesOop.Inheritance
{
    class Manager : EmployeeInh
    {
        public int StockOption { get; set; }
        public Manager(string fullName, int age, int empID, float currPay, string ssn, int numbersOfOpts)
        {
            ID = empID; 
            Age = age; 
            Name = fullName;
            Pay = currPay;
            //eror
            // SocialSecurityNumber = ssn;
        }

    }
}
