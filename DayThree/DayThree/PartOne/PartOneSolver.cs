namespace DayThree.PartOne;

public class PartOneSolver
{
    public int Solve(IEnumerable<string> lines)
    {
        var bag1 = new HashSet<char>();
        var points = new List<int>();
        foreach (var line in lines)
        {
            var currentString = line.Trim();
            var length = currentString.Length;
            var bag1Contents = currentString.Substring(0, length / 2);
            var bag2Contents = currentString.Substring(length/ 2);
            foreach (var c in bag1Contents)
            {
                bag1.Add(c);
            }

            foreach (var c in bag2Contents)
            {
                if (!bag1.Contains(c))
                {
            
                }
                else
                {
                    if (char.IsLower(c))
                    {
                        points.Add(c - 96);
                    }
                    else
                    {
                        points.Add(c - 38);
                    }
                    break;;
                }
            }
            bag1.Clear();
        }

        return points.Sum();
    }
}