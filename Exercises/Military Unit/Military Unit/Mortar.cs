using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Unit
{
    class Mortar : Weapons
    {
        public override void load()
        {
            Console.WriteLine("Hang It!");
        }

        public override void aim()
        {
            Console.WriteLine("Deflection... Elevation...");
        }
    }
}
