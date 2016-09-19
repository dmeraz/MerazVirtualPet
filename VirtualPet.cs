using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerazVirtualPet
{
    class VirtualPet
    {
        //Fields
        //Things the pet should have

        private string name;
        private int hungerScore;
        private int energyScore;
        private int wasteScore;


        //Constructors

        public VirtualPet(string name)
        {
            this.name = name;
        }

        public VirtualPet(int hungerScore, int energyScore, int wasteScore)
        {
            this.hungerScore = hungerScore;
            this.energyScore = energyScore;
            this.wasteScore = wasteScore;
        }


        //Methods to care for pet

        public void Feed()
        {
            Console.WriteLine("Yum!");
            Hunger += 2;
            Energy ++;
            Waste ++;
        }

        public void Play()
        {
            Console.WriteLine("Wee!");
            Hunger --;
            Energy -= 3;
            Waste --; 
        }

        public void Clean()
        {
            Console.WriteLine("Ahh...That's better.");
            Energy += 2;
            Waste += 2;
        }


        //Methods to track care

        public void ScoreBoard()
        {
            if (Hunger <= 0 || Energy <= 0 || Waste <= 0)
            {
                Console.WriteLine("\nBasil ran away!");
                Console.WriteLine("Maybe you'll see him the next time you vist the garden. Bye, now!");
                System.Threading.Thread.Sleep(500);
                Environment.Exit(0);
            }
            else if (Hunger >= 10 && Energy >= 10 && Waste >= 10)
            {
                Console.WriteLine("\nYou're a great hedgie parent! Looks like Basil is home to stay.");
                Console.WriteLine("Hunger: " + Hunger);
                Console.WriteLine("Energy: " + Energy);
                Console.WriteLine("Waste: " + Waste);
                System.Threading.Thread.Sleep(500);
                Environment.Exit(0);
            }
        }


        //Tick updates levels and asks user to care for pet by selecting menu item

        public void Tick()
        {
            ScoreBoard();
            Console.WriteLine("\n   .|||||||||.");
            Console.WriteLine("  |||||||||||||");
            Console.WriteLine(" ||||||||||| ' .\\");
            Console.WriteLine("`|||||||||| _, __o\n");
            Console.WriteLine("Food: " + Hunger);
            Console.WriteLine("Energy: " + Energy);
            Console.WriteLine("Clean: " + Waste);
            Console.WriteLine("\nPress 1 to Feed, 2 to Play, or 3 to Clean.");
        }


        //Properties

        //public string Name
        //{
        //    get { return this.name; }
        //    set { this.name = "Basil"; }
        //}

        public int Hunger
        {
            get
            {
                return this.hungerScore;
            }
            set
            {
                this.hungerScore = value;
            }
        }

        public int Energy
        {
            get
            {
                return this.energyScore;
            }
            set
            {
                this.energyScore = value;
            }

        }
        public int Waste
        {
            get
            {
                return this.wasteScore;
            }
            set
            {
                this.wasteScore = value;
            }
        }

        
        }
        }
    


