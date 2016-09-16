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
        
        //Properties
        public VirtualPet (string name)
        {
            this.name = name;
        }

        public VirtualPet (int hungerScore, int energyScore, int wasteScore)
        {
            this.hungerScore = hungerScore;
            this.energyScore = energyScore;
            this.wasteScore = wasteScore;
        }

        public VirtualPet (string name, string favToy)
        {
            this.name = name;
            this.favToy = favToy;
        }

        //Methods
        public string GetName()
        {
            return name;
        }

        public void GetHunger(int hunger)
        {
            this.hungerScore = hunger;
        }

        public void GetEnergy(int energy)
        {
            this.energyScore = energy;
        }

        public void GetWaste(int waste)
        {
            this.wasteScore = waste;
        }
    }
}
