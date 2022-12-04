// See https://aka.ms/new-console-template for more information

using DayFour.PartOneSolver;
using DayFour.PartTwoSolver;

var lines = File.ReadLines("Data/Input.txt");

Console.WriteLine(new PartOneSolver().Solve(lines));
Console.WriteLine(new PartTwoSolver().Solve(lines));

