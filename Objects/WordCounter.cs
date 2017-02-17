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
    }
}
