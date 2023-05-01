using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public struct Card
    {
        public string Face { set; get; }
        public string Suit { set; get; }
    }
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades      
    }
    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
