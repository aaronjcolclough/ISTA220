using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Farm
{
    class Beast : Animal
    {
        public override string name()
        {
            return "Hank";
        }
        public override string speak()
        {
            return "Oh, my stars and garters";
        }

        public override string drink()
        {
            return "Hank takes a sip of his coffee.";
        }

        public override string fight()
        {
            return "Hank roars and dives through the air at Mortimer.";
        }

        public override string rest()
        {
            return "Hank hangs upside down from a tree branch.";
        }
    }
}
