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
            //Introduce user to Basil and explain game

            Console.WriteLine("Basil is your friendly garden hedgehog. Can you tame Basil to be your pet?\n");

            Console.WriteLine("   .|||||||||.");
            Console.WriteLine("  |||||||||||||");
            Console.WriteLine(" ||||||||||| ' .\\");
            Console.WriteLine("`|||||||||| _, __o\n");

            Console.WriteLine("Keep Basil happy by feeding, playing, and cleaning up after him.");
            Console.WriteLine("If you can raise all of Basil's scores to 10, he'll settle down as your pet.");
            Console.WriteLine("If any of Basil's levels fall to 0, he will run away.");


            //Ask user to care for pet by selecting menu item
            //Use loop to repeat
            //Use tick method
            //Stretch: randomize scores
            //Add exit feature

            VirtualPet basil = new VirtualPet(5,5,5);

            do
            {
                basil.Tick();
                string choice = Console.ReadLine();
                //QuitCheck(choice);
                switch (choice)
                {
                    case "1":
                        basil.Feed();
                        break;
                    case "2":
                        basil.Play();
                        break;
                    case "3":
                        basil.Clean();
                        break;
                    default:
                        Console.WriteLine("Please enter a valid input");
                        break;
                }
            }
            while (true);
        }
    }
}


