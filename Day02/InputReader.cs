namespace Day02
{ 
    public class InputReader
    {
        private const string FILENAME = "input2.txt";
        public IEnumerable<AbstractRound> GetInput()
        {
            List<AbstractRound> rounds = new();
            string[] lines = File.ReadAllLines(FILENAME);
            foreach (var line in lines)
            {
                var chars = line.Split(' ');
                var opponent = char.Parse(chars[0]);
                var player = char.Parse(chars[1]);
                rounds.Add(RoundFactory(opponent, player));
            }
            return rounds;
        }

        private Func<char, char, AbstractRound> RoundFactory;

        public InputReader(Func<char, char, AbstractRound> roundFactory)
        {
            RoundFactory = roundFactory;
        }
    }
}