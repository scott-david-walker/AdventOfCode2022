// See https://aka.ms/new-console-template for more information

using DayThree.PartOne;
using DayThree.PartTwo;

var lines = File.ReadLines("Data/Input.txt");
var partOne = new PartOneSolver().Solve(lines);
var partTwo = new PartTwoSolver().Solve(lines);
Console.WriteLine(partOne);
Console.WriteLine(partTwo);