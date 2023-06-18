using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.ClassExamples
{
    class CarAuto
    {
        // 'State' of the Car object.
        public string petName;
        public int  currSpeed;

        // Function object Car
        public void PrintState()
        {
            Console.WriteLine("{0} is going {1} MPH.", petName, currSpeed);

        }
        public void Speedup(int delta) => currSpeed += delta;
    }
}
