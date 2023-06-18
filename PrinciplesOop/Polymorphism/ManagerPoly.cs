using System;


namespace Oop.PrinciplesOop.Polymorphism
{
    class ManagerPoly : EmployeePoly
    {
        public override void PrintGivBonus(float amount)
        {
            base.PrintGivBonus(amount);
            Random r = new Random();
            Console.WriteLine(amount * r.Next(500));

        }
    }
}
