using System.Collections.Generic;
using System;

namespace WordCounterApp
{
    public class WordCounter
    {
        private string _userOneInput;
        private string _userTwoInput;

        public WordCounter(string userOneInput, string userTwoInput)
        {
            _userOneInput = userOneInput;
            _userTwoInput = userTwoInput;
        }

        public string GetBoth()
        {
            string both = _userOneInput + ", " + _userTwoInput;
            return both;
        }

        public bool DoContains()
        {
            int index = Array.IndexOf(_userOneInput.Split(' '), _userTwoInput);
            bool booli = false;

            if (index > 0)
            {
                booli = true;
            }

            return booli;
        }

        public int HowManyContains()
        {
            int counter = 0;
            for (int i = 0; i < _userOneInput.Split(' ').Length; i++)
            {
                string newThing = _userOneInput.Split(' ')[i];
                if (newThing == _userTwoInput)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
