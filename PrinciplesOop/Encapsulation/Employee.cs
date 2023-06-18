
// This trait boils down to the language’s ability to hide unnecessary implementation details from the object user
// The concept of encapsulation revolves around the notion that an object’s data should not be directly accessible from an object instance
using System;

namespace Oop.PrinciplesOop.Encapsulation
{
    internal class Employee
    {
        private string _empName;
        private int _empID;
        private float  _currPay;
        private int _empAge;
//        private string _empSSN;

        public Employee() { }
//        public Employee(string name, int iD, float pay)
//        {
//            _empName = name;
//            _empID = iD;
//            _currPay = pay;
//        }   

        public void GiveBonus(float amount)
        {
            _currPay += amount;
        }

        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", _empName); 
            Console.WriteLine("ID: {0}", _empID);
            Console.WriteLine("Age : {0}", Age);
            Console.WriteLine("Pay: {0}", _currPay); 
        }
        public Employee(string name, int iD, float pay) : this(name, 0, iD, pay){}
        public Employee(string name, int age , int iD, float pay)
        {
            _empName = name;
            _empID = iD;
            _currPay = pay;
            _empAge = age;
        }

        public string GetName()
        {
            return _empName;
        }


        public void SetName(string name)
        {
            if(name.Length > 15)
               Console.WriteLine("Error! Name length exceeds 15 characters!");
            else
               _empName = name;
        }

        public string Name 
        {
            get { return _empName; } 
            set 
            { 
                if( value.Length >15 )
                    Console.WriteLine("Error! Name length exceeds 15 characters!");
                else
                    _empName = value;
            }
        }
          
        public int Id 
        { 
          get { return _empID; } 
          set { _empID = value; }
        }
//        public float Pay
//        {
//          get { return _currPay; }
//          set { _currPay = value; }
//        }
          
        public float Pay { get; set; }
//        public int Age
//        {
//            get { return _empAge; }
//            set { _empAge = value; }
//        }
        public int Age
        {
            get => _empAge;
            set => _empAge = value; 
        }

        //        public string SocialSecurityNumber
        //        {
        //            get { return _empSSN;}
        //        }
//        public string SocialSecurityNumber { get; } // if only set




    }
}
