using System;
using System.Collections.Generic;
using System.Text;

namespace Elves
{
    public class ElfTranslator
    {
        public string Translate(string input)
        {
            var charachters = input.ToCharArray();
            var currentChar = "";
            int amountInARow = 0;

            string total = "";

            for(int current = 0; current < charachters.Length; current++)
            {
                // Set new char
                if(currentChar == "")
                {
                    currentChar = charachters[current].ToString();
                    amountInARow++;
                }
                
                //Next char is a match
                if(currentChar == charachters[current + 1].ToString())
                {
                    amountInARow++;
                }
                else
                {
                    
                }
                return "GÖR KLART METODEN FÖRST";


            }
        }
    }
}
