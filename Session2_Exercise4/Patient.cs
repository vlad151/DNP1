namespace Session2_Exercise4;

public class Patient
{
    private int NumberInQueue;
    private WaitingRoom WaitingRoom;
    public Patient(WaitingRoom wr)
    {
        
        NumberInQueue = wr.DrawNumber();
        this.WaitingRoom = wr;
        wr.NumberChange += ReactToNumber;


        Console.WriteLine($"Patient number {NumberInQueue} enters the waiting room");
    }

    public void ReactToNumber(int ticketNumber)
    {
        Console.WriteLine($" patient number {ticketNumber} looks up");
        if (ticketNumber == NumberInQueue)
        {
            Console.WriteLine($" Patient {NumberInQueue} goes into the doctor room");
            WaitingRoom.NumberChange -= ReactToNumber;
        }
        else
        {
            Console.WriteLine($" Patient {NumberInQueue} goes back to play with phone");
        }
    }
}