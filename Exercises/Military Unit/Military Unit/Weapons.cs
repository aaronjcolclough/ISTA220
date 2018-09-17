using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Unit
{
    class Weapons
    {
        public void fire(string soundfiring)
        {
            Console.WriteLine(soundfiring);
        }

        public virtual void reload()
        {
            Console.WriteLine("Reloading");
        }

        public virtual void aim()
        {
            Console.WriteLine("Aiming");
        }

        public virtual void load()
        {
            Console.WriteLine("Loading");
        }
    }
}
