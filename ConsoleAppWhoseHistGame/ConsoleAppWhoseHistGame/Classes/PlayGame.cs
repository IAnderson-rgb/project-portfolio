using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ConsoleAppWhoseHistGame.Models;


namespace ConsoleAppWhoseHistGame.Classes
{
    public class PlayGame
    {
        public Game User { get; set; }
        public string UserName { get; set; }
        /// <summary>
        /// Creates a new User by setting player info and time to play.
        /// </summary>
        /// <param name="seconds"> The seconds the player has to make a decision</param>
        /// <param name="isNewGameTrue"></param>
        /// <param name="playerName">Sets the name of the user for the User</param>
        public PlayGame(int seconds, bool isNewGameTrue, string playerName, Game oldUser = null)
        {
            User.Timer = seconds;
            User.IsNewGameTrue = isNewGameTrue;
            User.PlayerName = oldUser != null ? oldUser.PlayerName : playerName;
            UserName = playerName;
        }

        /// <summary>
        /// List populated with answers. Contains the Original order of text minus the year the event took place.
        /// List populated with player's guess for each scrambled word problem.
        /// </summary>

        /// <summary>
        /// Gives the date the user choses to play. Reads in historical data from a txt file based on the date given. Reverses the order of the word in the txt file. Creates an answers list of the original word order.
        /// </summary>
        /// <param name="selectedDate">Date chosen by the user eg..5-14 </param>
        public void Run(string selectedDate)
        {
            // create a timer to run
            string directory = Environment.CurrentDirectory;
            selectedDate += ".txt";
            string fullPath = Path.Combine(directory, selectedDate);

            //List<string> scrambledQuestion = new List<string>();

            try
            {
                using (StreamReader sr = new StreamReader(fullPath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        if (line != null)
                        {
                            User.Answers.Add(line.Remove(0, 6));
                            string[] phraseArray = line.Split(',');
                            Console.WriteLine();
                            Console.WriteLine(phraseArray[0]);
                            Console.WriteLine();
                            phraseArray = phraseArray.Skip(1).ToArray();
                            string[] reversedArray = phraseArray.Reverse<string>().ToArray();
                            // scramble remaining elements from phraseArray
                            foreach (var t in reversedArray)
                            {
                                //string[] resultArray;
                                Console.Write(
                                    $"{t},"); //This allows array of strings to print a single line of string elements to the console.
                            }
                        }

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine($"What is your guess {User.PlayerName}?");
                        string geuss = Console.ReadLine();
                        User.PlayerGuesses.Add(geuss);
                    }
                }

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message); 
            }


            try
            {


            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
