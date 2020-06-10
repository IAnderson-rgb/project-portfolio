using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppWhoseHistGame.Classes
{
    class Results
    {
        public string[] Correct { get; private set; }
        public string[] Wrong { get; private set; }

        public Results()
        {
            var correct = new[]
            {
              @"### ### #     #                                                                                                                                  ### ### ### ### ###",
              @"### ###  #   #   ####  #    # #####       ##   #    #  ####  #    # ###### #####     #  ####      ####   ####  #####  #####  ######  ####  ##### ### ### ### ### ###",
              @" #   #    # #   #    # #    # #    #     #  #  ##   # #      #    # #      #    #    # #         #    # #    # #    # #    # #      #    #   #   ### ### ###  #   #",
                         @"#    #    # #    # #    #    #    # # #  #  ####  #    # #####  #    #    #  ####     #      #    # #    # #    # #####  #        #    #   #   #",
                         @"#    #    # #    # #####     ###### #  # #      # # ## # #      #####     #      #    #      #    # #####  #####  #      #        #",
                         @"#    #    # #    # #   #     #    # #   ## #    # ##  ## #      #   #     # #    #    #    # #    # #   #  #   #  #      #    #   #   ### ### ###",
                         @"#     ####   ####  #    #    #    # #    #  ####  #    # ###### #    #    #  ####      ####   ####  #    # #    # ######  ####    #   ### ### ###",
            };

            var wrong = new[]
            {
              @"### ###  #####                                                                                                                                                       ### ### ###",
              @"### ### #     #  ####  #####  #####  #   #        #   #  ####  #    # #####      ####  #    # ######  ####   ####     #  ####     #    # #####   ####  #    #  ####  ### ### ###",
               @"#   #  #       #    # #    # #    #  # #          # #  #    # #    # #    #    #    # #    # #      #      #         # #         #    # #    # #    # ##   # #    # ###  #   #",
                      @" #####  #    # #    # #    #   #            #   #    # #    # #    #    #      #    # #####   ####   ####     #  ####     #    # #    # #    # # #  # #       #",
                        @"    # #    # #####  #####    #   ###      #   #    # #    # #####     #  ### #    # #           #      #    #      #    # ## # #####  #    # #  # # #  ###",
                      @"#     # #    # #   #  #   #    #   ###      #   #    # #    # #   #     #    # #    # #      #    # #    #    # #    #    ##  ## #   #  #    # #   ## #    # ###",
                      @" #####   ####  #    # #    #   #    #       #    ####   ####  #    #     ####   ####  ######  ####   ####     #  ####     #    # #    #  ####  #    #  ####  ###",
            };

            Correct = correct;
            Wrong = wrong;
        }
        //Create a method that takes a list of players answers and compares them to the original answer.
        //may need to create a method to be called that makes the comparison.

        //Create message to write player right or plyaer wrong to the console.

        //Create a try again option, a start over option, and a quit game option.
    }
}
