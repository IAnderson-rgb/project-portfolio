using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppWhoseHistGame.Classes
{
    class Results
    {
        public string[] Correct { get; private set; }
        public string[] Wrong { get; private set; }
        public List<string> Answers { get; private set; }
        public List<string> PlayerGeusses { get; private set; }

        public Results(string[] arrAnswers, string[] arrGuesses)
        {
            var correct = new[]
            {
              @"╦ ╦┌─┐┬ ┬┬─┐  ╔═╗┌┐┌┌─┐┬ ┬┌─┐┬─┐┌─┐  ╔═╗┬─┐┌─┐  ╔═╗┌─┐┬─┐┬─┐┌─┐┌─┐┌┬┐┬",
              @"╚╦╝│ ││ │├┬┘  ╠═╣│││└─┐│││├┤ ├┬┘└─┐  ╠═╣├┬┘├┤   ║  │ │├┬┘├┬┘├┤ │   │ │",
              @" ╩ └─┘└─┘┴└─  ╩ ╩┘└┘└─┘└┴┘└─┘┴└─└─┘  ╩ ╩┴└─└─┘  ╚═╝└─┘┴└─┴└─└─┘└─┘ ┴ o",
            };

            var wrong = new[]
            {
              @"╔═╗┌─┐┬─┐┬─┐┬ ┬  ╦ ╦┌─┐┬ ┬┬─┐  ╔═╗┬ ┬┌─┐┌─┐┌─┐  ╦┌─┐  ╦ ╦┬─┐┌─┐┌┐┌┌─┐┬",
              @"╚═╗│ │├┬┘├┬┘└┬┘  ╚╦╝│ ││ │├┬┘  ║ ╦│ │├┤ └─┐└─┐  ║└─┐  ║║║├┬┘│ │││││ ┬│",
              @"╚═╝└─┘┴└─┴└─ ┴┘   ╩ └─┘└─┘┴└─  ╚═╝└─┘└─┘└─┘└─┘  ╩└─┘  ╚╩╝┴└─└─┘┘└┘└─┘o",
            };

            Correct = correct;
            Wrong = wrong;
            this.Answers = arrAnswers.ToList();
            this.PlayerGeusses = arrGuesses.ToList();
        }

        public string[] GetPlayerResults()
        {
            string ansResult = "";
            string guessResult = "";
            foreach (string line in Answers) 
            {
                ansResult = line.ToString();
            }
            foreach (string line in PlayerGeusses)
            {
                guessResult = line.ToString();
            }
            if (ansResult == guessResult)
            {
                Console.WindowWidth = 160;
                Console.WriteLine("\n\n");
                Console.WriteLine();
                foreach (string line in Correct)
                    Console.WriteLine(line);
                return Correct;
            }
            else
            {
                Console.WindowWidth = 160;
                Console.WriteLine("\n\n");
                Console.WriteLine();
                foreach (string line in Wrong)
                    Console.WriteLine(line);
                return Wrong;
            }
            //return result;
        }

        //Create a method that takes a list of players answers and compares them to the original answer.
        //may need to create a method to be called that makes the comparison.

        //Create message to write player right or plyaer wrong to the console.

        //Create a try again option, a start over option, and a quit game option.
    }
}
