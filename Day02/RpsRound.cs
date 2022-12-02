using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    public class RpsRound : AbstractRound
    {
        public RpsRound(char opponent, char player) : base(opponent, player)
        {
        }

        public override int PlayerScore => Player switch
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
