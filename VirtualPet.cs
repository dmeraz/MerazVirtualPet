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
            this.energyScore = wasteScore;
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

        public 

    }
}
