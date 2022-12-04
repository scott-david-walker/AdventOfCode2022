namespace DayFour;

public class Helpers
{
    public CleaningRooms GetElfRooms(string elfWork)
    {
        var rangeOfWorkElf = elfWork.Split("-");
        var startingRoom = Convert.ToInt32(rangeOfWorkElf[0]);
        var endingRoom = Convert.ToInt32(rangeOfWorkElf[1]);
        return new CleaningRooms(startingRoom, endingRoom);
    }
    public class CleaningRooms
    {
        public int StartRoom { get; }
        public int EndRoom { get; }

        public CleaningRooms(int startRoom, int endRoom)
        {
            StartRoom = startRoom;
            EndRoom = endRoom;
        }
    } 
}