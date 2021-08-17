using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab3
{
    class Emu : Animal
    {
        public Emu() 
        {
            Specie = "Emu";
            Move = "walk on two legs";
            Diet = "part of plants with nutrients: seeds, fuits, flowers and young shoots";
        }

        public override string Eating()
        {
            return (Specie + " " + Diet);
        }

        public override string printAnimals()
        {
            return(Specie + ":\nThey " + Move + " and " + Diet);
        }

        public override void saveAnimals( StreamWriter sw )
        {
            sw.WriteLine(Specie + ":\nThey " + Move + " and " + Diet);
        }

    }
}
