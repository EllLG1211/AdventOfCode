using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    public struct Round
    {
        private static readonly char[] opponentValues = { 'A', 'B', 'C' };
        private static readonly char[] playerValues = { 'X', 'Y', 'Z' };

        private readonly char Opponent;
        private readonly char Player;

        public Round(char opponent, char player)
        {
            if (!(opponentValues.Contains(opponent) && playerValues.Contains(player)))
                throw new ArgumentException();
            Opponent = opponent;
            Player = player;
        }

        public int PlayerScore
        {
            get
            {
                return Player switch 
                { 
                    'X' => 1 + Opponent switch
                    {
                        'A' => 3,
                        'B' => 0,
                        'C' => 6
                    },
                    'Y' => 2 + Opponent switch
                    {
                        'A' => 6,
                        'B' => 3,
                        'C' => 0
                    },
                    'Z' => 3 + Opponent switch
                    {
                        'A' => 0,
                        'B' => 6,
                        'C' => 3
                    }
                };
            }
        }

        public override string ToString()
        {
            return $"{Opponent}, {Player} => {PlayerScore}";
        }
    }
}
