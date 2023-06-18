using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.PrinciplesOop.Polymorphism
{
    class EmployeePoly
    {

        public virtual void PrintGivBonus(float amount)
        {
            Console.WriteLine(amount * 10);
        }

    }
}
