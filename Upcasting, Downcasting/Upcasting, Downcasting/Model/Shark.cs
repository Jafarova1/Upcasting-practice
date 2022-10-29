using System;
using System.Collections.Generic;
using System.Text;

namespace Upcasting__Downcasting.Model
{
    public class Shark : Fish
    {

        public int ToothCount { get; set; }
        public override void Eat()
        {
            Console.WriteLine("Shark eating");
        }
    }
}
