// See https://aka.ms/new-console-template for more information

using DayFive;using DayFive.PartOne;
using DayFive.PartTwo;

var stackOne = new Stack<string>();
var stackTwo = new Stack<string>();
var stackThree = new Stack<string>();
var stackFour = new Stack<string>();
var stackFive = new Stack<string>();
var stackSix = new Stack<string>();
var stackSeven = new Stack<string>();
var stackEight = new Stack<string>();
var stackNine = new Stack<string>();
var string1 = "BZT";
var string2 = "VHTDN";
var string3 = "BFMD";
var string4 = "TJGWVQL";
var string5 = "WDGPVFQM";
var string6 = "VZQGHFS";
var string7 = "ZSNRLTCW";
var string8 = "ZHWDJNRM";
var string9 = "MQLFDS";
Helper.PushToStack(string1, stackOne);
Helper.PushToStack(string2, stackTwo);
Helper.PushToStack(string3, stackThree);
Helper.PushToStack(string4, stackFour);
Helper.PushToStack(string5, stackFive);
Helper.PushToStack(string6, stackSix);
Helper.PushToStack(string7, stackSeven);
Helper.PushToStack(string8, stackEight);
Helper.PushToStack(string9, stackNine);


var stackArray = new List<Stack<string>>();
stackArray.Add(stackOne);
stackArray.Add(stackTwo);
stackArray.Add(stackThree);
stackArray.Add(stackFour);
stackArray.Add(stackFive);
stackArray.Add(stackSix);
stackArray.Add(stackSeven);
stackArray.Add(stackEight);
stackArray.Add(stackNine);
var arr = stackArray.ToArray();

var lines = File.ReadLines("Data/input.txt");

// Run in different instances.
// Console.WriteLine(new PartOneSolver().Solve(lines, arr));
Console.WriteLine(new PartTwoSolver().Solve(lines, arr));
