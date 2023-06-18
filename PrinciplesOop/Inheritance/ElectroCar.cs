using System;

// Inheritance is an aspect of OOP that facilitates code reuse.
// Specifically speaking, code reuse comes in two flavors: inheritance (the “is-a” relationship) and
// the containment/delegation model (the “has-a” relationship). 

//When you establish “is-a” relationships between classes, you are building a dependency between two or more class types.


//the “is-a” relationship

namespace Oop.PrinciplesOop.Inheritance
{
    class ElectroCar
    {
        public readonly int maxSpeed;
        private int currSpeed;


        public ElectroCar(int max)
        {
            maxSpeed = max;
        }
        public ElectroCar()
        {

        }


        public int Speed { 
            get { return currSpeed; }
            set
            {
                currSpeed = value;
                if(currSpeed > maxSpeed)
                {
                    currSpeed = maxSpeed;
                }
            }
        
        }
    }
}
