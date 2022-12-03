namespace Day2.PartTwo;

public class Solver
{
    public enum WinLoseDraw
    {
        Win,
        Lose,
        Draw
    }
    public int Solve(IEnumerable<string> input)
    {
        var dict = new Dictionary<string, int>();
        const int Rock = 1;
        const int Paper = 2;
        const int Scissors = 3;
        dict.Add("A", Rock);
        dict.Add("B", Paper);
        dict.Add("C", Scissors);
        
        var winLoseDraw = new Dictionary<string, WinLoseDraw>();
        winLoseDraw.Add("X", WinLoseDraw.Lose);
        winLoseDraw.Add("Y", WinLoseDraw.Draw);
        winLoseDraw.Add("Z", WinLoseDraw.Win);
        int PointCalculation(int opponent, WinLoseDraw me)
        {
            var score = 0;
            if (me == WinLoseDraw.Draw)
            {
                score += 3;
                score += opponent;
            }

            if (me == WinLoseDraw.Win)
            {
                score += 6;
                if (opponent == Rock) score += Paper;
                if (opponent == Scissors) score += Rock;
                if (opponent == Paper) score += Scissors;
            }

            if (me == WinLoseDraw.Lose)
            {
                if (opponent == Rock) score += Scissors;
                if (opponent == Scissors) score += Paper;
                if (opponent == Paper) score += Rock;
            }
            
            return score;

        }

        var score = 0;
        foreach (var line in input)
        {
            var values =line.Split(" ");
            var opponent = values.First();
            var me = values.Last();
            score += PointCalculation(dict[opponent], winLoseDraw[me]);
        }

        return score;
    }
}