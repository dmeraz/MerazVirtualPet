using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerazVirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduce user to their new pet and ask for a name

            Console.WriteLine("You have a new pet hedgehog! Give your hedgie a name.\n");

            Console.WriteLine("  .|||||||||.");
            Console.WriteLine(" |||||||||||||");
            Console.WriteLine("||||||||||| ' .\\");
            Console.WriteLine("`|||||||||| _, __o\n");

            Console.WriteLine("Hunger\t\tEnergy\t\tWaste"); //{ Hunger = 10, Energy = 10, Waste = 10}
            //VirtualPet.Tick();
            //Console.WriteLine(Hunger + "\t\t" + Energy + "\t\t" + Waste + "\n");

            VirtualPet name = new VirtualPet(Console.ReadLine()) ;

            //Ask user to pick treat and toy types to reward hedgie



            //Introduce care points

        }
    }
}
