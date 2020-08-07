using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ConsoleAppWhoseHistGame.Models
{
    public class Game
    {
        [DisplayName("Name")]
        public string PlayerName { get; set; }
        public int Timer { get; set; }
        public string Questions { get; set; }
        public string InputAnswer { get; set; }
        public bool IsNewGameTrue { get; set; }
        public List<string> Answers { get; set; }
        public List<string> PlayerGuesses { get; set; }
    }
}
