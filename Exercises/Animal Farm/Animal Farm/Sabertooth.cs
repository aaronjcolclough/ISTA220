using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Farm
{
    class Sabertooth : Animal
    {
        public override string name()
        {
            return "Victor";
        }
        public override string speak()
        {
            return "You'll pay me how much?";
        }

        public override string drink()
        {
            return "Victor steals one of James' beers and crushes it in his mouth.";
        }

        public override string fight()
        {
            return "Victor lunges at James, teeth and claws exposed.";
        }

        public override string rest()
        {
            return "Victor finds a spot in the shade and lays down.";
        }
    }
}
