using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleAppWhoseHistGame.Classes;
using ConsoleAppWhoseHistGame.Models;
using ConsoleTables;
using Index = ConsoleAppWhoseHistGame.Classes.Index;

namespace ConsoleAppWhoseHistGame
{
    class Program
    {/// <summary>
     /// User starts by getting the title and rules from Index object if user chooses yes.
     /// </summary>
        static void Main()
        {
            Console.WindowWidth = 160;
            Index game = new Index();
            var table = new ConsoleTable("", game.Title, "", "\nPress any key to start");
            table.Write();
            //var rows = Enumerable.Repeat(new Game(), 10);
            //ConsoleTable
            //    .From<Game>(rows)
            //    .Configure(o => o.NumberAlignment = Alignment.Right)
            //    .Write(Format.Minimal);

            bool keepGameRunning = true;
            Console.ReadKey();

            //table.Write(game.Rules); //Empty space to center text.Need to add formatting.
            Console.WriteLine();
            Console.Clear();
            while (keepGameRunning)
            {
                Console.WriteLine("\n\nWould you like to start a new game player?: \n (1) Yes \n (2) No");
                bool isUserwrong = true;
                string userInput;
                string guestName = "Guest";
                string readyToPlay;
                bool isSelectedDateValid = true;
                string selectedDate;
                var inputIsValid = false;
                var exit = false;
                try
                {
                    while (!inputIsValid)
                    {
                        userInput = Console.ReadLine();
                        switch (userInput.ToLower())
                        {
                            case "yes":
                                inputIsValid = true;
                                exit = false;
                                break;
                            case "no":
                                inputIsValid = true;
                                exit = true;
                                break;
                            case "y":
                                inputIsValid = true;
                                exit = false;
                                break;
                            case "n":
                                inputIsValid = true;
                                exit = true;
                                break;
                            case "1":
                                inputIsValid = true;
                                exit = false;
                                break;
                            case "2":
                                inputIsValid = true;
                                exit = true;
                                break;
                            default:
                                inputIsValid = false;
                                exit = false;
                                break;
                        }
                        Console.WriteLine($"Your input is {(inputIsValid ? "valid!" : "not valid \n Please enter a valid response \n")}"); 
                    }


                    if (!exit)
                    {
                        userInput = "true";
                        bool isNewgame = bool.Parse(userInput);
                        Console.WriteLine();
                        Console.WriteLine("Choose your time: 30 seconds, 60 seconds, 120 seconds.");
                        int seconds = int.Parse(Console.ReadLine());

                        Console.WriteLine("Player name:  ");
                        string playerName = Console.ReadLine();
                        Console.WriteLine();

                        PlayGame newgame = new PlayGame(seconds, isNewgame, playerName);
                        //List<Results> answer = new List<Results>();
                        Console.WriteLine("Hello " + ((newgame.UserName == "") ? $"{guestName}!" : $"{newgame.UserName}!"));
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
                                    newgame.Run(selectedDate);
                                    Results answers = new Results(newgame);
                                    answers.GetPlayerResults();
                                    //Build additional game functionality here.
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("We're so sorry and wish you could play! :( ");
                        Console.WriteLine("HAVE A NICE DAY!");
                        Console.ReadKey();
                        //if(keepGameRunning == true) //exit
                        //else PlayGame.Run(_Game);
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
