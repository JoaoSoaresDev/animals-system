using System;
using System.IO;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            var kang = new Kangaroo();
            var emu = new Emu();


            string path = @"./animals.txt";
            if (!File.Exists(path))
            {
                using ( StreamWriter sw = File.CreateText(path))
                {
                    kang.saveAnimals(sw);
                    emu.saveAnimals(sw);
                }
            }
            else
            {
                using ( StreamWriter sw = new StreamWriter("animals.txt", false))
                {
                    kang.saveAnimals(sw);
                    emu.saveAnimals(sw);
                }
            }

            Console.WriteLine(kang.printAnimals() + "\n" + emu.printAnimals());

        }
    }
}
