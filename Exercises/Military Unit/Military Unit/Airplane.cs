using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Unit
{
    class Airplane : Vehicles
    {
        public void TakeOff()
        {
            Console.WriteLine("Taking off");
        }

        public void Land()
        {
            Console.WriteLine("Landing");
        }

        public override void Drive()
        {
            Console.WriteLine("Taxiing");
        }
    }
}
