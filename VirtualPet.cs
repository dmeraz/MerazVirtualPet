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

        //Stretch
        //private string treat;
        //private string favToy;
        

        //Constructors

        public VirtualPet (string name)
        {
            this.name = name;
        }

        //Do I need this?
        //public VirtualPet (int hungerScore, int energyScore, int wasteScore)
        //{
        //    this.hungerScore = hungerScore;
        //    this.energyScore = energyScore;
        //    this.wasteScore = wasteScore;
        //}

        //Stretch
        //public VirtualPet (string name, string treat, string favToy)
        //{
        //    this.name = name;
        //    this.treat = treat;
        //    this.favToy = favToy;
        //}


        //Methods
        //Ways to care for pet

        public string GetName()
        {
            return name;
        }

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
            Energy --;
            Waste --;
        }

        public void CleanCage()
        {
            Console.WriteLine("Ahh...That's better.");
            Energy += 2;
            Waste += 2;
        }

        //Score keeping method(s)?
        //public void Tick(int hunger, int energy, int waste)
        //{
        //    ScoreBoard(hunger, energy, waste);
        //}

        
        //Probably delete at end
        //private void ScoreBoard(int hunger, int energy, int waste)
        //{
        //    this.hungerScore = hunger;
        //    this.energyScore = energy;
        //    this.wasteScore = waste;
        //}

        //Stretch
        //public string Reward()
        //{
        //    return treat;
        //}


        //Properties

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

        public void ScoreBoard()
        {
            Console.WriteLine("\nHunger: " + Hunger);
            Console.WriteLine("Energy: " + Energy);
            Console.WriteLine("Waste: " + Waste);
        }
    }
}
