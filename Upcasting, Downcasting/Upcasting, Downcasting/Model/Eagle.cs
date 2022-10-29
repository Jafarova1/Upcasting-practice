using System;
using System.Collections.Generic;
using System.Text;

namespace Upcasting__Downcasting.Model
{
    public class Eagle : Bird
    {

        public string Color { get; set; }
        public override void Eat()
        {
            Console.WriteLine("eagle eating");
        }
    }
}
