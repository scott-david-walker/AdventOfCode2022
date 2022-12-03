// See https://aka.ms/new-console-template for more information

var lines = File.ReadLines("Data/Input.txt");
var currentCount = 0;
var caloriesPerElf = new List<int>();
var index = 0;
foreach (var line in lines)
{
    if (string.IsNullOrWhiteSpace(line))
    {
        caloriesPerElf.Add(currentCount);
        currentCount = 0;
        continue;
    }

    currentCount += int.Parse(line);
    index++;
    Console.WriteLine(index);
}

var partOne = caloriesPerElf.OrderByDescending(x=>x).Take(1).Sum();
var partTwo = caloriesPerElf.OrderByDescending(x=>x).Take(3).Sum();
Console.WriteLine(partTwo);