using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Game gameSession = new Game();
            Cup gameCup = new Cup();
            int numberOfDice = 5;
            int maxNumberOfRolls = 3;
            // gameSession.RollGameDie();
            // gameCup.RollGameDice(numberOfDice, maxNumberOfRolls);
            gameCup.RollGameDiceThreeTimes(numberOfDice, maxNumberOfRolls);
            Console.ReadLine();
        }
    }
}
