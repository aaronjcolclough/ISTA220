using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Farm
{
    class Toad : Animal
    {
        public override string name()
        {
            return "Mortimer";
        }
        public override string speak()
        {
            return "I'm basically useless.";
        }

        public override string drink()
        {
            return "Nope, can't do that.";
        }

        public override string fight()
        {
            return "Can't do that either.";
        }

        public override string rest()
        {
            return "I suck.";
        }
    }
}
