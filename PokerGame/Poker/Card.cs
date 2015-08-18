// Implement ICard interface to class Card
// Create method ToString based on class CardToStringTest
namespace Poker
{
    using System;

    public class Card : ICard
    {
        public Card(CardFace face, CardSuit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public CardFace Face { get; private set; }

        public CardSuit Suit { get; private set; }
        /// <summary>
        /// returns card's face and suit
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        { 
            string cardToString = string.Empty;
            if ((int)this.Face <= 10)
            {
                cardToString += (int)this.Face;
                cardToString += this.SuitToString();
                cardToString += " ";
            }
            else
            {
                cardToString += this.Face.ToString()[0];
                cardToString += this.SuitToString();
                cardToString += " ";
            }

            return cardToString;
        }
        /// <summary>
        /// returns card's suid
        /// </summary>
        /// <returns>string</returns>
        private string SuitToString()
        {
            string suitToString = string.Empty;
            switch (this.Suit)
            {
                case CardSuit.Clubs:
                    suitToString = "♣";
                    break;
                case CardSuit.Diamonds:
                    suitToString = "♦";
                    break;
                case CardSuit.Hearts:
                    suitToString = "♥";
                    break;
                case CardSuit.Spades:
                    suitToString = "♠";
                    break;
            }

            return suitToString;
        }
    }
}
