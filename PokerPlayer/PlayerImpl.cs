using System.Threading;

namespace PokerPlayer
{
    using PokerPlayer.Generated;

    public class PlayerImpl
    {
        private const string TeamName = "NancyLovers";

        public const string Version = "0.1";

        public string Check()
        {
            return string.Concat("I am running! My team: ", TeamName);
        }

        public void Showdown(Rootobject gameState)
        {

        }

        public int BetRequest(Rootobject gameState)
        {
            Thread.Sleep(2000);
            return 0;
        }
    }
}