﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeGame
{
    public class Game
    {
        Random randomizer = new Random();
        GameDie die1 = new GameDie();
        //int numberOfDice = 5;
        //int maxNumberOfRolls = 3;

        public int RollGameDie()
        {           
            // Random randomizer = new Random();
            int roll = randomizer.Next(1, 7);
            die1.value = roll;
            Console.WriteLine("Die: " + die1.value);
            return roll;
        }

        
        public int[] RollGameDice(int numberOfDice)
        {
            
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
