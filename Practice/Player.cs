using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Player : IPerson
    {
        public string Name { get; }
        public int Points { get; set; } = 0;
        public bool HasAce { get; set; }

        public Player()
        {
            Name = GetPlayerName();
        }

        public Player(string botName)
        {
            Name = botName;
        }

        private static string GetPlayerName()
        {
            string userInput;
            string nameOutput;

            while (true)
            {
                Console.Write("You take a seat at the table.\nThe dealer asks your name: ");
                userInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Please enter a valid name: ");
                    continue;
                }

                else if (userInput.Length <= 2 || userInput.Length> 20)
                {
                    Console.WriteLine("Please enter 3 or more characters up to a limit of 20");
                    continue;
                }
                else
                {
                    nameOutput = userInput.Substring(0, 1).ToUpper() + userInput.Substring(1, userInput.Length-1);
                    Console.Write($"Dealer: Welcome to my table {nameOutput}!\nPress enter to begin..."); 
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
            }
            return nameOutput;
        }
    }
}
