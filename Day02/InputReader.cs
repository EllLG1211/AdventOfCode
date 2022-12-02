namespace Day02
{ 
    public class InputReader
    {
        private const string FILENAME = "input2.txt";
        public IEnumerable<Round> GetInput()
        {
            List<Round> rounds = new();
            string[] lines = File.ReadAllLines(FILENAME);
            foreach (var line in lines)
            {
                var chars = line.Split(' ');
                var opponent = char.Parse(chars[0]);
                var player = char.Parse(chars[1]);
                rounds.Add(new Round(opponent, player));
            }
            return rounds;
        }
    }
}