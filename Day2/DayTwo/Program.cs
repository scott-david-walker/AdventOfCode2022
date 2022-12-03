// See https://aka.ms/new-console-template for more information

using Day2.PartOne;

var lines = File.ReadLines("Data/Input.txt");
var partOne = new Solver().Solve(lines);
var partTwo = new Day2.PartTwo.Solver().Solve(lines);
Console.WriteLine(partOne);
Console.WriteLine(partTwo);