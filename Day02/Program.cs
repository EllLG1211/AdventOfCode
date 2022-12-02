using Day02;

Console.WriteLine("Advent of code, day 2");

#region Part One
Console.WriteLine("Part one: rock/paper/scissors");

var rounds = new InputReader().GetInput();
foreach (var round in rounds) Console.WriteLine(round.ToString());

Console.WriteLine($"Total score following this input: {rounds.Sum(e => e.PlayerScore)}");
#endregion