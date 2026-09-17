using System;
using System.Collections.Generic;
using System.Text;

namespace NotQuiteLisp
{
    public class Stairs
    {
        public int GetFloor(string values) 
        {
            var steps = values.ToCharArray();

            int stepsUp = 0;
            int stepsDown = 0;

            foreach (var step in steps) 
            {
                if (step == '(') stepsUp++;
                else if(step == ')') stepsDown++;
            }

            var floor = stepsUp - stepsDown;
            return floor;
        }
    }
}
