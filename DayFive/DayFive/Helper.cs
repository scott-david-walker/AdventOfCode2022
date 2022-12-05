namespace DayFive;

public class Helper
{
    public static void PushToStack(string items, Stack<string> stack)
    {
        var characters = items.ToCharArray();
        foreach (var character in characters)
        {
            stack.Push(character.ToString());
        }
    }

    public class Crane
    {
        public int Amount { get; set; }
        public int IndexFrom { get; set; }
        public int IndexTo { get; set; }
    }
}