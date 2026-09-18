using System;
using System.Collections.Generic;
using System.Text;

namespace Elves
{
    public class ElfTranslator
    {
        private int _streak;
        private char _currentChar;


        private readonly char _defaultChar = ' ';
        private bool _isDefaultChar => _currentChar == _defaultChar;


        public string Translate(string input)
        {
            var charArray = input.ToCharArray();
            var sequence = "";

            _currentChar = _defaultChar;

            for (int i = 0; i < charArray.Length; i++)
            {
                // Set char to match against later
                if (_isDefaultChar)
                {
                    _currentChar = charArray[i];
                    _streak++;
                }

                // IF last step in array OR char array is only one. (Prevent out of bounds)
                if (i == charArray.Length - 1 || charArray.Length == 1)
                {
                    return sequence += $"{_streak}{_currentChar}";
                }

                // See if next char is the same as current

                if (_currentChar == charArray[i + 1])
                {
                    _streak++;
                }
                else
                {
                    sequence += $"{_streak}{_currentChar}";

                    _currentChar = _defaultChar;
                    _streak = 0;
                }
            }

            return sequence;

        }



    }
}
