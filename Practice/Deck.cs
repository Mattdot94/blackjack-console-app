using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Deck
    {
        public List<Card> cardList { get; }

        public Deck()
        {
            cardList = InitialiseDeck();
        }

        protected static List<Card> InitialiseDeck()
        {
            Card twoOfSpades = new Card("Two", "Spades", 2);
            Card threeOfSpades = new Card("Three", "Spades", 3);
            Card fourOfSpades = new Card("Four", "Spades", 4);
            Card fiveOfSpades = new Card("Five", "Spades", 5);
            Card sixOfSpades = new Card("Six", "Spades", 6);
            Card sevenOfSpades = new Card("Seven", "Spades", 7);
            Card eightOfSpades = new Card("Eight", "Spades", 8);
            Card nineOfSpades = new Card("Nine", "Spades", 9);
            Card tenOfSpades = new Card("Ten", "Spades", 10);
            Card jackOfSpades = new Card("Joker", "Spades", 10);
            Card queenOfSpades = new Card("Queen", "Spades", 10);
            Card kingOfSpades = new Card("King", "Spades", 10);
            Card aceOfSpades = new Card("Ace", "Spades", 11);


            Card twoOfClubs = new Card("Two", "Clubs", 2);
            Card threeOfClubs = new Card("Three", "Clubs", 3);
            Card fourOfClubs = new Card("Four", "Clubs", 4);
            Card fiveOfClubs = new Card("Five", "Clubs", 5);
            Card sixOfClubs = new Card("Six", "Clubs", 6);
            Card sevenOfClubs = new Card("Seven", "Clubs", 7);
            Card eightOfClubs = new Card("Eight", "Clubs", 8);
            Card nineOfClubs = new Card("Nine", "Clubs", 9);
            Card tenOfClubs = new Card("Ten", "Clubs", 10);
            Card jackOfClubs = new Card("Jack", "Clubs", 10);
            Card queenOfClubs = new Card("Queen", "Clubs", 10);
            Card kingOfClubs = new Card("King", "Clubs", 10);
            Card aceOfClubs = new Card("Ace", "Clubs", 11);

            Card twoOfHearts = new Card("Two", "Hearts", 2);
            Card threeOfHearts = new Card("Three", "Hearts", 3);
            Card fourOfHearts = new Card("Four", "Hearts", 4);
            Card fiveOfHearts = new Card("Five", "Hearts", 5);
            Card sixOfHearts = new Card("Six", "Hearts", 6);
            Card sevenOfHearts = new Card("Seven", "Hearts", 7);
            Card eightOfHearts = new Card("Eight", "Hearts", 8);
            Card nineOfHearts = new Card("Nine", "Hearts", 9);
            Card tenOfHearts = new Card("Ten", "Hearts", 10);
            Card jackOfHearts = new Card("Jack", "Hearts", 10);
            Card queenOfHearts = new Card("Queen", "Hearts", 10);
            Card kingOfHearts = new Card("King", "Hearts", 10);
            Card aceOfHearts = new Card("Ace", "Hearts", 11);

            Card twoOfDiamonds = new Card("Two", "Diamonds", 2);
            Card threeOfDiamonds = new Card("Three", "Diamonds", 3);
            Card fourOfDiamonds = new Card("Four", "Diamonds", 4);
            Card fiveOfDiamonds = new Card("Five", "Diamonds", 5);
            Card sixOfDiamonds = new Card("Six", "Diamonds", 6);
            Card sevenOfDiamonds = new Card("Seven", "Diamonds", 7);
            Card eightOfDiamonds = new Card("Eight", "Diamonds", 8);
            Card nineOfDiamonds = new Card("Nine", "Diamonds", 9);
            Card tenOfDiamonds = new Card("Ten", "Diamonds", 10);
            Card jackOfDiamonds = new Card("Jack", "Diamonds", 10);
            Card queenOfDiamonds = new Card("Queen", "Diamonds", 10);
            Card kingOfDiamonds = new Card("King", "Diamonds", 10);
            Card aceOfDiamonds = new Card("Ace", "Diamonds", 11);

            List<Card> myDeck = new List<Card>
            {
                twoOfSpades,
                threeOfSpades,
                fourOfSpades,
                fiveOfSpades,
                sixOfSpades,
                sevenOfSpades,
                eightOfSpades,
                nineOfSpades,
                tenOfSpades,
                jackOfSpades,
                queenOfSpades,
                kingOfSpades,
                aceOfSpades,

                twoOfClubs,
                threeOfClubs,
                fourOfClubs,
                fiveOfClubs,
                sixOfClubs,
                sevenOfClubs,
                eightOfClubs,
                nineOfClubs,
                tenOfClubs,
                jackOfClubs,
                queenOfClubs,
                kingOfClubs,
                aceOfClubs,

                twoOfHearts,
                threeOfHearts,
                fourOfHearts,
                fiveOfHearts,
                sixOfHearts,
                sevenOfHearts,
                eightOfHearts,
                nineOfHearts,
                tenOfHearts,
                jackOfHearts,
                queenOfHearts,
                kingOfHearts,
                aceOfHearts,

                twoOfDiamonds,
                threeOfDiamonds,
                fourOfDiamonds,
                fiveOfDiamonds,
                sixOfDiamonds,
                sevenOfDiamonds,
                eightOfDiamonds,
                nineOfDiamonds,
                tenOfDiamonds,
                jackOfDiamonds,
                queenOfDiamonds,
                kingOfDiamonds,
                aceOfDiamonds
            };
            return myDeck;
        }
    }
}