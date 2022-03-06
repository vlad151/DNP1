namespace Session2_Exercise4;

class Program
{
    public static void Main(string[] args)
    {
        WaitingRoom waitingRoom = new();
        Patient p1 = new(waitingRoom);
        Patient p2 = new(waitingRoom);

        Patient p3 = new(waitingRoom);

        Patient p4 = new(waitingRoom);


        waitingRoom.RunWaitingRoom();
    }
}