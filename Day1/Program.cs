using Day1;

Console.WriteLine("Advent of code, day 1");

#region Part One
Console.WriteLine("Part one: get the elf who carries the most calories\n");


Console.WriteLine("Calories carried by each elf, in descending order:");
var values = from element in new InputReader().GetInput() orderby element descending select element;
foreach (var value in values) Console.WriteLine(value);

Console.WriteLine();
Console.WriteLine($"Elf with the most calories carries {values.First()} calories.");
#endregion

