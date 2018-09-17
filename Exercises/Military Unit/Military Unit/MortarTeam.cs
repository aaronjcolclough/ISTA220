using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Unit
{
    class MortarTeam : Personnel
    {
        public void fireMiss()
        {
            Console.WriteLine("Fire Mission!");
        }

        public void outofAction()
        {
            Console.WriteLine("Out of action!");
        }
    }
}
