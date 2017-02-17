using System.Collections.Generic;
using System;

namespace WordCounterApp
{
    public class WordCounter
    {
        private string _userOneInput;
        private string _userTwoInput;
        private string[] _userOneInputSplit;

        public WordCounter(string userOneInput, string userTwoInput)
        {
            _userOneInput = userOneInput;
            _userTwoInput = userTwoInput;
            _userOneInputSplit = userOneInput.Split(' ');
        }

        public string GetBoth()
        {
            string both = _userOneInput + ", " + _userTwoInput;
            return both;
        }

        public bool DoContains()
        {
            int index = Array.IndexOf(_userOneInputSplit, _userTwoInput);
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
            for (int i = 0; i < _userOneInputSplit.Length; i++)
            {
                if (_userOneInputSplit[i] == _userTwoInput)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
