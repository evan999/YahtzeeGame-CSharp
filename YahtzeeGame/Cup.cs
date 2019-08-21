using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeGame
{
    public class Cup
    {
        Random randomizer = new Random();

        public int[] RollGameDice(int numberOfDice, int numberOfRolls)
        {
            int[] cup = new int[numberOfDice];
            // Random randomizer = new Random();

            //var cup = new List<GameDie>();

            for (int dice = 0; dice < numberOfDice; dice++)
            {
                cup[dice] = randomizer.Next(1, 7);
                Console.WriteLine("Die: " + cup[dice].ToString());
                //string name = "die" + dice.ToString();
                //cup.Add(new GameDie());    
            }
            return cup;
        }

        public int[,] RollGameDiceThreeTimes(int numberOfDice, int numberOfRolls)
        {
            int[,] rolls = new int[numberOfDice,numberOfRolls];

            for (int roll = 0; roll < numberOfRolls; roll++)
            {
                for (int die = 0; die < numberOfDice; die++)
                {
                    rolls[roll,die] = randomizer.Next(1, 7);
                    
                }
            }
            return rolls;

        }
    }
}
