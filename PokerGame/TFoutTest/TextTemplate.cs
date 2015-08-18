
namespace: TextTemplate
{
	using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Poker;

    public class StartProgram
    {
        static void Main()
        {
                            Console.WriteLine(new Card(RandomEnum.Of<CardFace>(), RandomEnum.Of<CardSuit>()).ToString());
                            Console.WriteLine(new Card(RandomEnum.Of<CardFace>(), RandomEnum.Of<CardSuit>()).ToString());
                            Console.WriteLine(new Card(RandomEnum.Of<CardFace>(), RandomEnum.Of<CardSuit>()).ToString());
                            Console.WriteLine(new Card(RandomEnum.Of<CardFace>(), RandomEnum.Of<CardSuit>()).ToString());
                            Console.WriteLine(new Card(RandomEnum.Of<CardFace>(), RandomEnum.Of<CardSuit>()).ToString());
                            Console.WriteLine(new Card(RandomEnum.Of<CardFace>(), RandomEnum.Of<CardSuit>()).ToString());
                            Console.WriteLine(new Card(RandomEnum.Of<CardFace>(), RandomEnum.Of<CardSuit>()).ToString());
                            Console.WriteLine(new Card(RandomEnum.Of<CardFace>(), RandomEnum.Of<CardSuit>()).ToString());
                            Console.WriteLine(new Card(RandomEnum.Of<CardFace>(), RandomEnum.Of<CardSuit>()).ToString());
                            Console.WriteLine(new Card(RandomEnum.Of<CardFace>(), RandomEnum.Of<CardSuit>()).ToString());
                    }
    }

    public static class RandomEnum
    {
        private static Random _Random = new Random(Environment.TickCount);

        public static T Of<T>()
        {
            if (!typeof(T).IsEnum)
                throw new InvalidOperationException("Must use Enum type");

            Array enumValues = Enum.GetValues(typeof(T));
            return (T)enumValues.GetValue(_Random.Next(enumValues.Length));
        }
    }
}