using System;
using System.Collections.Generic;
using System.Text;

namespace TyrannyRocket
{
    public class Rocket
    {
        //Bränslet för en modul är dess massa delat med 3, avrundat nedåt, minus 2.
        public int CalculateFuelByMass(int mass)
        {
            var fuel = Math.Floor(mass / 3f) - 2;
            return (int)(fuel);
        }

        //What is the sum of the fuel requirements
        public int CalculateFuelRequirements(int mass)
        {
            //Calculate fuel for initial spacecraft mass
            var fuelAmountLeft = CalculateFuelByMass(mass);
            var totalFuel = fuelAmountLeft;

            //Calculate fuel requirements
            while (fuelAmountLeft > 0)
            {
                fuelAmountLeft = CalculateFuelByMass(fuelAmountLeft);

                if (fuelAmountLeft >= 0)
                    totalFuel += fuelAmountLeft;
            }

            return totalFuel;
        }
    }
}
