public class Node
{
    public Node? Parent { get; set; }
    public string Name { get; set; }
    public List<Node> Children { get; } = new();
    public List<TestFile> Files { get; } = new();
    public int Total => Children.Sum(t=>t.Total) + Files.Sum(t => t.Size);

}