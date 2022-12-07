namespace DaySeven.PartOne;

public class PartOneSolver
{
    public int Solve(Node node)
    {
        var nodes = node.Children.Flatten(t=>t.Children);
        var result = nodes.Where(t => t.Total <= 100000).Sum(t=>t.Total);
        return result;
    }
}