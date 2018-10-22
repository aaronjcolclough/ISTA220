using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Farm
{
    class Wolverine : Animal
    {
        public override string name()
        {
            return "James";
        }
        public override string speak()
        {
            return "Bad news, bub...";
        }

        public override string drink()
        {
            return "James cracks open a beer and drinks.";
        }

        public override string fight()
        {
            return "James' metal claws extend from his hand as he eyes Victor.";
        }

        public override string rest()
        {
            return "James takes a seat and lights up a cigar.";
        }
    }
}
