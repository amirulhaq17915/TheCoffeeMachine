using System;
using System.Collections.Generic;
using System.Text;

namespace TheCoffeeMachine
{
    class CoffeeMachine
    {
        private CoffeePowder CoffeePowder;
        private WaterGalon WaterGalon;
        private CoffeeMilk CoffeeMilk;

        public CoffeeMachine(CoffeePowder powder, WaterGalon galon, CoffeeMilk milk)
        {
            this.WaterGalon = galon;
            this.CoffeePowder = powder;
            this.CoffeeMilk = milk;
        }

        public String makeCappucino()
        {
            if (!this.WaterGalon.isAvailable())
            {
                return "Sorry, the water is empty";
            }
            if (!this.CoffeePowder.isAvailable())
            {
                return "Sorry, the coffe is empty";
            }
            if (!this.CoffeeMilk.isAvailable())
            {
                return "Sorry, the coffe is empty";
            }

            this.WaterGalon.makeOneCup();
            this.CoffeePowder.makeOneCup();
            this.CoffeeMilk.makeOneCup();
            return "Yey! your Cappucino coffe is ready\n";
        }

        public String makeEsspresso()
        {
            if (!this.WaterGalon.isAvailable())
            {
                return "Sorry, the water is empty";
            }
            if (!this.CoffeePowder.isAvailable())
            {
                return "Sorry, the coffe is empty";
            }

            this.WaterGalon.makeOneCup();
            this.CoffeePowder.makeOneCup();
            return "Yey! your Esspresso coffe is ready\n";
        }

        public String checkAvailability()
        {
            return $"the water :{this.WaterGalon.getVolume()}, the coffe powder : {this.CoffeePowder.getNetto()} , and the milk : {this.CoffeeMilk.getIsi()}";
        }
    }
}
