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

        public string GetTwo()
        {
            return _userTwoInput;
        }

        public string GetOne()
        {
            return _userOneInput;
        }

        public bool DoContains()
        {
            // int index = Array.IndexOf(_userOneInputSplit, _userTwoInput); , part of old code (see comment below for more details)
            bool booli = false;

            if (HowManyContains() > 0)
            // if (index > 0) was replaced by ^, old still works
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
