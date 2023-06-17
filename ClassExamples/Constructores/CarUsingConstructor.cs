using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.ClassExamples.Constructores
{
    class CarUsingConstructor
    {
        public string petName;
        public int currSpeed;
        public string color;


        // A custom default constructor.
        public CarUsingConstructor()
        {
            petName = "petName";
            currSpeed = 25;
            color = "red";
        }
            
        
        //Custom Constructors
        public CarUsingConstructor(string pn)
        {
            petName = pn;
        }
        public CarUsingConstructor(string pn, int cs)
        {
            petName = pn;
            currSpeed = cs;
            color = "red";
        }
        public CarUsingConstructor(string petName, int currSpeed, string color)
        {
            this.petName = petName;
            this.currSpeed = currSpeed;
            this.color = color;
        }

        public CarUsingConstructor(int cs)
        {
            //if(cs < 0)
            //{
            //    currSpeed = 10;
            //}
            //currSpeed = cs;
            ChackSpeed(cs);
        }
        //Methode
        private void ChackSpeed(int cs)
        {
            if (cs < 0)
            {
                currSpeed = 10;
            }
            currSpeed = cs;
        }
        public void PrintState()
        {
            Console.WriteLine("{0} is going {1} MPH.Color is {2}", petName, currSpeed,color);

        }


        public void Speedup(int delta) => currSpeed += delta;
    }
}
