namespace DayFour.PartTwoSolver;

public class PartTwoSolver
{
    public int Solve(IEnumerable<string> lines)
    {
        var overlapCount = 0;
        foreach (var line in lines)
        {
            var workload = line.Split(",");
            var elfOneWork = workload.First();
            var elfTwoWork = workload.Last();

            var elf1Range = new Helpers().GetElfRooms(elfOneWork);
            var elf2Range = new Helpers().GetElfRooms(elfTwoWork);
            if (PartialOverlap(elf1Range, elf2Range))
            {
                overlapCount++;
            }
            else if (PartialOverlap(elf2Range, elf1Range))
            {
                overlapCount++;
            }
    
        }

        return overlapCount;
    }
    private bool PartialOverlap(Helpers.CleaningRooms elf1, Helpers.CleaningRooms elf2)
    {
        if (elf1.StartRoom >= elf2.StartRoom && elf1.StartRoom <= elf2.EndRoom)
        {
            return true;
        }
        return false;
    }
}