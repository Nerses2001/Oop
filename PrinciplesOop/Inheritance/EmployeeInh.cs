using System;
using Oop.PrinciplesOop.Encapsulation;
using Oop.PrinciplesOop.Encapsulation.Delegation;

namespace Oop.PrinciplesOop.Inheritance
{



    namespace Oop.PrinciplesOop.Encapsulation
    {
        class EmployeeInh
        {
            private string _name;
            private int _id;
            private float  _currPay;
            private int _empAge;
            private int _ssn;
            protected BenefitPackage empBenefits = new BenefitPackage();
            

            public double GetBenefitCost()
            {
                return empBenefits.ComputerPayDeduction();
            }

            public BenefitPackage Benefits { get; set; }


            public int SocialSecurityNumber { get; set; }


            public string  Name { get; set; }
            public int ID { get; set; }  
            public float Pay { get; set; }  
            public int Age { get; set; }    
            public EmployeeInh() { }
            public EmployeeInh(string name, int id, float pay): this(name, 0, id, pay) { }
            public EmployeeInh(string name, int age, int id, float pay)
            {
                _name = name;
                _id = id;
                _currPay = pay;
                _empAge = age;
            }

            public void GiveBonus(float amount)
            {
                Pay += amount;
            }
            public void DisplayStats()
            {
                Console.WriteLine("Name : {0}", Name);
                Console.WriteLine("ID: {0}", ID);
                Console.WriteLine("Age : {0}", Age);
                Console.WriteLine("Pay: {0}", Pay);
            }
            

        }

    }

}
