// See https://aka.ms/new-console-template for more information

var lines = File.ReadLines("Data/input.txt");

var trie = new Trie
{
    Children = new()
};
Node? currentNode = null;
foreach (var line in lines)
{
    if (line.StartsWith("$"))
    {
        var instruction = line.Split(" ");
        if (instruction[1] == "cd")
        {
            ChangeDirectory(instruction[2]);
        }
    }
    else if (line.StartsWith("dir"))
    {
        var instruction = line.Split(" ");
        AddDirectoryToNode(instruction[1]);
    }
    else // presume file
    {
        var file = line.Split(" ");
        AddFile(new TestFile
        {
            Name = file[1],
            Size = Convert.ToInt32(file[0])
        });
    }
}

Console.WriteLine(trie);
var sum = trie.Children[0].Files.Select(t => t.Size).Sum();
Console.WriteLine(CalculateDirectorySizes(trie.Children[0], 0));

int CalculateDirectorySizes(Node node, int sum)
{
    var x = node.Files.Select(t => t.Size).Sum();
    sum += x;
    foreach (var child in node.Children)
    {
        return CalculateDirectorySizes(child, sum);
    }

    return sum;
}
void ChangeDirectory(string dir)
{
    if (dir == "..")
    {
        currentNode = currentNode.Parent;
        return;
    }

    if (currentNode == null)
    {
        var node = trie.Children.FirstOrDefault(t => t.Name == dir);
        if (node == null)
        {
            var newNode = new Node
            {
                Name = dir,
                Parent = currentNode
            };
            trie.Children.Add(newNode);
            currentNode = newNode;
        }
        else
        {
            currentNode = node;
        }
    }
    else
    {
        var node = currentNode.Children.FirstOrDefault(t => t.Name == dir);
        if (node == null)
        {
            var newNode = new Node
            {
                Name = dir,
                Parent = currentNode
            };
            trie.Children.Add(newNode);
            currentNode = newNode;
        }
        else
        {
            currentNode = node;
        }
    }

}

void AddDirectoryToNode(string dir)
{
    var node = currentNode.Children.FirstOrDefault(t => t.Name == dir);
    if (node == null)
    {
        currentNode.Children.Add(new Node
        {
            Name = dir,
            Parent = currentNode
        });
    }
}

void AddFile(TestFile file)
{
    currentNode.Files.Add(file);
}
class Trie
{
    public List<Node> Children { get; set; }
}

class Node
{
    public Node? Parent { get; set; }
    public string Name { get; set; }
    public List<Node> Children { get; set; } = new();
    public List<TestFile> Files { get; set; } = new();
}

class TestFile
{
    public string Name { get; set; }
    public int Size { get; set; }
}