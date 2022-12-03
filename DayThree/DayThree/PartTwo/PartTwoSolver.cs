namespace DayThree.PartTwo;

public class PartTwoSolver
{
    public int Solve(IEnumerable<string> lines)
    {
        var bag1 = new HashSet<char>();
        var bag2 = new HashSet<char>();
        var points = new List<int>();
        var groups = lines.Chunk(3);
        foreach (var group in groups)
        {
            foreach (var c in group[0])
            {
                bag1.Add(c);
            }
            foreach (var c in group[1])
            {
                bag2.Add(c);
            }
            foreach (var c in group[2])
            {
                if (!bag1.Contains(c) || !bag2.Contains(c)) continue;
                if (char.IsLower(c))
                {
                    points.Add(c - 96);
                }
                else
                {
                    points.Add(c - 38);
                }

                break;
            }
            bag1.Clear();
            bag2.Clear();
        }

        // foreach (var line in lines)
        // {
        //     var currentString = line.Trim();
        //     var length = currentString.Length;
        //     var bag1Contents = currentString.Substring(0, length / 2);
        //     var bag2Contents = currentString.Substring(length/ 2);
        //     foreach (var c in bag1Contents)
        //     {
        //         bag1.Add(c);
        //     }
        //
        //     foreach (var c in bag2Contents)
        //     {
        //         if (!bag1.Contains(c))
        //         {
        //     
        //         }
        //         else
        //         {
        //             
        //             break;;
        //         }
        //     }
        //     bag1.Clear();
        // }

        return points.Sum();
    }
}