using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppWhoseHistGame.Classes
{
    class Game
    {
        public string PlayerName { get; set; }
        public int Timer { get; private set; }
        public string Questions { get; private set; }
        public string InputAnswer { get; set; }
        public bool IsNewGameTrue { get; set; }
        public List<string> Answers { get; private set; }
        public List<string> PlayerGeusses { get; private set; }

        /// <summary>
        /// Creates a new game by setting player info and time to play.
        /// </summary>
        /// <param name="seconds"> The seconds the player has to make a decision</param>
        /// <param name="isNewGameTrue"></param>
        /// <param name="playerName">Sets the name of the user for the game</param>
        public Game(int seconds, bool isNewGameTrue, string playerName)
        {
            Timer = seconds;
            IsNewGameTrue = isNewGameTrue;
            PlayerName = playerName;
            Answers = answers;
            PlayerGeusses = playerGeusses;
        }
        /// <summary>
        /// List populated with answers. Contains the Original order of text minus the year the event took place.
        /// List populated with player's geuss for each scrambled word problem.
        /// </summary>
         private List<string> answers = new List<string>();
         private List<string> playerGeusses = new List<string>();
        /// <summary>
        /// Gives the date the user chosses to play. Reads in historical data from a txt file based on the date givin. Reverses the order of the word in the txt file. Creates an answers list of the original word order.
        /// </summary>
        /// <param name="selectedDate">Date chosen by the user eg..5-14 </param>
        public void PlayGame(string selectedDate = "")
        {// create a timer to run
            string directory = Environment.CurrentDirectory;
            selectedDate = selectedDate + ".txt";
            string fullPath = Path.Combine(directory, selectedDate);

            //List<string> scrambledQuestion = new List<string>();

            try
            {
                using (StreamReader sr = new StreamReader(fullPath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        answers.Add(line.Remove(0,6));
                        string[] phraseArray = line.Split(',');
                        Console.WriteLine();
                        Console.WriteLine(phraseArray[0]);
                        Console.WriteLine();
                        phraseArray = phraseArray.Skip(1).ToArray();
                        string[] reversedArray = phraseArray.Reverse<string>().ToArray();
                        // scramble remaining elements from phraseArray
                        for (int i = 0; i < reversedArray.Length; i++)
                        {
                            //string[] resultArray;
                            Console.Write($"{reversedArray[i]},"); //This allows array of strings to print a single line of string elements to the console.
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine($"What is your geuss {PlayerName}?");
                        string geuss = Console.ReadLine();
                        playerGeusses.Add(geuss);
                    }
                }

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message); 
            }
            
        }
    }
}
