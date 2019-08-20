using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeGame
{
    class Game
    {
        public int RollGameDie()
        {
            GameDie die1 = new GameDie();
            Random randomizer = new Random();
            int roll = randomizer.Next(1, 6);
            die1.value = roll;
            Console.WriteLine("Die: " + die1.value);
            return roll;
        }

        
        public int[] RollGameDice()
        {
            int numberOfDice = 5;
            int[] cup = new int[numberOfDice];
            Random randomizer = new Random();
           
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
    }
}
