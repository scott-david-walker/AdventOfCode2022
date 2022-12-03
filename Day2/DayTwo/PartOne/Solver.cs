namespace Day2.PartOne;

public class Solver
{
    public int Solve(IEnumerable<string> input)
    {
        var dict = new Dictionary<string, int>();
        const int Rock = 1;
        const int Paper = 2;
        const int Scissors = 3;
        dict.Add("A", Rock);
        dict.Add("B", Paper);
        dict.Add("C", Scissors);
        dict.Add("X", Rock);
        dict.Add("Y", Paper);
        dict.Add("Z", Scissors);

        int PointCalculation(int opponent, int me)
        {
            var score = 0;
            score += me;
            if (opponent == me)
            {
                score += 3;
            }

            if (me == Rock && opponent == Scissors || me == Paper && opponent == Rock || me == Scissors && opponent == Paper)
            {
                score += 6;
            }
            return score;

        }

        var score = 0;
        foreach (var line in input)
        {
            var values =line.Split(" ");
            var opponent = values.First();
            var me = values.Last();
            score += PointCalculation(dict[opponent], dict[me]);
        }

        return score;
    }
}