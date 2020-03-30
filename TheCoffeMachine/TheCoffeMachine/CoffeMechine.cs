using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCoffeMachine
{
    class CoffeMechine
    {
        private CoffePowder coffePowder;
        private WaterGalon waterGalon;
        private Milk milk;

        public CoffeMechine(CoffePowder powder, WaterGalon galon, Milk milk)
        {
            this.waterGalon = galon;
            this.coffePowder = powder;
            this.milk = milk;
        }

        public String makeCappucino()
        {
            if (!this.waterGalon.isAvailable())
            {
                return "Sorry, the coffe is empty";
            }

            this.waterGalon.makeOneCup();
            this.coffePowder.makeOneCup();
            this.milk.makeOneCup();
            return "Yey! your coffe is ready";
        }

        public String checkAvailability()
        {
            return $"the water :{this.waterGalon.getVolume()} the coffe powder : {this.coffePowder.getNetto()} and the milk :{this.milk.getVolume()}";
        }
    }
}
