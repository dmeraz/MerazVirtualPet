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

        private string name;
        private int hungerScore;
        private int energyScore;
        private int wasteScore;
        private string treat;
        private string favToy;
        
        //Constructors

        public VirtualPet (string name)
        {
            this.name = name;
        }

        //public VirtualPet (int hungerScore, int energyScore, int wasteScore)
        //{
        //    this.hungerScore = hungerScore;
        //    this.energyScore = energyScore;
        //    this.wasteScore = wasteScore;
        //}

        public VirtualPet (string name, string treat, string favToy)
        {
            this.name = name;
            this.treat = treat;
            this.favToy = favToy;
        }


        //Methods

        public string GetName()
        {
            return name;
        }

        public void Tick(int hunger, int energy, int waste)
        {
            this.hungerScore = hunger;
            this.energyScore = energy;
            this.wasteScore = waste;
        }

        public string Reward()
        {
            return treat;
        }


        //Properties

        public int Hunger
        {
            get
            {
                return hungerScore;
            }
            //set
            //{
            //    hungerScore = value1;
            //    if (energyScore < 0)
            //        energyScore = 0;
            //}
        }

        public int Energy
        {
            get
            {
                return energyScore;
            }
        }

        public int Waste
        {
            get
            {
                return wasteScore;
            }
        }

    }
}
