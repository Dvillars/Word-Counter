using Nancy;
using System.Collections.Generic;
using System;
using System.IO;
using WordCounterApp;

namespace WordCounterApp
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ =>
            {
                return View["index.cshtml"];
            };

            Post["/result"] = _ =>
            {
                string inputOne = Request.Form["input-one"];
                string inputTwo = Request.Form["input-two"];

                WordCounter newWordCounter = new WordCounter(inputOne, inputTwo);
                return View["result.cshtml", newWordCounter];
            };
        }
    }
}
