// 4 for part one
// 14 for part two
const int amountToSkip = 14;
var data = File.ReadAllText("Data/Input.txt");
var characterLocation = 0;
var initialData = data.Substring(0, amountToSkip).ToList();

var charCounter = amountToSkip;
foreach (var c in data.Skip(amountToSkip))
{
    initialData.RemoveAt(0);
    initialData.Add(c);
    charCounter++;
    if (initialData.Distinct().Count() != amountToSkip)
    {
        continue;
    }

    break;
}

Console.WriteLine(charCounter);