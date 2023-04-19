using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Card cardOne = new Card();
            cardOne.Suit = "Queen";
            cardOne.Face = "Spades";

            Console.WriteLine("The card is " + cardOne.Suit + " of " + cardOne.Face);
        }
    }
}
