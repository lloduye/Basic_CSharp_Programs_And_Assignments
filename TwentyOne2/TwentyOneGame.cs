using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOne() : Game, IWalkAway
    {
        public override void Play()
        {
        throw new NotImplementedException();
        }
        public override void ListPlayers()
        {
        console.WriteLine("21 Players:");
        base.ListPlayers();
        }
        public void WalkAway(Player player)
        {
        throw new NotImplementedException();
        }
    }
}
