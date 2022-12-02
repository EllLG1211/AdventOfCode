using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    public abstract class AbstractRound
    {
        protected static readonly char[] opponentValues = { 'A', 'B', 'C' };
        protected static readonly char[] playerValues = { 'X', 'Y', 'Z' };

        protected readonly char Opponent;
        protected readonly char Player;

        public AbstractRound(char opponent, char player)
        {
            if (!(opponentValues.Contains(opponent) && playerValues.Contains(player)))
                throw new ArgumentException();
            Opponent = opponent;
            Player = player;
        }

        public abstract int PlayerScore { get; }

        public override string ToString()
        {
            return $"{Opponent}, {Player} => {PlayerScore}";
        }
    }
}
