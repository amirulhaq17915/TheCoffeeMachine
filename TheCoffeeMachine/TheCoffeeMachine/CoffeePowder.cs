using System;
using System.Collections.Generic;
using System.Text;

namespace TheCoffeeMachine
{
    class CoffeePowder
    {
        private int netto = 0;
        private int oneCupCoffe = 25;

        public CoffeePowder(int netto)
        {
            this.netto = netto;
        }

        public Boolean isAvailable()
        {
            return this.netto >= this.oneCupCoffe;
        }

        public void makeOneCup()
        {
            this.netto = this.netto - oneCupCoffe;
        }

        public int getNetto()
        {
            return this.netto;
        }
    }
}
