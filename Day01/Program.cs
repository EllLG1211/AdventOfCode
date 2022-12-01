using Day1;

Console.WriteLine("Advent of code, day 1");

#region Part One
Console.WriteLine("Part one: get the elf who carries the most calories\n");


Console.WriteLine("Calories carried by each elf, in descending order:");
var values = from value in new InputReader().GetInput() orderby value descending select value;
foreach (var value in values) Console.WriteLine(value);

Console.WriteLine($"Elf with the most calories carries {values.First()} calories.");
#endregion

Console.WriteLine();

#region Part Two
Console.WriteLine("Part two: get the total calories from the top three elves\n");

Console.WriteLine("Top three elves:");
var topThree = values.Take(3);
foreach (var value in topThree) Console.WriteLine(value);

Console.WriteLine($"The top three elves regroup {topThree.Sum()} calories.");
#endregion