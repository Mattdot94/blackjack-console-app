using System;

namespace Practice
{
    class Program
    {
        public static int PlayerScore { get; private set; } = 0;
        public static int GamesPlayed { get; private set; } = 0;
        public static Outcome Outcome { get; set; }
        static void Main()
        {
            Game NewGame = new Game();

            Console.WriteLine($"Welcome to Blackjack");
            Console.WriteLine("----------------------------\n");
            
            Player Player1 = new Player();
            Player Player2 = new Player("Dealer");

            while (true)
            {
                Console.Clear();
                Outcome = NewGame.PlayRound(Player1, Player2);

                GamesPlayed++;

                if (Outcome == Outcome.win)
                {
                    PlayerScore++;
                }

                Console.WriteLine($"\nYou have won {PlayerScore} hands out of the {GamesPlayed} hands you've played so far");
                Console.Write("Would you like to play another hand? : ");
                string input = Console.ReadLine();

                if (input.ToUpper() == "Y" || input.ToUpper() == "YES" || input == "")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(@"Dealer: ""Thanks for playing""");
                    break;
                }
            }
        }
    }
}
