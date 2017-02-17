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
        }
    }
}
