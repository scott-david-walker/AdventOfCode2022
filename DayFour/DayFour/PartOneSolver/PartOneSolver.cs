namespace DayFour.PartOneSolver;

public class PartOneSolver
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
            if (FullOverlap(elf1Range, elf2Range))
            {
                overlapCount++;
            }
            else if (FullOverlap(elf2Range, elf1Range))
            {
                overlapCount++;
            }
    
        }

        return overlapCount;
    }
    private bool FullOverlap(Helpers.CleaningRooms elf1, Helpers.CleaningRooms elf2)
    {
        if (elf1.StartRoom <= elf2.StartRoom && elf1.EndRoom >= elf2.EndRoom)
        {
            return true;
        }

        return false;
    }
}