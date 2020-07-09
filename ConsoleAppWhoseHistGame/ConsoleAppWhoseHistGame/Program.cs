using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleAppWhoseHistGame.Classes;
namespace ConsoleAppWhoseHistGame
{
    class Program
    {/// <summary>
     /// Game starts by getting the title and rules from index object if user chooses yes.
     /// </summary>
        static void Main()
        {
            index game = new index();
            Console.WindowWidth = 160;
            Console.WriteLine("\n\n");
            Console.WriteLine("                                                                 Press Any Key To Start"); //Empty space to center text.Need to add formatting.
            Console.WriteLine();
            foreach (string line in game.Title)
                Console.WriteLine("                                            " + line); //Empty space to center text.Need to add formatting.
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("                                                               " + game.Rules); //Empty space to center text.Need to add formatting.
            Console.WriteLine();
            bool keepGameRunning = true;
            while (keepGameRunning)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Would you like to start a new game player?: Yes/No");
                bool isUserwrong = true;
                string input = "";
                string playAsGuest = "Guest";
                string readyToPlay = "";
                bool isSelectedDateValid = true;
                string selectedDate = "";
                try
                {
                    while (isUserwrong)
                    {
                        input = Console.ReadLine();
                        isUserwrong = input.ToLower() == "yes" || input.ToLower() == "no" ? false : true;
                        Console.WriteLine("Your input is " + ((input.ToLower() == "yes" || input.ToLower() == "no") ? "valid!" : "not valid. Please enter a valid response: Yes/No"));
                    }
                    if (input.ToLower() == "yes")
                    {
                        input = "true";
                        bool isNewgame = bool.Parse(input);
                        Console.WriteLine();
                        Console.WriteLine("Choose your time: 30 seconds, 60 seconds, 120 seconds.");
                        int seconds = int.Parse(Console.ReadLine());

                        Console.WriteLine("Player name:  ");
                        string playerName = Console.ReadLine();
                        Console.WriteLine();

                        Game newgame = new Game(seconds, isNewgame, playerName);
                        //List<Results> answer = new List<Results>();
                        Console.WriteLine("Hello " + ((playerName == "") ? $"{playAsGuest}!" : $"{newgame.PlayerName}!"));
                        Console.WriteLine("Are You Ready to Play!: Yes/No");
                        isUserwrong = true;
                        while (isUserwrong)
                        {
                            Console.WriteLine();
                            readyToPlay = Console.ReadLine();
                            isUserwrong = readyToPlay.ToLower() == "yes" || readyToPlay.ToLower() == "no" ? false : true;
                            Console.WriteLine("Your input is " + ((readyToPlay.ToLower() == "yes" || readyToPlay.ToLower() == "no") ? "valid!" : "not valid. Please enter a valid response: Yes/No"));

                            if (readyToPlay.ToLower() == "yes")
                            {
                                Console.WriteLine();
                                Console.Clear();
                                Console.WriteLine("Great! What date would you like to play?");
                                Console.WriteLine("(Please type one of the following dates: 5-14 | 5-15 | 5-16 ..must be this exact format without the year.)");

                                while (isSelectedDateValid)
                                {
                                    selectedDate = Console.ReadLine();
                                    isSelectedDateValid = selectedDate.Contains("5-14") || selectedDate.Contains("5-15") || selectedDate.Contains("5-16") ? false : true;
                                    Console.WriteLine("Your input is " + ((selectedDate.Contains("5-14") || selectedDate.Contains("5-15") || selectedDate.Contains("5-16")) ? "valid!" : "not valid. Please enter a valid response: 5-14 | 5-15 | 5-16"));
                                    Console.WriteLine();
                                    Console.Clear();
                                    newgame.PlayGame(selectedDate);
                                    string[] arrAnswers = newgame.Answers.ToArray();
                                    string[] arrGuesses = newgame.PlayerGeusses.ToArray();
                                    Results answers = new Results(arrAnswers, arrGuesses);
                                    answers.GetPlayerResults();
                                    //Build additional game functionality here.
                                }
                            }
                        }
                    }
                    else if (input.ToLower() == "no")
                    {
                        Console.WriteLine();
                        Console.WriteLine("We're so sorry and wish you could play! :( ");
                        Console.WriteLine("HAVE A NICE DAY!");
                    }


                }
                catch (Exception e)
                {
                    Console.WriteLine("An error has occured");
                    Console.WriteLine(e);
                    Console.WriteLine();
                    Console.WriteLine("|Press Q then Enter quit the game || Press Enter to restart game|");
                    string response = Console.ReadLine();
                    keepGameRunning = response.ToLower() == "q" ? false : true;
                }
            }
        }
    }
}
