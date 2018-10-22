using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Farm
{
    class Animal
    {
        public virtual string name()
        {
            return "name";
        }
        public virtual string speak()
        {
            return "Makes Noise";
        }

        public virtual string drink()
        {
            return "drinks";
        }

        public virtual string fight()
        {
            return "fights";
        }

        public virtual string rest()
        {
            return "sleeps";
        }
    }
}
