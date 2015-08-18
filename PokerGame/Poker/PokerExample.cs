namespace Poker
{
    using System;
    using System.Collections.Generic;
    using log4net;
    using log4net.Config;

    public class PokerExample
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(PokerExample));

        public static void Main()
        {
            XmlConfigurator.Configure();
            Log.Info("Info logging");
            try
            {
                ICard card = new Card(CardFace.Ace, CardSuit.Clubs);
                Console.WriteLine(card);
                IHand hand = new Hand(new List<ICard>() 
                {
                    new Card(CardFace.Ace, CardSuit.Clubs),
                    new Card(CardFace.Jack, CardSuit.Diamonds),
                    new Card(CardFace.King, CardSuit.Hearts),
                    new Card(CardFace.Ten, CardSuit.Spades),
                    new Card(CardFace.Queen, CardSuit.Diamonds),
                });

                Console.WriteLine(hand);
                IPokerHandsChecker checker = new PokerHandsChecker();
                Console.WriteLine("Valid hand? : {0}", checker.IsValidHand(hand));
                Console.WriteLine("Is Straight : {0}", checker.IsStraight(hand));
                Console.WriteLine("Is one pair : {0}", checker.IsOnePair(hand));
                Console.WriteLine("Is two pair : {0}", checker.IsTwoPair(hand));
            }
            catch (Exception e)
            {
                Log.Error("This is my error", e);
            }
        }
    }
}
