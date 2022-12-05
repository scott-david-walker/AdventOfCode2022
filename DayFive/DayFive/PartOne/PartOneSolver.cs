namespace DayFive.PartOne;

public class PartOneSolver
{
    public string Solve(IEnumerable<string> lines, Stack<string>[] stackArray)
    {
        
        foreach (var line in lines)
        {
            var newLine = line.Replace("move ", "").Replace("from ", "").Replace("to ", "");
            var splitOnNumber = newLine.Split(" ");
            var crane = new Helper.Crane()
            {
                Amount = Convert.ToInt32(splitOnNumber[0]),
                IndexFrom = Convert.ToInt32(splitOnNumber[1]) - 1,
                IndexTo = Convert.ToInt32(splitOnNumber[2]) - 1
            };

            var toRemoveFrom = stackArray[crane.IndexFrom];
            var toAddTo = stackArray[crane.IndexTo];
            var amountToRemove = crane.Amount;

            while (amountToRemove > 0)
            {
                var item = toRemoveFrom.Pop();
                toAddTo.Push(item);
                amountToRemove--;
            }
        }

        var finalString = string.Empty;
        foreach (var sarr in stackArray)
        {
            finalString += sarr.Pop();
        }

        return finalString;
    }
}