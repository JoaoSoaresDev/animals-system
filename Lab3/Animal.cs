using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


// Interface that prints animals to CLI
public interface IPrintAnimal
{
    string printAnimals();
}

// Interface that save animal data to "Animals.txt" 
public interface ISaveAnimal
{
    void saveAnimals(StreamWriter sw);
}

namespace Lab3
{
    abstract class Animal : IPrintAnimal, ISaveAnimal
    {
        private string specie;
        private string eatingDiet;
        private string moviment;


        public Animal() 
        {
            specie = "";
            eatingDiet = "";
            moviment = "";
        }

        public Animal(string spec, string eat, string move) 
        {
            specie = spec;
            eatingDiet = eat;
            moviment = move;
        }

        public string Specie
        {
            get { return specie; }
            set { specie = value; }
        }

        public string Diet
        {
            get { return eatingDiet; }
            set { eatingDiet = value; }
        }

        public string Move
        {
            get { return moviment; }
            set { moviment = value; }
        }

        public abstract string Eating();

        public abstract string printAnimals();

        public abstract void saveAnimals(StreamWriter sw);
    }
}
