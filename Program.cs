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

            Console.WriteLine("Basil is your friendly garden hedgehog. Can you tame Basil to be your pet?\n");

            Console.WriteLine("   .|||||||||.");
            Console.WriteLine("  |||||||||||||");
            Console.WriteLine(" ||||||||||| ' .\\");
            Console.WriteLine("`|||||||||| _, __o\n");

            Console.WriteLine("Keep Basil happy by feeding, playing, and cleaning up after him.");
            Console.WriteLine("If any of Basil's levels fall to 0, he will run away.");


            //Make score board

            //Attempt to make scores appear on one line
            //Console.WriteLine("Hunger\t\tEnergy\t\tWaste");
            //VirtualPet.Tick();
            //Console.WriteLine(Hunger + "\t\t" + Energy + "\t\t" + Waste + "\n");

            //VirtualPet userHedgie = new VirtualPet(Console.ReadLine());

            //Set starting scores to 5. User must keep total above 10 or hedgie will run away.
            //int hungerScore = userHedgie.Hunger;
            //userHedgie.Hunger = 0;

            //int energyScore = userHedgie.Energy;
            //userHedgie.Energy = 0;

            //int hungerWaste = userHedgie.Waste;
            //userHedgie.Waste = 0;

            //Stretch
            //Ask user to pick treat and toy types to reward hedgie



            //Introduce care points
            //Console.WriteLine("\nNice to meet you, " + userHedgie.GetName() + "!");
           


            //Ask user to care for pet by selecting menu item
            //Use if loop to repeat
            //Use tick method to randomize scores
            //Add exit feature
            //End game if all scores hit 10--"You're a great hedgie parent!"
            //End game if any score hits 0 or total below 10--"You're hedgie ran away!"


        }
    }
}


