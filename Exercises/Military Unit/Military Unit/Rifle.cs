using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Unit
{
    class Rifle : Weapons
    {
        public override void reload()
        {
            Console.WriteLine("Mag Change");
        }
    }
}
