using System;
using System.Collections.Generic;
using System.Text;

namespace Upcasting__Downcasting.Model
{
    public abstract class Fish : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Fish eating");
        }
    }
}
