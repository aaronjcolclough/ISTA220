using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Unit
{
    class HMMWV : Vehicles
    {
        public void Accelerate()
        {
            Console.WriteLine("Accelerating");
        }

        public void Brake()
        {
            Console.WriteLine("Braking");
        }
    }
}
