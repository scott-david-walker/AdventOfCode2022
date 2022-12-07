namespace DaySeven.PartTwoSolver;

public class PartTwoSolver
{
    public int Solve(Node node)
    {
        const int fileSystemSpace = 70000000;
        const int requiredSpace = 30000000;
        var nodes = node.Children.Flatten(t=>t.Children);
        var currentSpace = fileSystemSpace - node.Total;
        var spaceToDelete = requiredSpace - currentSpace;
        var result = nodes.OrderBy(d => d.Total)
            .FirstOrDefault(d => d.Total > spaceToDelete)!;
        
        return result.Total;
    }
}