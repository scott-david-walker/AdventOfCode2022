// See https://aka.ms/new-console-template for more information

var lines = File.ReadLines("Data/input.txt");

var gridWidth = lines.FirstOrDefault().Length;
var gridLength = lines.Count();
var tress = new Tree[gridLength,gridWidth];

var length = 0;
foreach (var line in lines)
{
    var chars = line.ToCharArray();

    for(var i = 0; i < chars.Length - 1; i++)
    {
        tress[length,i] = new Tree();
    }
    length++;
}
class Tree
{
    public bool IsBlockedFromAbove { get; set; }
    public bool IsBlockedFromBelow { get; set; }
    public bool IsBlockedFromLeft { get; set; }
    public bool IsBlockedFromRight { get; set; }
}