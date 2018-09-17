using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Unit
{
    class Personnel
    {
        public virtual void loadVehicle()
        {
            Console.WriteLine("Mount Up!!");
        }

        public virtual void receiveFire()
        {
            Console.WriteLine("Contact!!!");
        }

        public virtual void returnFire()
        {
            Console.WriteLine("PEW! PEW! PEW!");
        }

        public virtual void dismount()
        {
            Console.WriteLine("Dismounting");
        }
    }
}
