using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_10_IPizza
{
    class Oven
    {
        public Oven()
        {

        }

        public void Bake(IPizza pizza)
        {
            Console.WriteLine("I baked a " + pizza.GetType() + " pizza.");
        }
    }
}
