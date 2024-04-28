using System;
using System.Linq;

namespace Solution
{
    public partial class Kata
    {
        public static string DefineSuit(string card)
        {
            return card.Last() switch
            {
                '♣' => "clubs",
                '♦' => "diamonds",
                '♥' => "hearts",
                '♠' => "spades",
                _ => ""
            };

            // Alternative
            // return card[^1] switch
            // {
            //     '♣' => "clubs",
            //     '♦' => "diamonds",
            //     '♥' => "hearts",
            //     '♠' => "spades"
            // };
        }

        public static void Main()
        {
            Console.WriteLine(DefineSuit("3♣"));
        }
    }
}