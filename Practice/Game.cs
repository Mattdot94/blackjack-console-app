using System;
using System.Collections.Generic;

namespace Practice
{
    class Game
    {
        public Outcome outcome { get; private set; } = Outcome.inProgress;
        public readonly static Random Random = new Random();
        private Deck Deck = new Deck();
        private int Blackjack = 21;
        private Card DealerHiddenCard;

        public Outcome PlayRound(Player player, Player dealer)
        {
            player.HasAce = false;
            dealer.HasAce = false;
            player.Points = 0;
            dealer.Points = 0;
            outcome = Outcome.inProgress;
            Deck = new Deck();

            GameStart(player);
            Console.WriteLine("====================================="); 
            GameStart(dealer);

            Console.WriteLine($"\n{player.Name} is up to {player.Points} points");

            PlayerTurn(player);

            if (outcome == Outcome.loss)
            {
                return outcome;
            }
            else
            {
                Console.WriteLine($"Dealer flips over his 2nd card to reveal {DealerHiddenCard.Name} of {DealerHiddenCard.Suite} | { dealer.Points }");
                DealerTurn(player, dealer);
            }

            return outcome = GameEnd(player, dealer);
        }
        private void GameStart(Player player)
        {
            if (player.Name == "Dealer")
            {
                Card Draw = DrawCard();
                Card Draw2 = DrawCard();
                DealerHiddenCard = Draw2;

                Console.WriteLine($"Dealer draws himself a {Draw.Name} of {Draw.Suite}");
                Console.WriteLine($"Dealer places his second draw faced down");

                if (Draw.Name == "Ace" || Draw2.Name == "Ace")
                {
                    player.HasAce = true;
                }
                else if (player.HasAce && Draw.Name == "Ace")
                {
                    player.Points -= 10;
                }
                
                player.Points = Draw.Points + Draw2.Points;
            }
            else
            {
                for (int i = 0; i < 2; i++)
                {
                    Card Draw = DrawCard();
                    Console.WriteLine($"Dealer places down a {Draw.Name} of {Draw.Suite}");

                    if (Draw.Name == "Ace")
                    {
                        player.HasAce = true;
                    }
                    else if (player.HasAce && Draw.Name == "Ace")
                    {
                        player.Points -= 10;
                    }
                    player.Points += Draw.Points;
                }
            }
        }
        private Outcome GameEnd(Player player, Player dealer)
        {
            if (dealer.Points > 21)
            {
                Console.WriteLine("Dealer bust!");
                outcome = Outcome.win;
                return outcome;
            }
            else if (player.Points > dealer.Points)
            {
                Console.WriteLine($"You win the hand!");
                outcome = Outcome.win;
                return outcome;
            }
            else if (player.Points == dealer.Points)
            {
                Console.WriteLine("Standoff!");
                return outcome;
            }
            else
            {
                Console.WriteLine("Dealer wins the hand");
                outcome = Outcome.loss;
                return outcome;
            }
        }
        private void PlayerTurn(Player player)
        {
            while (true)
            {
                if (player.Points == Blackjack)
                {
                    Console.WriteLine("you got Blackjack!");
                    outcome = Outcome.win;
                    break;
                }

                Console.Write("Do you wish to hit or stand? : ");
                string input = Console.ReadLine();
                Console.WriteLine();

                if (input.ToLower() == "hit")
                {
                    Card nextDraw = DrawCard();
                    Deck.cardList.Remove(nextDraw);
                    player.Points += nextDraw.Points;

                    Console.WriteLine($"Dealer places down a {nextDraw.Name} of {nextDraw.Suite} totalling your points to: {player.Points}");

                    if (player.Points > Blackjack && nextDraw.Name == "Ace")
                    {
                        player.Points -= 10;
                        Console.WriteLine($"The Ace reverts to a score of 1, giving you {player.Points} points");
                        continue;
                    }
                    else if (player.Points > Blackjack && player.HasAce)
                    {
                        player.HasAce = false;
                        player.Points -= 10;
                        Console.WriteLine($"Your Ace reverts to a score of 1, giving you {player.Points} points");
                        continue;
                    }
                    else if (player.Points > Blackjack)
                    {
                        Console.WriteLine("You bust!");
                        outcome = Outcome.loss;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }

                else if (input.ToLower() == "stand" || input.ToLower() == "stay")
                {
                    Console.WriteLine($"{player.Name} chooses to stand with {player.Points} points\n");
                    break;
                }

                else
                {
                    Console.WriteLine("please select either hit/stand");
                    continue;
                }
            }
        }
        private void DealerTurn(Player player, Player dealer)
        {
            while (true)
            {
                if (dealer.Points < player.Points)
                {
                    Card dealerDraw = DrawCard();
                    Deck.cardList.Remove(dealerDraw);
                    dealer.Points += dealerDraw.Points;
                    Console.WriteLine($"Dealer draws {dealerDraw.Name} of {dealerDraw.Suite} | { dealer.Points }");

                    if (dealer.Points > Blackjack && dealerDraw.Name == "Ace")
                    {
                        dealer.Points -= 10;
                        Console.WriteLine($"Ace reverts to a score of 1, giving dealer {dealer.Points} points");
                        continue;
                    }
                    else if (dealer.Points > Blackjack && dealer.HasAce)
                    {
                        dealer.HasAce = false;
                        dealer.Points -= 10;
                        Console.WriteLine($"Ace reverts to a score of 1, giving dealer {dealer.Points} points");
                        continue;
                    }
                    else if (dealer.Points > Blackjack)
                    {
                        break;
                    }
                }

                else if (dealer.Points == Blackjack)
                {
                    Console.WriteLine("Dealer has Blackjack!");
                    break;
                }

                else
                {
                    Console.WriteLine($"Dealer stays with {dealer.Points} points.");
                    break;
                }
            }
        }
        private Card DrawCard()
        {
            Card draw = Deck.cardList[Random.Next(Deck.cardList.Count)];
            Deck.cardList.Remove(draw);
            return draw;
        }
    }
}