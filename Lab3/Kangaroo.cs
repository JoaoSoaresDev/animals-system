using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab3
{
    class Kangaroo : Animal
    {
        public Kangaroo()
        {
            Specie = "Kangaroo";
            Move = "jump instead of walk";
            Diet = "eat mainly leaves and grass";
        }

        public override string Eating()
        {
            return (Specie + " " + Diet);
        }

        public override string printAnimals()
        {
            return (Specie + ":\nThey " + Move + " and " + Diet);
        }

        public override void saveAnimals( StreamWriter sw )
        {
            sw.WriteLine(Specie + ":\nThey " + Move + " and " + Diet);
        }

    }
}
