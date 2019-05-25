using System;

namespace BridgeCard
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input black:");
            var blackCards = Console.ReadLine();
            Console.WriteLine("Input white:");
            var whiteCards = Console.ReadLine();
            var common = new Common(blackCards,whiteCards);
            Console.WriteLine(common.GetResult());
        }
    }
}