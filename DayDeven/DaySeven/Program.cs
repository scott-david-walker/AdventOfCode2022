using DaySeven.PartOne;
using DaySeven.PartTwoSolver;
void BuildNodes(Node root, IEnumerable<string> lines)
{
    var current = root;
    foreach (var line in lines)
    {
        if (line.StartsWith("$"))
        {
            var instruction = line.Split(" ");
            if (instruction[1] == "cd")
            {
                current = ChangeDirectory(current, instruction[2]);
            }
        }
        else if (line.StartsWith("dir"))
        {
            var instruction = line.Split(" ");
            current.Children.Add(new Node
            {
                Name = instruction[1],
                Parent = current
            });
        }
        else // presume file
        {
            var file = line.Split(" ");
            
            current.Files.Add(new TestFile
            {
                Name = file[1],
                Size = Convert.ToInt32(file[0])
            });
       
        }
    }
}


Node ChangeDirectory(Node currentNode, string directory)
{
    if (directory == "..")
    {
        currentNode = currentNode.Parent;
        return currentNode;
    }

    var node = currentNode.Children.FirstOrDefault(t => t.Name == directory);
    if (node == null)
    {
        var newNode = new Node
        {
            Name = directory,
            Parent = currentNode
        };
        currentNode.Children.Add(newNode);
        currentNode = newNode;
    }
    else
    {
        currentNode = node;
    }

    return currentNode;
}

var lines = File.ReadLines("Data/input.txt");
var root = new Node
{
    Name = "/",
    Parent = null
};

BuildNodes(root, lines);
Console.WriteLine(new PartOneSolver().Solve(root));
Console.WriteLine(new PartTwoSolver().Solve(root));