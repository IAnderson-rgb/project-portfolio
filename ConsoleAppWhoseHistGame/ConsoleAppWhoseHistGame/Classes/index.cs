using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppWhoseHistGame.Classes
{
    class index
    {
        public string[] Title { get; private set; }
        public string Rules { get; private set; }
        public bool StartNewIsTrue { get; private set; }


       public index()
        { //ASCII art font Calvin S
            var arr = new[]
          {
                @"╦ ╦┬ ┬┌─┐┌─┐┌─┐  ╦ ╦┬┌─┐┌┬┐┌─┐┬─┐┬ ┬  ╦┌─┐  ┬┌┬┐  ╔═╗┌┐┌┬ ┬┬ ┬┌─┐┬ ┬┬",
                @"║║║├─┤│ │└─┐├┤   ╠═╣│└─┐ │ │ │├┬┘└┬┘  ║└─┐  │ │   ╠═╣│││└┬┘│││├─┤└┬┘│",
                @"╚╩╝┴ ┴└─┘└─┘└─┘  ╩ ╩┴└─┘ ┴ └─┘┴└─ ┴   ╩└─┘  ┴ ┴   ╩ ╩┘└┘ ┴ └┴┘┴ ┴ ┴ o",
            };
            Title = arr;

            string rules ="Rules - UNDER CONSTRUCTION!";
            Rules = rules;
        }
    }
}
