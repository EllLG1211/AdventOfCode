using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    public class LdwRound : AbstractRound
    {
        public LdwRound(char opponent, char player) : base(opponent, player)
        {
        }

        public override int PlayerScore => Player switch
        {
            'X' => 0 + Opponent switch
            {
                'A' => 3,
                'B' => 1,
                'C' => 2
            },
            'Y' => 3 + Opponent switch
            {
                'A' => 1,
                'B' => 2,
                'C' => 3
            },
            'Z' => 6 + Opponent switch
            {
                'A' => 2,
                'B' => 3,
                'C' => 1
            }
        };
    }
}
